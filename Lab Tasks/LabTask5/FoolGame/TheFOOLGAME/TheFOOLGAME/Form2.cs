using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFOOLGAME
{
    public partial class foolForm2 : Form
    {
        public foolForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm1 mf1 = new mainForm1();
            mf1.Tag = this;
            mf1.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
