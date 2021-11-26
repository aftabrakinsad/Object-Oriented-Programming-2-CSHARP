using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Last_Soldier
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void loginbttn2_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void register_bttn_3_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void armyman_bttn_4_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void armymanf_bttn_5_Click(object sender, EventArgs e)
        {
            panel4.BringToFront();
        }

        private void admin_bttn_6_Click(object sender, EventArgs e)
        {
            panel5.BringToFront();
        }
    }
}
