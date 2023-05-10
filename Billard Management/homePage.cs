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
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login newLogin = new login();
            newLogin.ShowDialog();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            register newRegister = new register();
            newRegister.ShowDialog();
        }

        private void btn_table_Click(object sender, EventArgs e)
        {
            this.Hide();
            listTable newtableList = new listTable();   
            newtableList.ShowDialog();
        }
    }
}
