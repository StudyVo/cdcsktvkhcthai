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
            LoadUserList();
        }

        private void btnManagePosts_Click(object sender, EventArgs e)
        {
            LoadPostList();
        }

        private void LoadUserList()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = db.Users.ToList();
            dataGridView1.Columns["BiChan"].ReadOnly = true;
            AddActionColumn();
        }

        private void LoadPostList()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = db.Posts.ToList();
            dataGridView1.Columns["BiChan"].ReadOnly = true;
            AddActionColumn();
        }

        private void AddActionColumn()
        {
            if (!dataGridView1.Columns.Contains("LockUnLock"))
            {
                var lockButton = new DataGridViewButtonColumn
                {
                    Name = "LockUnLock",
                    HeaderText = "Trạng thái",
                    Text = "Chặn / Mở chặn",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(lockButton);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (columnName != "LockUnLock") return;

            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            var dataSource = dataGridView1.DataSource;

            if (dataSource is List<User>)
            {
                var user = db.Users.Find(id);
                if (user != null && ConfirmToggle(user.BiChan, "người dùng"))
                {
                    user.BiChan = !user.BiChan;
                    db.SaveChanges();
                    LoadUserList();
                }
            }
            else if (dataSource is List<Post>)
            {
                var post = db.Posts.Find(id);
                if (post != null && ConfirmToggle(post.BiChan, "bài đăng"))
                {
                    post.BiChan = !post.BiChan;
                    db.SaveChanges();
                    LoadPostList();
                }
            }
        }

        private bool ConfirmToggle(bool isBanned, string objectName)
        {
            string message = isBanned
                ? $"Bạn có muốn mở chặn {objectName} này không?"
                : $"Bạn có muốn chặn {objectName} này không?";
            return MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
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
    }
}
