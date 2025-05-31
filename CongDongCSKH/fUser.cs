using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CongDongCSKH.Models; // namespace chứa EFDbContext và User
using System.Linq;

namespace CongDongCSKH
{
    public partial class fUser : Form
    {
        private int userId;

        public fUser(int id)
        {
            InitializeComponent();
            userId = id;
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            using (var db = new EFDbContext())
            {
                var user = db.Users.Find(userId);
                if (user != null)
                {
                    textBox1.Text = user.TenNguoiDung;
                    comboBox1.SelectedItem = user.GioiTinh;

                    if (user.NgaySinh != null)
                        dateTimePicker1.Value = user.NgaySinh.Value;

                    // Nếu có thuộc tính Status thì hiển thị, không thì ẩn label4
                    var userType = typeof(User);
                    var statusProp = userType.GetProperty("Status");
                    if (statusProp != null)
                    {
                        string status = statusProp.GetValue(user) as string;
                        label4.Text = $"Trạng thái: {(status ?? "Không rõ")}";
                        label4.Visible = true;
                    }
                    else
                    {
                        label4.Visible = false;
                    }

                    if (!string.IsNullOrEmpty(user.HinhDaiDien) && File.Exists(user.HinhDaiDien))
                    {
                        pictureBox1.Image = Image.FromFile(user.HinhDaiDien);
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox1.Tag = user.HinhDaiDien;
                    }
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            fEditUser editForm = new fEditUser(userId);
            this.Hide();
            editForm.FormClosed += (s, args) => this.Show();
            editForm.Show();
        }
    }
}
