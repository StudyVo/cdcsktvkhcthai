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
    public partial class fLoginManager : Form
    {
        public fLoginManager()
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
                toolTip1.Show("Vui lòng nhập tên đăng nhập", txtName, 0, -20, 3000);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                toolTip1.Show("Vui lòng nhập mật khẩu", txtPassword, 0, -20, 3000);
                txtPassword.Focus();
                return;
            }

            
            this.Hide(); // Ẩn form hiện tại
            fManage manageForm = new fManage();
            manageForm.ShowDialog(); // Mở form quản lý
            this.Close(); // Sau khi fManage đóng, thì đóng luôn form này
        }
    }
}
