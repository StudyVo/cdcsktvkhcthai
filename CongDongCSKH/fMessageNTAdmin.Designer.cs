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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvAdmins = new System.Windows.Forms.DataGridView();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.panelConversation = new System.Windows.Forms.Panel();
            this.labelContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCloseConversation = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(300, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(400, 30);
            this.labelTitle.Text = "NHẮN TIN QUẢN TRỊ VIÊN";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelSearch
            this.labelSearch.Location = new System.Drawing.Point(20, 60);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(140, 25);
            this.labelSearch.Text = "Tìm quản trị viên:";

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(160, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 27);

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(420, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // dgvAdmins
            this.dgvAdmins.Location = new System.Drawing.Point(20, 100);
            this.dgvAdmins.Name = "dgvAdmins";
            this.dgvAdmins.ReadOnly = true;
            this.dgvAdmins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmins.Size = new System.Drawing.Size(470, 150);
            this.dgvAdmins.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmins_CellClick);

            // dgvHistory
            this.dgvHistory.Location = new System.Drawing.Point(510, 60);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(360, 190);
            this.dgvHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellClick);

            // panelConversation
            this.panelConversation.AutoScroll = true;
            this.panelConversation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConversation.Location = new System.Drawing.Point(20, 270);
            this.panelConversation.Name = "panelConversation";
            this.panelConversation.Size = new System.Drawing.Size(850, 300);

            // btnCloseConversation
            this.btnCloseConversation.Location = new System.Drawing.Point(820, 240);
            this.btnCloseConversation.Name = "btnCloseConversation";
            this.btnCloseConversation.Size = new System.Drawing.Size(50, 25);
            this.btnCloseConversation.Text = "x Đóng";
            this.btnCloseConversation.UseVisualStyleBackColor = true;
            this.btnCloseConversation.Click += new System.EventHandler(this.btnCloseConversation_Click);
            this.btnCloseConversation.Visible = false;

            // labelContent
            this.labelContent.Location = new System.Drawing.Point(20, 585);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(150, 25);
            this.labelContent.Text = "Nội dung tin nhắn:";

            // txtContent
            this.txtContent.Location = new System.Drawing.Point(170, 585);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(570, 60);

            // btnSend
            this.btnSend.Location = new System.Drawing.Point(750, 585);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 60);
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // fMessageNTAdmin
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 670);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvAdmins);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.panelConversation);
            this.Controls.Add(this.btnCloseConversation);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fMessageNTAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhắn tin quản trị viên";
            this.Load += new System.EventHandler(this.fMessageNTAdmin_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
