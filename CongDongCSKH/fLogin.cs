using System;
using System.Linq;
using System.Windows.Forms;
using CongDongCSKH.Models; // Import để sử dụng User
using Microsoft.EntityFrameworkCore;

namespace CongDongCSKH
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            // Có thể thêm logic khởi tạo nếu cần
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fDangky dangky = new fDangky();
            dangky.ShowDialog();
        }

        private void btLoginManager_Click(object sender, EventArgs e)
        {
            fLoginManager loginManager = new fLoginManager();
            loginManager.ShowDialog();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtName.Text.Trim();
            string matKhau = txtPassword.Text;

            if (string.IsNullOrEmpty(tenDangNhap))
            {
                toolTip1.Show("Vui lòng nhập tên đăng nhập", txtName, 0, -20, 3000);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(matKhau))
            {
                toolTip1.Show("Vui lòng nhập mật khẩu", txtPassword, 0, -20, 3000);
                txtPassword.Focus();
                return;
            }

            using (var db = new EFDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.TenDn == tenDangNhap && u.Password == matKhau);
                if (user != null)
                {
                    // Đăng nhập thành công
                    this.Hide();
                    fUser userForm = new fUser(user.Id); // ✅ truyền ID
                    userForm.FormClosed += (s, args) => this.Show(); // Mở lại login khi đóng user form
                    userForm.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnĐăngnhập_Click(object sender, EventArgs e)
        {
            // Đây là nút thừa (có thể bỏ), hoặc gọi lại btLogin_Click nếu muốn dùng chung
            btLogin_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Dùng để test nhanh với userId mặc định
            int testUserId = 1;
            fUser userForm = new fUser(testUserId);
            userForm.ShowDialog();
        }
    }
}
