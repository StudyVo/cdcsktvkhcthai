namespace CongDongCSKH
{
    partial class fDangbai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBaiDang = new RichTextBox();
            btnThemHinhAnh = new Button();
            pictureBox1 = new PictureBox();
            btnSuaBaiDang = new Button();
            btnXoaBaiDang = new Button();
            label1 = new Label();
            btnDangBai = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBaiDang
            // 
            txtBaiDang.Location = new Point(49, 12);
            txtBaiDang.Name = "txtBaiDang";
            txtBaiDang.Size = new Size(580, 426);
            txtBaiDang.TabIndex = 0;
            txtBaiDang.Text = "";
            // 
            // btnThemHinhAnh
            // 
            btnThemHinhAnh.Location = new Point(285, 21);
            btnThemHinhAnh.Name = "btnThemHinhAnh";
            btnThemHinhAnh.Size = new Size(150, 34);
            btnThemHinhAnh.TabIndex = 1;
            btnThemHinhAnh.Text = "Thêm hình ảnh";
            btnThemHinhAnh.UseVisualStyleBackColor = true;
            btnThemHinhAnh.Click += btnThemHinhAnh_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(441, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 101);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnSuaBaiDang
            // 
            btnSuaBaiDang.Location = new Point(651, 18);
            btnSuaBaiDang.Name = "btnSuaBaiDang";
            btnSuaBaiDang.Size = new Size(139, 34);
            btnSuaBaiDang.TabIndex = 3;
            btnSuaBaiDang.Text = "Sửa bài đăng";
            btnSuaBaiDang.UseVisualStyleBackColor = true;
            btnSuaBaiDang.Click += button2_Click;
            // 
            // btnXoaBaiDang
            // 
            btnXoaBaiDang.Location = new Point(655, 69);
            btnXoaBaiDang.Name = "btnXoaBaiDang";
            btnXoaBaiDang.Size = new Size(135, 34);
            btnXoaBaiDang.TabIndex = 4;
            btnXoaBaiDang.Text = "Xoá bài đăng";
            btnXoaBaiDang.UseVisualStyleBackColor = true;
            btnXoaBaiDang.Click += btnXoaBaiDang_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 24);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 5;
            label1.Text = "Bài đăng";
            // 
            // btnDangBai
            // 
            btnDangBai.Location = new Point(56, 88);
            btnDangBai.Name = "btnDangBai";
            btnDangBai.Size = new Size(112, 34);
            btnDangBai.TabIndex = 6;
            btnDangBai.Text = "Đăng bài";
            btnDangBai.UseVisualStyleBackColor = true;
            btnDangBai.Click += btnDangBai_Click;
            // 
            // fDangbai
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 450);
            Controls.Add(btnDangBai);
            Controls.Add(label1);
            Controls.Add(btnXoaBaiDang);
            Controls.Add(btnSuaBaiDang);
            Controls.Add(pictureBox1);
            Controls.Add(btnThemHinhAnh);
            Controls.Add(txtBaiDang);
            Name = "fDangbai";
            Text = "fDangbai";
            Load += fDangbai_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtBaiDang;
        private Button btnThemHinhAnh;
        private PictureBox pictureBox1;
        private Button btnSuaBaiDang;
        private Button btnXoaBaiDang;
        private Label label1;
        private Button btnDangBai;
    }
}