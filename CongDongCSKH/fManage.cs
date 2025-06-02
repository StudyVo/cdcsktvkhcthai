using CongDongCSKH.Models;
using CongDongCSKH.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CongDongCSKH
{
    public partial class fManage : Form
    {
        private readonly int adminId;
        private Manage? currentManage;
        private EFDbContext db = new EFDbContext();

        public fManage(int id)
        {
            InitializeComponent();
            adminId = id;
            LoadManageInfo();
        }

        private void LoadManageInfo()
        {
            try
            {
                currentManage = db.Manages.Find(adminId);
                if (currentManage == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin quản trị viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                labelHoTen.Text = $"Họ tên: {currentManage.TenNguoiDung}";
                labelEmail.Text = $"Email: {currentManage.Email}";
                labelMoTa.Text = $"Mô tả: {currentManage.MoTa ?? "(Chưa có)"}";

                LoadAvatar(currentManage.HinhDaiDien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAvatar(string? fileName)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "Admin Picture", fileName ?? "");
                if (!string.IsNullOrWhiteSpace(fileName) && File.Exists(path))
                {
                    using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    pictureBoxAvatar.Image = Image.FromStream(fs);
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

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            try
            {
                using var editForm = new fEditManage(adminId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrWhiteSpace(editForm.NewAvatarFileName))
                        LoadAvatar(editForm.NewAvatarFileName);
                    LoadManageInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form chỉnh sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xem tất cả khóa học đang được phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            dataGridViewMain.Columns.Clear(); // Xóa các cột cũ
            dataGridViewMain.DataSource = db.Users.ToList(); // Nạp dữ liệu

            // Không cho phép chỉnh sửa cột "BịChặn"
            dataGridViewMain.Columns["BiChan"].ReadOnly = true;

            AddActionColumns(); // Thêm 2 nút Lock / Unlock
        }

        //private void btnManagePosts_Click(object sender, EventArgs e)
        //{
        //    dataGridViewMain.Columns.Clear(); // Xóa các cột cũ
        //    dataGridViewMain.DataSource = db.Posts.ToList(); // Nạp dữ liệu

        //    // Không cho phép chỉnh sửa cột "BịChặn"
        //    dataGridViewMain.Columns["BiChan"].ReadOnly = true;


        //    AddActionColumns(); // Thêm 2 nút Lock / Unlock
        //}

        private void AddActionColumns()
        {
            // Thêm nút LOCK
            DataGridViewButtonColumn lockButton = new DataGridViewButtonColumn();
            lockButton.Name = "LockUnLock";
            lockButton.HeaderText = "Trạng thái";
            lockButton.Text = "Chặn / Mở chặn";
            lockButton.UseColumnTextForButtonValue = true;
            dataGridViewMain.Columns.Add(lockButton);
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // Bỏ qua header

            string columnName = dataGridViewMain.Columns[e.ColumnIndex].Name;

            if (columnName == "LockUnLock")
            {
                int id = Convert.ToInt32(dataGridViewMain.Rows[e.RowIndex].Cells["Id"].Value);

                // Kiểm tra kiểu dữ liệu đang hiển thị trong DataGridView
                var dataSource = dataGridViewMain.DataSource;

                //kiểm tra xem nếu dữ liệu đang hiển thị là danh sach người dùng hay bài đăng
                if (dataSource is List<User>)
                {
                    var user = db.Users.FirstOrDefault(u => u.Id == id);
                    if (user != null)
                    {
                        string message;
                        if (user.BiChan)
                        {
                            message = "Bạn có muốn mở chặn người dùng này không?";
                        }
                        else
                        {
                            message = "Bạn có muốn chặn người dùng này không?";
                        }

                        DialogResult result = MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            user.BiChan = !user.BiChan;
                            db.SaveChanges();
                            dataGridViewMain.DataSource = db.Users.ToList();
                        }
                    }
                }
                else if (dataSource is List<Post>)
                {
                    var post = db.Posts.FirstOrDefault(p => p.Id == id);
                    if (post != null)
                    {
                        string message;
                        if (post.BiChan)
                        {
                            message = "Bạn có muốn mở chặn bài đăng này không?";
                        }
                        else
                        {
                            message = "Bạn có muốn chặn bài đăng này không?";
                        }

                        DialogResult result = MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            post.BiChan = !post.BiChan;
                            db.SaveChanges();
                            dataGridViewMain.DataSource = db.Posts.ToList();
                        }
                    }
                }
            }
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            try
            {
                using var messageForm = new fMessageNTAdmin(adminId);
                messageForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form nhắn tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChatbot_Click(object sender, EventArgs e)
        {
            try
            {
                using var chatbotForm = new fChatbot(adminId, "admin");
                chatbotForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở chatbot: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXemDanhSachNguoiDung_Click(object sender, EventArgs e)
        {
            dataGridViewMain.Columns.Clear(); // Xóa các cột cũ
            dataGridViewMain.DataSource = db.Posts.ToList(); // Nạp dữ liệu

            // Không cho phép chỉnh sửa cột "BịChặn"
            dataGridViewMain.Columns["BiChan"].ReadOnly = true;


            AddActionColumns(); // Thêm 2 nút Lock / Unlock
        }
    }
}
