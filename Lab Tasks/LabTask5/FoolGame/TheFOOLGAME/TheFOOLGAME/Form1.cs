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
    public partial class mainForm1 : Form
    {
        public mainForm1()
        {
            InitializeComponent();
        }

        private void nobutton1_Click(object sender, EventArgs e)
        {
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Space)
            {
                Form3 notfool = new Form3();
                this.Hide();
                notfool.Show();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        int a = 0;
        private void nobutton1_mouseEnter(object sender, EventArgs e)
        {
            Random p = new Random();
            a++;
            Point point = new Point(
            int.Parse(p.Next(700).ToString()),
            int.Parse(p.Next(400).ToString())
            );
            nobutton1.Location = point;
        }

        private void yesbutton1_Click(object sender, EventArgs e)
        {
            foolForm2 ff2 = new foolForm2();
            ff2.Tag = this;
            ff2.Show();
            this.Hide();
        }

        private void mainForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
