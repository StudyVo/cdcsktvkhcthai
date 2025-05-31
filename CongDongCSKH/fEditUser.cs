using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CongDongCSKH.Models;

namespace CongDongCSKH
{
    public partial class fEditUser : Form
    {
        private int userId;
        private User currentUser;

        public fEditUser(int id)
        {
            InitializeComponent();
            userId = id;
            LoadUserData();
        }

        private void LoadUserData()
        {
            using (var db = new EFDbContext())
            {
                currentUser = db.Users.Find(userId);
                if (currentUser != null)
                {
                    textBoxHoTen.Text = currentUser.TenNguoiDung;
                    comboBoxGioiTinh.SelectedItem = currentUser.GioiTinh;
                    if (currentUser.NgaySinh.HasValue)
                        dateTimePickerNgaySinh.Value = currentUser.NgaySinh.Value;
                    textBoxEmail.Text = currentUser.Email;
                    textBoxPhone.Text = currentUser.Phone;
                    textBoxAddress.Text = currentUser.Address;
                    textBoxMoTa.Text = currentUser.MoTa;
                    if (!string.IsNullOrEmpty(currentUser.HinhDaiDien))
                    {
                        pictureBoxAvatar.Image = Image.FromFile(currentUser.HinhDaiDien);
                        pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBoxAvatar.Tag = currentUser.HinhDaiDien;
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                if (!string.IsNullOrEmpty(textBoxOldPass.Text) || !string.IsNullOrEmpty(textBoxNewPass.Text) || !string.IsNullOrEmpty(textBoxConfirmPass.Text))
                {
                    if (textBoxOldPass.Text != currentUser.Password)
                    {
                        MessageBox.Show("Mật khẩu hiện tại không đúng.");
                        return;
                    }
                    if (textBoxNewPass.Text != textBoxConfirmPass.Text)
                    {
                        MessageBox.Show("Mật khẩu mới không trùng khớp.");
                        return;
                    }
                    currentUser.Password = textBoxNewPass.Text;
                }

                currentUser.TenNguoiDung = textBoxHoTen.Text;
                currentUser.GioiTinh = comboBoxGioiTinh.SelectedItem?.ToString();
                currentUser.NgaySinh = dateTimePickerNgaySinh.Value;
                currentUser.Email = textBoxEmail.Text;
                currentUser.Phone = textBoxPhone.Text;
                currentUser.Address = textBoxAddress.Text;
                currentUser.MoTa = textBoxMoTa.Text;

                using (var db = new EFDbContext())
                {
                    db.Users.Update(currentUser);
                    db.SaveChanges();
                }

                MessageBox.Show("Đã lưu thành công");
                this.Close();
            }
        }
    }
}
