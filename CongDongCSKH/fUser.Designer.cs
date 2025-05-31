namespace CongDongCSKH
{
    partial class fUser
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEdit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // textBox1
            this.textBox1.Location = new System.Drawing.Point(130, 30);
            this.textBox1.Size = new System.Drawing.Size(200, 22);

            // comboBox1
            this.comboBox1.Location = new System.Drawing.Point(130, 70);
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });

            // dateTimePicker1
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 110);
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.Format = DateTimePickerFormat.Short;

            // pictureBox1
            this.pictureBox1.Location = new System.Drawing.Point(350, 30);
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;

            // label1
            this.label1.Text = "Họ tên";
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.AutoSize = true;

            // label2
            this.label2.Text = "Giới tính";
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.AutoSize = true;

            // label3
            this.label3.Text = "Ngày sinh";
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.AutoSize = true;

            // label4
            this.label4.Text = "Trạng thái tài khoản";
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.AutoSize = true;

            // buttonEdit
            this.buttonEdit.Text = "Sửa thông tin";
            this.buttonEdit.Location = new System.Drawing.Point(30, 200);
            this.buttonEdit.Size = new System.Drawing.Size(120, 40);
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);

            // fUser
            this.ClientSize = new System.Drawing.Size(550, 280);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEdit);
            this.Text = "Thông tin người dùng";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}