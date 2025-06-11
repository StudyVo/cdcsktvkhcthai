using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CongDongCSKH.Models;

namespace CongDongCSKH
{
    public partial class fCourseManage : Form
    {
        private BindingList<Course> courses = new BindingList<Course>();
        private int nextCourseId = 1;
        private List<Course> courseList = new List<Course>();
        public fCourseManage()
        {
            InitializeComponent();
            dgvCourses.DataSource = courses;
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SetupDataGridView();

            ClearInputFields();
            UpdateButtonStates();

        }
        private void SetupDataGridView()
        {
            dgvCourses.AutoGenerateColumns = false; // Chúng ta sẽ định nghĩa cột thủ công
            dgvCourses.DataSource = courses; // Gán BindingList làm nguồn dữ liệu

            // Định nghĩa các cột
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "Id"; // Phải khớp với tên thuộc tính trong lớp Course
            idColumn.HeaderText = "ID";
            idColumn.Name = "IdColumn";
            idColumn.ReadOnly = true;

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Tên Khoá Học";
            nameColumn.Name = "NameColumn";
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Tự động điều chỉnh độ rộng

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.DataPropertyName = "Description";
            descriptionColumn.HeaderText = "Mô Tả";
            descriptionColumn.Name = "DescriptionColumn";
            descriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvCourses.Columns.Add(idColumn);
            dgvCourses.Columns.Add(nameColumn);
            dgvCourses.Columns.Add(descriptionColumn);

            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.MultiSelect = false; // Chỉ cho phép chọn 1 dòng
            dgvCourses.AllowUserToAddRows = false; // Không cho người dùng tự thêm dòng trực tiếp trên Grid
        }

        private void ClearInputFields()
        {
            txtCourseID.Clear();
            txtCourseName.Clear();
            txtDescription.Clear();
            dgvCourses.ClearSelection(); // Bỏ chọn dòng hiện tại trên DataGridView
            txtCourseName.Focus();
            UpdateButtonStates();
        }
        private void UpdateButtonStates()
        {
            bool rowSelected = dgvCourses.SelectedRows.Count > 0;
            btnEdit.Enabled = rowSelected;
            btnDelete.Enabled = rowSelected;
            btnAdd.Enabled = !rowSelected; // Chỉ cho phép thêm khi không có dòng nào được chọn để sửa
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtCourseName.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên khoá học không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCourseName.Focus();
                return;
            }
            if (courses.Any(c => c.TenKhoaHoc.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Tên khoá học này đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCourseName.Focus();
                return;
            }
            Course newCourse = new Course(nextCourseId++, name, description);
            courses.Add(newCourse); // BindingList sẽ tự động cập nhật DataGridView

            MessageBox.Show("Thêm khoá học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputFields();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khoá học để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Course selectedCourse = dgvCourses.SelectedRows[0].DataBoundItem as Course;

            if (selectedCourse == null) return; // Trường hợp hiếm

            string newName = txtCourseName.Text.Trim();
            string newDescription = txtDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Tên khoá học không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCourseName.Focus();
                return;
            }
            if (courses.Any(c => c.Id != selectedCourse.Id && c.TenKhoaHoc.Equals(newName, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Tên khoá học này đã tồn tại cho một khoá học khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCourseName.Focus();
                return;
            }

            // Cập nhật trực tiếp đối tượng trong BindingList
            selectedCourse.TenKhoaHoc = newName;
            selectedCourse.MoTa = newDescription;
            courses.ResetBindings();
            MessageBox.Show("Cập nhật khoá học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputFields();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khoá học để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Course selectedCourse = dgvCourses.SelectedRows[0].DataBoundItem as Course;
            if (selectedCourse == null) return;

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá khoá học '{selectedCourse.TenKhoaHoc}' không?",
                                                "Xác nhận xoá",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                courses.Remove(selectedCourse); // BindingList sẽ tự động cập nhật DataGridView
                MessageBox.Show("Xoá khoá học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void dgvCourses_SelectionChanged(object sender, EventArgs e)
        {
            // Khi người dùng chọn một dòng trong DataGridView
            if (dgvCourses.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCourses.SelectedRows[0];
                Course selectedCourse = selectedRow.DataBoundItem as Course;

                if (selectedCourse != null)
                {
                    txtCourseID.Text = selectedCourse.Id.ToString();
                    txtCourseName.Text = selectedCourse.TenKhoaHoc;
                    txtDescription.Text = selectedCourse.MoTa;
                }
            }
            else
            {
                // Nếu không có dòng nào được chọn (ví dụ sau khi xoá hoặc clear)
                // thì xoá trắng các ô input, nhưng không gọi ClearInputFields() để tránh vòng lặp vô hạn
                txtCourseID.Clear();
                txtCourseName.Clear();
                txtDescription.Clear();
            }
            UpdateButtonStates();
        }

        private void lblCourseName_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
        
        }

        private void btnAdd_Click_2(object sender, EventArgs e)
        {
            // Sử dụng 'using' để đảm bảo form được giải phóng tài nguyên sau khi đóng
            using (fCreateCourse createForm = new fCreateCourse())
            {
                // Hiển thị form tạo khóa học dưới dạng một hộp thoại (dialog)
                // Code ở fCourseManage sẽ tạm dừng cho đến khi createForm được đóng
                DialogResult result = createForm.ShowDialog();
                createForm.ShowDialog(this);
                // Kiểm tra xem người dùng đã nhấn nút "Lưu" hay chưa
                if (result == DialogResult.OK)
                {
                    // Lấy khóa học mới từ thuộc tính public của createForm
                    Course newCourse = createForm.NewCourse;


                    courseList.Add(newCourse);

                    // Hiển thị thông báo thành công
                    MessageBox.Show($"Đã thêm thành công khóa học: {newCourse.TenKhoaHoc}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
        }
    }
}