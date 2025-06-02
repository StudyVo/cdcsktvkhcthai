using CongDongCSKH.Models;
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
    public partial class fMessageNTUser : Form
    {
        private readonly int currentUserId;
        private System.Windows.Forms.Timer realTimeTimer;
        private int? selectedReceiverId = null;
        private DateTime lastMessageTime = DateTime.MinValue;

        public fMessageNTUser(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            InitializeRealTimeChat();
            btnCloseConversation.Visible = false;
        }

        private void InitializeRealTimeChat()
        {
            realTimeTimer = new System.Windows.Forms.Timer();
            realTimeTimer.Interval = 3000; // 3 seconds
            realTimeTimer.Tick += RealTimeTimer_Tick;
            realTimeTimer.Start();
        }

        private void RealTimeTimer_Tick(object sender, EventArgs e)
        {
            if (selectedReceiverId.HasValue)
            {
                LoadConversation(selectedReceiverId.Value);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUsers(txtSearch.Text.Trim());
        }

        private void LoadUsers(string keyword)
        {
            using var db = new EFDbContext();
            var users = db.Users
                          .Where(u => u.Id != currentUserId &&
                                     (u.TenDn.Contains(keyword) || u.TenNguoiDung.Contains(keyword)))
                          .Select(u => new { u.Id, Tên_đăng_nhập = u.TenDn, Tên_người_dùng = u.TenNguoiDung })
                          .ToList();

            dgvUsers.DataSource = users;
            dgvUsers.Columns["Id"].Visible = false;
        }

        private void LoadChatHistory()
        {
            using var db = new EFDbContext();
            var messages = db.MessagesNTs
                             .Where(m => m.NguoiGuiId == currentUserId || m.NguoiNhanId == currentUserId)
                             .GroupBy(m => m.NguoiGuiId == currentUserId ? m.NguoiNhanId : m.NguoiGuiId)
                             .Select(g => new
                             {
                                 UserId = g.Key,
                                 LastTime = g.Max(m => m.ThoiGianGui)
                             })
                             .OrderByDescending(g => g.LastTime)
                             .ToList();

            var history = messages.Select(m =>
            {
                var user = db.Users.FirstOrDefault(u => u.Id == m.UserId);
                return new
                {
                    Id = user.Id,
                    Tên_đăng_nhập = user.TenDn,
                    Tên_người_dùng = user.TenNguoiDung,
                    ThoiGian = m.LastTime
                };
            }).ToList();

            dgvHistory.DataSource = history;
            dgvHistory.Columns["Id"].Visible = false;
            dgvHistory.Columns["ThoiGian"].Visible = false;
        }

        private void LoadConversation(int otherUserId)
        {
            using var db = new EFDbContext();
            var messages = db.MessagesNTs
                             .Where(m => (m.NguoiGuiId == currentUserId && m.NguoiNhanId == otherUserId) ||
                                         (m.NguoiGuiId == otherUserId && m.NguoiNhanId == currentUserId))
                             .OrderBy(m => m.ThoiGianGui)
                             .ToList();

            panelConversation.Controls.Clear();
            int y = 10;
            foreach (var msg in messages)
            {
                var lbl = new Label();
                lbl.Text = msg.NoiDung + "\n(" + msg.ThoiGianGui.ToString("HH:mm dd/MM/yyyy") + ")";
                lbl.AutoSize = true;
                lbl.MaximumSize = new Size(panelConversation.Width - 40, 0);
                lbl.BackColor = msg.NguoiGuiId == currentUserId ? Color.LightBlue : Color.LightGray;
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Padding = new Padding(5);
                lbl.Location = msg.NguoiGuiId == currentUserId
                    ? new Point(panelConversation.Width - lbl.PreferredWidth - 20, y)
                    : new Point(10, y);
                panelConversation.Controls.Add(lbl);
                y += lbl.Height + 10;
            }
            panelConversation.VerticalScroll.Value = panelConversation.VerticalScroll.Maximum;
            panelConversation.PerformLayout();
            btnCloseConversation.Visible = true;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedReceiverId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["Id"].Value);
                LoadConversation(selectedReceiverId.Value);
            }
        }

        private void dgvHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedReceiverId = Convert.ToInt32(dgvHistory.Rows[e.RowIndex].Cells["Id"].Value);
                LoadConversation(selectedReceiverId.Value);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!selectedReceiverId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn người nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                MessageBox.Show("Nội dung tin nhắn không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var message = new MessageNT
            {
                NguoiGuiId = currentUserId,
                NguoiNhanId = selectedReceiverId.Value,
                NoiDung = txtContent.Text.Trim(),
                ThoiGianGui = DateTime.Now
            };

            try
            {
                using var db = new EFDbContext();
                db.MessagesNTs.Add(message);
                db.SaveChanges();
                txtContent.Clear();
                LoadConversation(selectedReceiverId.Value);
                LoadChatHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi tin nhắn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseConversation_Click(object sender, EventArgs e)
        {
            selectedReceiverId = null;
            panelConversation.Controls.Clear();
            btnCloseConversation.Visible = false;
        }

        private void fMessageNTUser_Load(object sender, EventArgs e)
        {
            LoadChatHistory();
        }
    }
}
