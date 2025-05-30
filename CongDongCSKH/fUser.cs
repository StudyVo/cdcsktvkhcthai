using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Thêm để sử dụng Path

namespace CongDongCSKH
{
    public partial class fUser : Form
    {
        public fUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị form fDangbai
            fDangbai dangbaiForm = new fDangbai();
            dangbaiForm.ShowDialog(); // hoặc .Show() nếu bạn không muốn chặn form chính
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị form fTaonhom
            fTaonhom TaonhomForm = new fTaonhom();
            TaonhomForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Tạo OpenFileDialog để cho phép người dùng chọn file hình ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Cấu hình filter cho các loại file hình ảnh
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff|" +
                                   "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                                   "PNG Files (*.png)|*.png|" +
                                   "GIF Files (*.gif)|*.gif|" +
                                   "BMP Files (*.bmp)|*.bmp|" +
                                   "TIFF Files (*.tiff)|*.tiff|" +
                                   "All Files (*.*)|*.*";

            openFileDialog.FilterIndex = 1; // Mặc định chọn "Image Files"
            openFileDialog.Title = "Chọn hình ảnh";
            openFileDialog.Multiselect = false; // Chỉ cho phép chọn 1 file
            openFileDialog.RestoreDirectory = true; // Khôi phục thư mục ban đầu sau khi đóng dialog

            // Hiển thị dialog và kiểm tra kết quả
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy đường dẫn file được chọn
                    string selectedImagePath = openFileDialog.FileName;

                    // Tải và hiển thị hình ảnh lên PictureBox
                    Image selectedImage = Image.FromFile(selectedImagePath);
                    pictureBox1.Image = selectedImage;

                    // Tùy chọn: Điều chỉnh SizeMode để hình ảnh hiển thị phù hợp
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // hoặc StretchImage, CenterImage, Normal

                    // Thông báo thành công (tùy chọn)
                    MessageBox.Show($"Đã tải hình ảnh: {Path.GetFileName(selectedImagePath)}",
                                   "Thành công",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);

                    // Lưu đường dẫn file để sử dụng sau này (tùy chọn)
                    pictureBox1.Tag = selectedImagePath; // Có thể lưu đường dẫn trong Tag property
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("File được chọn không phải là hình ảnh hợp lệ hoặc bị hỏng!",
                                   "Lỗi",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Không tìm thấy file được chọn!",
                                   "Lỗi",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải hình ảnh: {ex.Message}",
                                   "Lỗi",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
            }

            // Giải phóng tài nguyên của dialog
            openFileDialog.Dispose();
        }
    }
}