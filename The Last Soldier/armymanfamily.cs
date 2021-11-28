using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace The_Last_Soldier
{
    public partial class Armymanfamily : Form
    {
        
        SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\OBJECT ORIENTED PROGRAMMING 2\Project\DataBase\ArmyManInfo.mdf;Integrated Security=True;Connect Timeout=30");
        public Armymanfamily()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void editpic_bttn2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileo = new OpenFileDialog();
            fileo.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

            if (fileo.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(fileo.FileName);
            }
        }

        private void armymanf_bttn_2_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void Armymanfamily_Load(object sender, EventArgs e)
        {
            GetName();
        }

        public void GetName()
        {
            scon.Open();
            string query = "select * from User_info_family";
            SqlCommand cmd = new SqlCommand(query, scon);
            List<string> data = new List<string>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string temp;
                temp = reader.GetString(reader.GetOrdinal("FNAME"));
                data.Add(temp);
                
            }
            label7.Text = data[0];
        }
    }
}
