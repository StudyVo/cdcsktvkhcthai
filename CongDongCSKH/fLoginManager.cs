using CongDongCSKH.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CongDongCSKH
{
    public partial class fLoginManager : Form
    {
        public fLoginManager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xử lý sự kiện nút "Đóng"
        /// </summary>
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Xử lý đăng nhập quản trị
        /// </summary>
        private void btSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            string input = txtName.Text.Trim();
            string password = txtPassword.Text;

            try
            {
                using (var context = new EFDbContext())
                {
                    // Cho phép đăng nhập bằng tên đăng nhập hoặc email
                    var manager = context.Manages
                        .FirstOrDefault(m =>
                            (m.TenDn == input || m.Email == input) &&
                            m.Password == password);

                    if (manager != null)
                    {
                        OpenManagerForm(manager.Id);
                    }
                    else
                    {
                        ShowError("Tên đăng nhập/email hoặc mật khẩu không chính xác.");
                        txtPassword.Clear();
                        txtPassword.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đăng nhập:\n" + ex.Message,
                    "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ dữ liệu đầu vào
        /// </summary>
        /// <returns>true nếu hợp lệ, ngược lại false</returns>
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Vui lòng nhập tên đăng nhập hoặc email", txtName, 0, -20, 3000);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                toolTip1.Show("Vui lòng nhập mật khẩu", txtPassword, 0, -20, 3000);
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Mở giao diện quản lý sau khi đăng nhập thành công
        /// </summary>
        /// <param name="managerId">Mã người quản trị</param>
        private void OpenManagerForm(int managerId)
        {
            this.Hide();
            using (var manageForm = new fManage(managerId))
            {
                manageForm.ShowDialog();
            }
            this.Close(); // Đóng sau khi giao diện quản lý kết thúc
        }

        /// <summary>
        /// Hiển thị thông báo lỗi cho người dùng
        /// </summary>
        /// <param name="message">Nội dung lỗi</param>
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}