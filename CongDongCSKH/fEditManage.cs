using CongDongCSKH.Models; // namespace chứa Admin và AppDbContext
using CongDongCSKH.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CongDongCSKH
{
    public partial class fEditManage : Form
    {
        private readonly int manageId;
        private Manage currentManage;
        private string selectedAvatarPath;
        public string NewAvatarFileName { get; private set; }

        public fEditManage(int id)
        {
            InitializeComponent();
            manageId = id;
            LoadManageData();
        }

        private void LoadManageData()
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    currentManage = db.Manages.Find(manageId);
                    if (currentManage == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin quản trị viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                        return;
                    }

                    txtHoTen.Text = currentManage.TenNguoiDung;
                    txtEmail.Text = currentManage.Email;
                    cbGioiTinh.SelectedItem = currentManage.GioiTinh;
                    dtpNgaySinh.Value = currentManage.NgaySinh ?? DateTime.Today;
                    txtMoTa.Text = currentManage.MoTa;

                    LoadAvatar(currentManage.HinhDaiDien);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAvatar(string fileName)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "Admin Picture", fileName ?? "");
                if (!string.IsNullOrWhiteSpace(fileName) && File.Exists(path))
                {
                    using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        pictureBoxAvatar.Image = Image.FromStream(fs);
                    }
                }
                else
                {
                    pictureBoxAvatar.Image = Resources.default_avatar;
                }
            }
            catch
            {
                pictureBoxAvatar.Image = Resources.default_avatar;
            }
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh đại diện";
                ofd.Filter = "Ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedAvatarPath = ofd.FileName;
                    using (var fs = new FileStream(selectedAvatarPath, FileMode.Open, FileAccess.Read))
                    {
                        pictureBoxAvatar.Image = Image.FromStream(fs);
                    }
                    pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (currentManage == null)
            {
                MessageBox.Show("Dữ liệu quản trị viên không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật thông tin cơ bản
            currentManage.TenNguoiDung = txtHoTen.Text.Trim();
            currentManage.Email = txtEmail.Text.Trim();
            currentManage.GioiTinh = cbGioiTinh.SelectedItem?.ToString();
            currentManage.NgaySinh = dtpNgaySinh.Value;
            currentManage.MoTa = txtMoTa.Text.Trim();

            // Cập nhật mật khẩu nếu có nhập
            if (!string.IsNullOrWhiteSpace(txtMatKhauCu.Text) ||
                !string.IsNullOrWhiteSpace(txtMatKhauMoi.Text) ||
                !string.IsNullOrWhiteSpace(txtXacNhanMatKhauMoi.Text))
            {
                if (txtMatKhauCu.Text != currentManage.Password)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtMatKhauMoi.Text != txtXacNhanMatKhauMoi.Text)
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận không khớp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                currentManage.Password = txtMatKhauMoi.Text;
            }

            // Xử lý ảnh đại diện nếu có chọn mới
            if (!string.IsNullOrWhiteSpace(selectedAvatarPath))
            {
                try
                {
                    string ext = Path.GetExtension(selectedAvatarPath);
                    string avatarFileName = $"admin-{manageId}{ext}";
                    string destFolder = Path.Combine(Application.StartupPath, "Admin Picture");
                    string destPath = Path.Combine(destFolder, avatarFileName);

                    Directory.CreateDirectory(destFolder);

                    string[] oldFiles = Directory.GetFiles(destFolder, $"admin-{manageId}.*");
                    foreach (var file in oldFiles)
                    {
                        try { File.Delete(file); } catch { /* bỏ qua nếu không xóa được */ }
                    }

                    File.Copy(selectedAvatarPath, destPath, true);
                    currentManage.HinhDaiDien = avatarFileName;
                    NewAvatarFileName = avatarFileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh đại diện: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Lưu vào cơ sở dữ liệu
            try
            {
                using (var db = new EFDbContext())
                {
                    db.Manages.Update(currentManage);
                    db.SaveChanges();
                }

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
