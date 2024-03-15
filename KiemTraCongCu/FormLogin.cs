using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraCongCu
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                FormSuccess mainForm = new FormSuccess();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng. Vui lòng thử lại!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
