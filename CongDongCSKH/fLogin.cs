namespace CongDongCSKH
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fDangky dangky = new fDangky();
            dangky.ShowDialog();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void btLoginManager_Click(object sender, EventArgs e)
        {
            fLoginManager loginManager = new fLoginManager();
            loginManager.ShowDialog();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                toolTip1.Show("Vui lòng nhập tên đăng nhập", txtName, 0, -20, 3000); // hiển thị trong 3 giây
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                toolTip1.Show("Vui lòng nhập mật khẩu", txtPassword, 0, -20, 3000);
                txtPassword.Focus();
                return;
            }
        }

        private void btnĐăngnhập_Click(object sender, EventArgs e)
        {

            fUser UserForm = new fUser();
            UserForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị form fUser
            fUser UserForm = new fUser();
            UserForm.ShowDialog();
        }
        //test
        //test đẩy code
    }
}
