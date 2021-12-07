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

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkuniid() == true)
            {
                MessageBox.Show("Already Registered!");
            }
            else
            {
                scon.Open();
                string que = "INSERT INTO MISSION (Uni_id, MISSION_NAME) VALUES ('" + textBox1.Text.Trim() + "', '" + comboBox1.SelectedItem + "')";
                SqlCommand scmd = new SqlCommand(que, scon);
                scmd.ExecuteNonQuery();
                MessageBox.Show("Registered");
                scon.Close();
            }
        }

        private Boolean checkuniid()
        {
            Boolean uniidavaliable = false;
            scon.Open();
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

        private void button7_Click(object sender, EventArgs e)
        {
            scon.Open();
            SqlCommand cmd = scon.CreateCommand();
            var Image_c = new ImageConverter().ConvertTo(pictureBox1.Image, typeof(Byte[]));
            cmd.Parameters.AddWithValue("@Image_c", Image_c);
            cmd.CommandText = "INSERT INTO Image_collection (Uni_id, Image_c) Values ('"+label6.Text.Trim()+"' ,@Image_c)";

            if(cmd.ExecuteNonQuery()>0)
            {
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("Try Again!");
            }
            scon.Close();       
        }
    }
}
