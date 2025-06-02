using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CongDongCSKH
{
    public partial class fDangbai : Form
    {
        public fDangbai()
        {
            InitializeComponent();
        }

        private void fDangbai_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Cho phép chỉnh sửa lại nội dung và hình ảnh
            txtBaiDang.ReadOnly = false;
            btnThemHinhAnh.Enabled = true;
        }


        private void btnXoaBaiDang_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ nội dung bài đăng?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Xóa toàn bộ nội dung text
                txtBaiDang.Text = "";

                // Nếu textbox đang ở chế độ ReadOnly thì tạm thời bỏ để có thể xóa
                bool wasReadOnly = txtBaiDang.ReadOnly;
                if (wasReadOnly)
                {
                    txtBaiDang.ReadOnly = false;
                }

                // Xóa toàn bộ nội dung (bao gồm cả hình ảnh nếu có)
                txtBaiDang.Clear();

                // Khôi phục trạng thái ReadOnly nếu cần
                if (wasReadOnly)
                {
                    txtBaiDang.ReadOnly = true;
                }

                // Reset button "Sửa bài đăng" về trạng thái ban đầu nếu đang ở chế độ chỉnh sửa
                if (btnSuaBaiDang.Text == "Lưu bài đăng")
                {
                    btnSuaBaiDang.Text = "Sửa bài đăng";
                    txtBaiDang.BackColor = SystemColors.Control;
                }

                MessageBox.Show("Đã xóa toàn bộ nội dung bài đăng!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemHinhAnh_Click(object sender, EventArgs e)
        {
            // Tạo OpenFileDialog để cho phép người dùng chọn file hình ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Cấu hình filter cho các loại file hình ảnh
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|" + "JPEG Files|*.jpg;*.jpeg|" +
                                   "PNG Files|*.png|" +
                                   "GIF Files|*.gif|" +
                                   "BMP Files|*.bmp|" +
                                   "All Files|*.*";

            openFileDialog.FilterIndex = 1; // Mặc định chọn "Image Files"
            openFileDialog.Title = "Chọn hình ảnh để thêm vào bài đăng";
            openFileDialog.Multiselect = false; // Chỉ cho phép chọn 1 file

            // Hiển thị dialog và kiểm tra kết quả
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy đường dẫn file được chọn
                    string selectedImagePath = openFileDialog.FileName;

                    // Kiểm tra xem textbox có đang ở chế độ ReadOnly không
                    bool wasReadOnly = txtBaiDang.ReadOnly;
                    if (wasReadOnly)
                    {
                        txtBaiDang.ReadOnly = false;
                    }

                    // Có thể thêm hình ảnh vào RichTextBox bằng cách:
                    // 1. Chèn đường dẫn file (text)
                    txtBaiDang.AppendText($"\n[Hình ảnh: {Path.GetFileName(selectedImagePath)}]\n");
                    txtBaiDang.AppendText($"Đường dẫn: {selectedImagePath}\n");

                    // 2. Hoặc nếu sử dụng RichTextBox, có thể chèn hình ảnh thực sự:
                    /*
                    if (txtBaiDang is RichTextBox richTextBox)
                    {
                        Clipboard.SetImage(Image.FromFile(selectedImagePath));
                        richTextBox.Paste();
                    }
                    */

                    // Khôi phục trạng thái ReadOnly nếu cần
                    if (wasReadOnly)
                    {
                        txtBaiDang.ReadOnly = true;
                    }

                    MessageBox.Show($"Đã thêm hình ảnh: {Path.GetFileName(selectedImagePath)}",
                                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm hình ảnh: {ex.Message}",
                                   "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDangBai_Click(object sender, EventArgs e)
        {
            // Vô hiệu hoá textbox và nút thêm hình ảnh
            txtBaiDang.ReadOnly = true;
            btnThemHinhAnh.Enabled = false;

            MessageBox.Show("Bài đăng đã được đăng!");
        }
    }
}