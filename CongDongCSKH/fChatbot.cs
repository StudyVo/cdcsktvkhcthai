using CongDongCSKH.Models;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

// Alias to avoid conflict
using ChatSessionDb = CongDongCSKH.Models.ChatSession;

namespace CongDongCSKH
{
    public partial class fChatbot : Form
    {
        private readonly int userId;
        private readonly string userRole;
        private int currentSessionId = 0;
        private readonly string apiKey = "AIzaSyDeq_420fsG3ahXT74drpfF_qu3iR5HXwg"; // Thay bằng API Key hợp lệ

        public fChatbot(int id, string role)
        {
            InitializeComponent();
            userId = id;
            userRole = role;
            LoadChatSessions();
        }

        private void LoadChatSessions()
        {
            using (var db = new EFDbContext())
            {
                var sessions = db.ChatSessions
                    .Where(s => (userRole == "user" && s.UserId == userId) ||
                                (userRole == "admin" && s.AdminId == userId))
                    .OrderByDescending(s => s.ThoiGianTao)
                    .ToList();

                flowLayoutPanelSessions.Controls.Clear();

                var btnNew = new Button
                {
                    Text = "\u0110oạn chat mới",
                    Width = flowLayoutPanelSessions.Width - 20,
                    Height = 40,
                    BackColor = Color.LightSkyBlue,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                btnNew.Click += (s, e) => StartNewChat();
                flowLayoutPanelSessions.Controls.Add(btnNew);

                foreach (var session in sessions)
                {
                    var panel = new Panel
                    {
                        Width = flowLayoutPanelSessions.Width - 20,
                        Height = 70,
                        BorderStyle = BorderStyle.FixedSingle,
                        Padding = new Padding(3)
                    };

                    var lblName = new Label
                    {
                        Text = session.TenDoanChat,
                        AutoSize = true,
                        Font = new Font("Segoe UI", 10, FontStyle.Regular),
                        Location = new Point(5, 5),
                        Cursor = Cursors.Hand
                    };
                    lblName.Click += (s, e) => LoadMessages(session.Id);

                    var btnRename = new Button
                    {
                        Text = "Đổi tên",
                        AutoSize = true,
                        Location = new Point(5, 35)
                    };
                    btnRename.Click += (s, e) =>
                    {
                        string input = Microsoft.VisualBasic.Interaction.InputBox(
                            "Nhập tên mới:",
                            "Đổi tên đoạn chat",
                            session.TenDoanChat
                        );
                        if (!string.IsNullOrWhiteSpace(input))
                        {
                            using (var db2 = new EFDbContext())
                            {
                                var sss = db2.ChatSessions.Find(session.Id);
                                if (sss != null)
                                {
                                    sss.TenDoanChat = input;
                                    db2.SaveChanges();
                                    LoadChatSessions();
                                }
                            }
                        }
                    };

                    var btnDelete = new Button
                    {
                        Text = "Xóa",
                        AutoSize = true,
                        Location = new Point(btnRename.Right + 10, 35)
                    };
                    btnDelete.Click += (s, e) =>
                    {
                        if (MessageBox.Show("Bạn chắc chắn muốn xóa đoạn chat này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            using (var db2 = new EFDbContext())
                            {
                                var sss = db2.ChatSessions.Find(session.Id);
                                if (sss != null)
                                {
                                    db2.ChatSessions.Remove(sss);
                                    db2.SaveChanges();
                                    LoadChatSessions();
                                    StartNewChat();
                                }
                            }
                        }
                    };

                    panel.Controls.Add(lblName);
                    panel.Controls.Add(btnRename);
                    panel.Controls.Add(btnDelete);
                    flowLayoutPanelSessions.Controls.Add(panel);
                }
            }
        }

        private void StartNewChat()
        {
            currentSessionId = 0;
            flowLayoutPanelMessages.Controls.Clear();
        }

        private void LoadMessages(int sessionId)
        {
            currentSessionId = sessionId;
            flowLayoutPanelMessages.Controls.Clear();

            using (var db = new EFDbContext())
            {
                var messages = db.ChatbotMessages
                    .Where(m => m.ChatSessionId == sessionId)
                    .OrderBy(m => m.ThoiGian)
                    .ToList();

                foreach (var msg in messages)
                {
                    AddMessageToPanel(msg.NoiDung, msg.LaTraLoiTuChatbot, msg.ThoiGian);
                }
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string userMessage = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(userMessage)) return;

            using (var db = new EFDbContext())
            {
                if (currentSessionId == 0)
                {
                    var session = new ChatSessionDb
                    {
                        TenDoanChat = "(Chưa đặt tên)",
                        ThoiGianTao = DateTime.Now,
                        UserId = userRole == "user" ? userId : null,
                        AdminId = userRole == "admin" ? userId : null
                    };
                    db.ChatSessions.Add(session);
                    db.SaveChanges();
                    currentSessionId = session.Id;
                    LoadChatSessions();
                }
            }

            AddMessageToPanel(userMessage, false, DateTime.Now);
            string chatbotResponse = await CallGeminiAPI(userMessage);
            AddMessageToPanel(chatbotResponse, true, DateTime.Now);

            using (var db = new EFDbContext())
            {
                var session = db.ChatSessions.Find(currentSessionId);
                if (session != null && session.TenDoanChat == "(Chưa đặt tên)")
                {
                    session.TenDoanChat = chatbotResponse.Length > 20 ? chatbotResponse.Substring(0, 20) : chatbotResponse;
                    db.SaveChanges();
                    LoadChatSessions();
                }

                db.ChatbotMessages.Add(new ChatbotMessage
                {
                    ChatSessionId = currentSessionId,
                    NoiDung = userMessage,
                    LaTraLoiTuChatbot = false,
                    ThoiGian = DateTime.Now
                });

                db.ChatbotMessages.Add(new ChatbotMessage
                {
                    ChatSessionId = currentSessionId,
                    NoiDung = chatbotResponse,
                    LaTraLoiTuChatbot = true,
                    ThoiGian = DateTime.Now
                });

                db.SaveChanges();
            }

            txtInput.Clear();
        }

        private void AddMessageToPanel(string message, bool isBot, DateTime time)
        {
            var label = new Label
            {
                AutoSize = true,
                MaximumSize = new Size(flowLayoutPanelMessages.Width - 60, 0),
                Text = $"{(isBot ? "Chatbot" : "Bạn")}: {message} ({time:HH:mm:ss dd/MM/yyyy})",
                BackColor = isBot ? Color.LightGray : Color.LightGreen,
                Padding = new Padding(5),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var panel = new Panel
            {
                AutoSize = true,
                Padding = new Padding(5)
            };

            if (isBot)
                panel.Dock = DockStyle.Left;
            else
                panel.Dock = DockStyle.Right;

            panel.Controls.Add(label);
            flowLayoutPanelMessages.Controls.Add(panel);
            flowLayoutPanelMessages.ScrollControlIntoView(panel);
        }

        private async Task<string> CallGeminiAPI(string userMessage)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = $"https://generativelanguage.googleapis.com/v1/models/gemini-pro:generateContent?key={apiKey}";

                    var requestBody = new
                    {
                        contents = new[]
                        {
                            new
                            {
                                role = "user",
                                parts = new[] { new { text = userMessage } }
                            }
                        }
                    };

                    var json = JsonConvert.SerializeObject(requestBody);
                    var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync(url, content);
                    response.EnsureSuccessStatusCode();

                    var responseString = await response.Content.ReadAsStringAsync();
                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseString);
                    return jsonResponse?.candidates?[0]?.content?.parts?[0]?.text?.ToString()?.Trim() ?? "(Không có phản hồi)";
                }
            }
            catch (Exception ex)
            {
                return $"Lỗi khi gọi API Gemini: {ex.Message}";
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                btnSend.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
