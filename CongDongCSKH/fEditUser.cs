using CongDongCSKH.Models;
using CongDongCSKH.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CongDongCSKH
{
    public partial class fEditUser : Form
    {
        private readonly int userId;
        private User currentUser;
        private string selectedAvatarPath;
        public string NewAvatarFileName { get; private set; }

        public fEditUser(int id)
        {
            InitializeComponent();
            userId = id;
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                using (var db = new EFDbContext())
                {
                    currentUser = db.Users.Find(userId);
                    if (currentUser == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                        return;
                    }

                    textBoxHoTen.Text = currentUser.TenNguoiDung;
                    comboBoxGioiTinh.SelectedItem = currentUser.GioiTinh;
                    dateTimePickerNgaySinh.Value = currentUser.NgaySinh ?? DateTime.Today;
                    textBoxEmail.Text = currentUser.Email;
                    textBoxPhone.Text = currentUser.Phone;
                    textBoxAddress.Text = currentUser.Address;
                    textBoxMoTa.Text = currentUser.MoTa;

                    LoadAvatarImage(currentUser.HinhDaiDien);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAvatarImage(string fileName)
        {
            try
            {
                string fullPath = Path.Combine(Application.StartupPath, "User Picture", fileName ?? "");
                if (!string.IsNullOrWhiteSpace(fileName) && File.Exists(fullPath))
                {
                    using (var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
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
            if (currentUser == null)
            {
                MessageBox.Show("Không tìm thấy dữ liệu người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateInputs()) return;

            if (!string.IsNullOrWhiteSpace(textBoxOldPass.Text) ||
                !string.IsNullOrWhiteSpace(textBoxNewPass.Text) ||
                !string.IsNullOrWhiteSpace(textBoxConfirmPass.Text))
            {
                if (textBoxOldPass.Text != currentUser.Password)
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (textBoxNewPass.Text != textBoxConfirmPass.Text)
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận không khớp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                currentUser.Password = textBoxNewPass.Text;
            }

            currentUser.TenNguoiDung = textBoxHoTen.Text.Trim();
            currentUser.GioiTinh = comboBoxGioiTinh.SelectedItem?.ToString();
            currentUser.NgaySinh = dateTimePickerNgaySinh.Value;
            currentUser.Email = textBoxEmail.Text.Trim();
            currentUser.Phone = textBoxPhone.Text.Trim();
            currentUser.Address = textBoxAddress.Text.Trim();
            currentUser.MoTa = textBoxMoTa.Text.Trim();

            if (!string.IsNullOrWhiteSpace(selectedAvatarPath))
            {
                try
                {
                    string ext = Path.GetExtension(selectedAvatarPath);
                    string avatarFileName = $"user-{userId}{ext}";
                    string destFolder = Path.Combine(Application.StartupPath, "User Picture");
                    string destPath = Path.Combine(destFolder, avatarFileName);

                    Directory.CreateDirectory(destFolder);

                    string[] oldFiles = Directory.GetFiles(destFolder, $"user-{userId}.*");
                    foreach (var file in oldFiles)
                    {
                        try { File.Delete(file); } catch { /* bỏ qua nếu lỗi xóa */ }
                    }

                    File.Copy(selectedAvatarPath, destPath, true);
                    currentUser.HinhDaiDien = avatarFileName;
                    NewAvatarFileName = avatarFileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh đại diện: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            try
            {
                using (var db = new EFDbContext())
                {
                    db.Users.Update(currentUser);
                    db.SaveChanges();
                }

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxHoTen.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên và email.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!textBoxEmail.Text.Contains("@") || !textBoxEmail.Text.Contains("."))
            {
                MessageBox.Show("Email không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelMoTa_Click(object sender, EventArgs e)
        {

        }
    }
}
