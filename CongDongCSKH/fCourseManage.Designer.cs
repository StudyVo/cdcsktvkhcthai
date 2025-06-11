namespace CongDongCSKH
{
    partial class fCourseManage
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
            dgvCourses = new DataGridView();
            lblCourseID = new Label();
            lblCourseName = new Label();
            lblDescription = new Label();
            txtCourseID = new TextBox();
            txtCourseName = new TextBox();
            txtDescription = new RichTextBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // dgvCourses
            // 
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(42, 12);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.Size = new Size(703, 215);
            dgvCourses.TabIndex = 0;
            // 
            // lblCourseID
            // 
            lblCourseID.AutoSize = true;
            lblCourseID.Location = new Point(58, 259);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(24, 20);
            lblCourseID.TabIndex = 2;
            lblCourseID.Text = "ID";
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(58, 298);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(33, 20);
            lblCourseName.TabIndex = 3;
            lblCourseName.Text = "Tên";
            lblCourseName.Click += lblCourseName_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(58, 331);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(49, 20);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Mô tả";
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(142, 256);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.ReadOnly = true;
            txtCourseID.Size = new Size(126, 27);
            txtCourseID.TabIndex = 5;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(142, 298);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(357, 27);
            txtCourseName.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(142, 339);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(592, 121);
            txtDescription.TabIndex = 7;
            txtDescription.Text = "";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Location = new Point(672, 488);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Location = new Point(452, 488);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 255, 128);
            btnEdit.Location = new Point(238, 488);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Location = new Point(40, 488);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_2;
            // 
            // fCourseManage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 529);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(txtDescription);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseID);
            Controls.Add(lblDescription);
            Controls.Add(lblCourseName);
            Controls.Add(lblCourseID);
            Controls.Add(dgvCourses);
            Name = "fCourseManage";
            Text = "Quản lí khoá học";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCourses;
        private Label lblCourseID;
        private Label lblCourseName;
        private Label lblDescription;
        private TextBox txtCourseID;
        private TextBox txtCourseName;
        private RichTextBox txtDescription;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}