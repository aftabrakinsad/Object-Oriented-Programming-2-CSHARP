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
    public partial class Armyman : Form
    {
        public Armyman()
        {
            InitializeComponent();
        }

        private void editpic_bttn1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileo = new OpenFileDialog();
            fileo.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

            if (fileo.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(fileo.FileName);
            }
        }

        private void armymanexit_bttn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }
    }
}
