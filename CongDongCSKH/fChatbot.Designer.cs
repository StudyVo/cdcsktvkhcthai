namespace CongDongCSKH
{
    partial class fChatbot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSessions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMessages;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support — do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanelSessions = new FlowLayoutPanel();
            flowLayoutPanelMessages = new FlowLayoutPanel();
            txtInput = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanelSessions
            // 
            flowLayoutPanelSessions.AutoScroll = true;
            flowLayoutPanelSessions.BackColor = Color.WhiteSmoke;
            flowLayoutPanelSessions.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelSessions.Location = new Point(12, 12);
            flowLayoutPanelSessions.Name = "flowLayoutPanelSessions";
            flowLayoutPanelSessions.Size = new Size(200, 408);
            flowLayoutPanelSessions.TabIndex = 0;
            // 
            // flowLayoutPanelMessages
            // 
            flowLayoutPanelMessages.AutoScroll = true;
            flowLayoutPanelMessages.BackColor = Color.White;
            flowLayoutPanelMessages.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelMessages.Location = new Point(220, 12);
            flowLayoutPanelMessages.Name = "flowLayoutPanelMessages";
            flowLayoutPanelMessages.Size = new Size(550, 360);
            flowLayoutPanelMessages.TabIndex = 1;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(220, 380);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(460, 40);
            txtInput.TabIndex = 2;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(690, 380);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(80, 40);
            btnSend.TabIndex = 3;
            btnSend.Text = "Gửi";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // fChatbot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 430);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(flowLayoutPanelMessages);
            Controls.Add(flowLayoutPanelSessions);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fChatbot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhắn tin với Chatbot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
