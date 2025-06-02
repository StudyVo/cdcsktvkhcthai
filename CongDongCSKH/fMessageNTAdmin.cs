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
    public partial class fMessageNTAdmin : Form
    {
        private readonly int currentAdminId;
        private System.Windows.Forms.Timer realTimeTimer;
        private int? selectedReceiverId = null;

        public fMessageNTAdmin(int adminId)
        {
            InitializeComponent();
            currentAdminId = adminId;
            InitializeRealTimeChat();
            btnCloseConversation.Visible = false;
            LoadAdmins("");
        }

        private void InitializeRealTimeChat()
        {
            realTimeTimer = new System.Windows.Forms.Timer();
            realTimeTimer.Interval = 3000;
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
            LoadAdmins(txtSearch.Text.Trim());
        }

        private void LoadAdmins(string keyword)
        {
            using var db = new EFDbContext();
            var query = db.Manages.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(m => m.Id.ToString().Contains(keyword) ||
                                         m.TenDn.Contains(keyword) ||
                                         m.TenNguoiDung.Contains(keyword));
            }

            var admins = query.Select(m => new
            {
                id = m.Id,
                Tên_đăng_nhập = m.TenDn,
                Tên_quản_trị_viên = m.TenNguoiDung
            }).ToList();

            dgvAdmins.DataSource = admins;
        }

        private void LoadChatHistory()
        {
            using var db = new EFDbContext();
            var messages = db.MessagesNTs
                             .Where(m => m.NguoiGuiId == currentAdminId || m.NguoiNhanId == currentAdminId)
                             .GroupBy(m => m.NguoiGuiId == currentAdminId ? m.NguoiNhanId : m.NguoiGuiId)
                             .Select(g => new
                             {
                                 AdminId = g.Key,
                                 LastTime = g.Max(m => m.ThoiGianGui)
                             })
                             .OrderByDescending(g => g.LastTime)
                             .ToList();

            var history = messages.Select(m =>
            {
                var admin = db.Manages.FirstOrDefault(u => u.Id == m.AdminId);
                return new
                {
                    id = admin.Id,
                    Tên_đăng_nhập = admin.TenDn,
                    Tên_quản_trị_viên = admin.TenNguoiDung,
                    ThoiGian = m.LastTime
                };
            }).ToList();

            dgvHistory.DataSource = history;
            dgvHistory.Columns["ThoiGian"].Visible = false;
        }

        private void LoadConversation(int otherAdminId)
        {
            using var db = new EFDbContext();
            var messages = db.MessagesNTs
                             .Where(m => (m.NguoiGuiId == currentAdminId && m.NguoiNhanId == otherAdminId) ||
                                         (m.NguoiGuiId == otherAdminId && m.NguoiNhanId == currentAdminId))
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
                lbl.BackColor = msg.NguoiGuiId == currentAdminId ? Color.LightGreen : Color.LightSalmon;
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Padding = new Padding(5);
                lbl.Location = msg.NguoiGuiId == currentAdminId
                    ? new Point(panelConversation.Width - lbl.PreferredWidth - 20, y)
                    : new Point(10, y);
                panelConversation.Controls.Add(lbl);
                y += lbl.Height + 10;
            }
            panelConversation.VerticalScroll.Value = panelConversation.VerticalScroll.Maximum;
            panelConversation.PerformLayout();
            btnCloseConversation.Visible = true;
        }

        private void dgvAdmins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedReceiverId = Convert.ToInt32(dgvAdmins.Rows[e.RowIndex].Cells["id"].Value);
                LoadConversation(selectedReceiverId.Value);
            }
        }

        private void dgvHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedReceiverId = Convert.ToInt32(dgvHistory.Rows[e.RowIndex].Cells["id"].Value);
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
                NguoiGuiId = currentAdminId,
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

        private void fMessageNTAdmin_Load(object sender, EventArgs e)
        {
            LoadChatHistory();
        }
    }
}
