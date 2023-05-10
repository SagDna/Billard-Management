using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billard_Management
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_tk.Text.Trim().Length != 0 && txt_mk.Text.Trim().Length != 0)
            {
                this.Hide();
                homePage newHomePage = new homePage();
                newHomePage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống!!", "LÔI KHÔNG NHẬP TÀI KHOẢN-MẬT KHẨU", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_tk_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            txt_tk.Clear();
            txt_mk.Clear();
            txt_tk.Focus();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
