using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CongDongCSKH
{
    partial class fTaonhom
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
            lbTennhom = new Label();
            lbDanhmuc = new Label();
            lbAnh = new Label();
            lbRiengtu = new Label();
            pictureBox1 = new PictureBox();
            txtTennhom = new TextBox();
            txtDanhmuc = new TextBox();
            cb1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbTennhom
            // 
            lbTennhom.AutoSize = true;
            lbTennhom.Location = new Point(108, 54);
            lbTennhom.Name = "lbTennhom";
            lbTennhom.Size = new Size(90, 25);
            lbTennhom.TabIndex = 0;
            lbTennhom.Text = "Tên nhóm";
            // 
            // lbDanhmuc
            // 
            lbDanhmuc.AutoSize = true;
            lbDanhmuc.Location = new Point(108, 90);
            lbDanhmuc.Name = "lbDanhmuc";
            lbDanhmuc.Size = new Size(93, 25);
            lbDanhmuc.TabIndex = 1;
            lbDanhmuc.Text = "Danh mục";
            // 
            // lbAnh
            // 
            lbAnh.AutoSize = true;
            lbAnh.Location = new Point(108, 145);
            lbAnh.Name = "lbAnh";
            lbAnh.Size = new Size(112, 25);
            lbAnh.TabIndex = 2;
            lbAnh.Text = "Ảnh đại diện";
            // 
            // lbRiengtu
            // 
            lbRiengtu.AutoSize = true;
            lbRiengtu.Location = new Point(108, 239);
            lbRiengtu.Name = "lbRiengtu";
            lbRiengtu.Size = new Size(200, 25);
            lbRiengtu.TabIndex = 3;
            lbRiengtu.Text = "Thiết lập quyền riêng tư";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(226, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            //
            // txtTennhom
            // 
            txtTennhom.Location = new Point(206, 52);
            txtTennhom.Name = "txtTennhom";
            txtTennhom.Size = new Size(150, 31);
            txtTennhom.TabIndex = 5;
            // 
            // txtDanhmuc
            // 
            txtDanhmuc.Location = new Point(207, 91);
            txtDanhmuc.Name = "txtDanhmuc";
            txtDanhmuc.Size = new Size(149, 31);
            txtDanhmuc.TabIndex = 6;
            // 
            // cb1
            // 
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb1.FormattingEnabled = true;
            cb1.Items.AddRange(new object[] { "Nhóm công khai", "Nhóm bí mật", "Nhóm riêng tư" });
            cb1.Location = new Point(314, 231);
            cb1.Name = "cb1";
            cb1.Size = new Size(182, 33);
            cb1.TabIndex = 7;
            cb1.SelectedIndexChanged += cb1_SelectedIndexChanged;
            // 
            // fTaonhom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 450);
            Controls.Add(cb1);
            Controls.Add(txtDanhmuc);
            Controls.Add(txtTennhom);
            Controls.Add(pictureBox1);
            Controls.Add(lbRiengtu);
            Controls.Add(lbAnh);
            Controls.Add(lbDanhmuc);
            Controls.Add(lbTennhom);
            Name = "fTaonhom";
            Text = "fTaonhom";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTennhom;
        private Label lbDanhmuc;
        private Label lbAnh;
        private Label lbRiengtu;
        private PictureBox pictureBox1;
        private TextBox txtTennhom;
        private TextBox txtDanhmuc;
        private ComboBox cb1;
    }
}