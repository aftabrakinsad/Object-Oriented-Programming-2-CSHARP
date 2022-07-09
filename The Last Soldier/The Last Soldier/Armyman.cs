using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace The_Last_Soldier
{
    public partial class Armyman : Form
    {
        SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\OBJECT ORIENTED PROGRAMMING 2\Project\DataBase\ArmyManInfo.mdf;Integrated Security=True;Connect Timeout=30");
        public Armyman()
        {
            InitializeComponent();
        }

        private void Armyman_Load(object sender, EventArgs e)
        {
            label4.Text = Login.username;
            label6.Text = Login.id;
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

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            scon.Open();
            string que = "select * from ArmyManLogin where Uni_id = '" + textBox1.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(que, scon);
            SqlDataAdapter sda = new SqlDataAdapter(que, scon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("Please Enter Your ID");
            }
            else if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please Select Mission Name");
            }
            else if (dt.Rows.Count == 1)
            {
                if (checkuniid() == true)
                {
                    MessageBox.Show("Already Registered! You can't Register Again");
                }
                else
                {
                    scon.Open();
                    string quee = "INSERT INTO MISSION (Uni_id, MISSION_NAME) VALUES ('" + textBox1.Text.Trim() + "', '" + comboBox1.SelectedItem + "')";
                    SqlCommand scmd = new SqlCommand(quee, scon);
                    MessageBox.Show("Registered");
                    scmd.ExecuteNonQuery();
                    scon.Close();
                }
            }
            else
            {
                MessageBox.Show("Wrong ID");
            }
            scon.Close();
        }

        private Boolean checkuniid()
        {
            Boolean uniidavaliable = false;
            string que = "SELECT * FROM MISSION WHERE Uni_id = '"+textBox1.Text+"'";
            SqlCommand scmd = new SqlCommand(que, scon);
            scmd.CommandText = que;
            scmd.Connection = scon;
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = scmd;
            DataSet sd = new DataSet();
            sda.Fill(sd);
            if(sd.Tables[0].Rows.Count > 0)
            {
                uniidavaliable = true;
            }
            scon.Close();

            return uniidavaliable;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login rl = new Login();
            MessageBox.Show("Logged Out");
            this.Close();
            rl.Show();
        }
    }
}