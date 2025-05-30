using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CongDongCSKH
{
    public partial class fDangky : Form
    {
        public fDangky()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                toolTip1.Show("Vui lòng nhập tên đăng nhập", txtName, 0, -20, 3000); // hiển thị trong 3 giây
                txtName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                toolTip1.Show("Vui lòng nhập mật khẩu", txtPassword, 0, -20, 3000);
                txtPassword.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                toolTip1.Show("Vui lòng xác nhận mật khẩu", txtConfirmPassword, 0, -20, 3000);
                txtConfirmPassword.Focus();
                return;
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                toolTip1.Show("Mật khẩu và xác nhận mật khẩu không khớp", txtConfirmPassword, 0, -20, 3000);
                txtConfirmPassword.Focus();
                return;
            }
        }
    }
}
