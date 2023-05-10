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
    public partial class listTable : Form
    {
        public listTable()
        {
            InitializeComponent();
        }

        private void listTable_Load(object sender, EventArgs e)
        {

        }

        private void panel_1_Click(object sender, EventArgs e)
        {
            this.Hide();
            tableDetails newTabledetail = new tableDetails();
            newTabledetail.ShowDialog();
        }
    }
}
