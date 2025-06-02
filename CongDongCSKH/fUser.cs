using CongDongCSKH.Models; // namespace chứa EFDbContext và User
using CongDongCSKH.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CongDongCSKH
{
    public partial class fUser : Form
    {
        private readonly int userId;
        private User? currentUser;

        public fUser(int id)
        {
            InitializeComponent();
            userId = id;
            LoadUserInfo();
        }

        /// <summary>
        /// Tải thông tin người dùng từ cơ sở dữ liệu và hiển thị lên giao diện
        /// </summary>
        private void LoadUserInfo()
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

                    textBoxName.Text = currentUser.TenNguoiDung;
                    comboBoxGender.SelectedItem = currentUser.GioiTinh ?? "Không rõ";
                    dateTimePickerNgaySinh.Value = currentUser.NgaySinh ?? DateTime.Today;

                    labelEmail.Text = $"Email: {currentUser.Email}";
                    labelPhone.Text = $"Số điện thoại: {currentUser.Phone ?? "Chưa cập nhật"}";
                    labelAddress.Text = $"Địa chỉ: {currentUser.Address ?? "Chưa cập nhật"}";

                    LoadAvatar(currentUser.HinhDaiDien);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tải ảnh đại diện từ file hoặc dùng ảnh mặc định nếu không có
        /// </summary>
        /// <param name="fileName">Tên file ảnh</param>
        private void LoadAvatar(string? fileName)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "User Picture", fileName ?? "");

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

        /// <summary>
        /// Mở form chỉnh sửa thông tin người dùng
        /// </summary>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var editForm = new fEditUser(userId))
                {
                    var result = editForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        if (!string.IsNullOrWhiteSpace(editForm.NewAvatarFileName))
                        {
                            LoadAvatar(editForm.NewAvatarFileName);
                        }

                        LoadUserInfo(); // Cập nhật lại dữ liệu mới
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form chỉnh sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Mở giao diện nhắn tin giữa người dùng với quản trị viên
        /// </summary>
        private void buttonMessage_Click(object sender, EventArgs e)
        {
            try
            {
                using (var messageForm = new fMessageNTUser(userId))
                {
                    messageForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form nhắn tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Mở chatbot AI dành cho người dùng
        /// </summary>
        private void buttonChatbot_Click(object sender, EventArgs e)
        {
            try
            {
                using (var chatbotForm = new fChatbot(userId, "user")) // ✅ Gọi đúng constructor
                {
                    chatbotForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở chatbot: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Đăng xuất người dùng (đóng form)
        /// </summary>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}