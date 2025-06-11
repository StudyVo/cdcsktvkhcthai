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
    public partial class fCreateCourse : Form
    {
        internal Course NewCourse { get; private set; } // Thuộc tính để lưu khóa học mới được tạo
    
    
        public fCreateCourse()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // Cài đặt một số giá trị mặc định
            this.Text = "Tạo Khóa Học Mới";
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Không cho thay đổi kích thước
            this.StartPosition = FormStartPosition.CenterParent; // Hiển thị form ở giữa form cha
            this.MaximizeBox = false;
            this.MinimizeBox = false;



            // Cài đặt cho DateTimePicker
            dateTimePicker1.Value = DateTime.Now;

        }
             private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra tính hợp lệ của dữ liệu (Validation)
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên khóa học không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus(); // Di chuyển con trỏ tới ô tên
                return;
            }

            NewCourse = new Course
            {
                TenKhoaHoc = txtName.Text.Trim(),
                MoTa = txtDescription.Text.Trim(),
                NgayTao = dateTimePicker1.Value,
                UserId = 1, // Giả sử UserId là 1, bạn có thể thay đổi theo logic của mình
                BiChan = false // Mặc định là không bị chặn
            };
            this.DialogResult = DialogResult.OK; // Trả về kết quả OK khi lưu thành công
            this.Close(); // Đóng form sau khi lưu  
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Đóng form và trả về kết quả Cancel
            // Form cha sẽ biết người dùng đã nhấn "Hủy"
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
