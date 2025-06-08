namespace CongDongCSKH
{
    partial class fMessageNTAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvAdmins = new DataGridView();
            dgvHistory = new DataGridView();
            panelConversation = new Panel();
            labelContent = new Label();
            txtContent = new TextBox();
            btnSend = new Button();
            btnCloseConversation = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.Location = new Point(300, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(400, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "NHẮN TIN QUẢN TRỊ VIÊN";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSearch
            // 
            labelSearch.Location = new Point(20, 60);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(140, 25);
            labelSearch.TabIndex = 1;
            labelSearch.Text = "Tìm quản trị viên:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(160, 60);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(420, 58);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 30);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvAdmins
            // 
            dgvAdmins.ColumnHeadersHeight = 29;
            dgvAdmins.Location = new Point(20, 100);
            dgvAdmins.Name = "dgvAdmins";
            dgvAdmins.ReadOnly = true;
            dgvAdmins.RowHeadersWidth = 51;
            dgvAdmins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdmins.Size = new Size(470, 150);
            dgvAdmins.TabIndex = 4;
            dgvAdmins.CellClick += dgvAdmins_CellClick;
            // 
            // dgvHistory
            // 
            dgvHistory.ColumnHeadersHeight = 29;
            dgvHistory.Location = new Point(510, 60);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(360, 190);
            dgvHistory.TabIndex = 5;
            dgvHistory.CellClick += dgvHistory_CellClick;
            // 
            // panelConversation
            // 
            panelConversation.AutoScroll = true;
            panelConversation.BorderStyle = BorderStyle.FixedSingle;
            panelConversation.Location = new Point(20, 283);
            panelConversation.Name = "panelConversation";
            panelConversation.Size = new Size(850, 287);
            panelConversation.TabIndex = 6;
            // 
            // labelContent
            // 
            labelContent.Location = new Point(20, 585);
            labelContent.Name = "labelContent";
            labelContent.Size = new Size(150, 25);
            labelContent.TabIndex = 8;
            labelContent.Text = "Nội dung tin nhắn:";
            // 
            // txtContent
            // 
            txtContent.Location = new Point(170, 585);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(570, 121);
            txtContent.TabIndex = 9;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Cyan;
            btnSend.Location = new Point(750, 585);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(120, 60);
            btnSend.TabIndex = 10;
            btnSend.Text = "Gửi";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnCloseConversation
            // 
            btnCloseConversation.Location = new Point(820, 252);
            btnCloseConversation.Name = "btnCloseConversation";
            btnCloseConversation.Size = new Size(50, 25);
            btnCloseConversation.TabIndex = 7;
            btnCloseConversation.Text = "x Đóng";
            btnCloseConversation.UseVisualStyleBackColor = true;
            btnCloseConversation.Visible = false;
            btnCloseConversation.Click += btnCloseConversation_Click;
            // 
            // fMessageNTAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 762);
            Controls.Add(labelTitle);
            Controls.Add(labelSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dgvAdmins);
            Controls.Add(dgvHistory);
            Controls.Add(panelConversation);
            Controls.Add(btnCloseConversation);
            Controls.Add(labelContent);
            Controls.Add(txtContent);
            Controls.Add(btnSend);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "fMessageNTAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhắn tin quản trị viên";
            Load += fMessageNTAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvAdmins;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Panel panelConversation;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCloseConversation;
    }
}
