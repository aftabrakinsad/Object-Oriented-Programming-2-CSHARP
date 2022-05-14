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

namespace LoginWithValidation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\OBJECT ORIENTED PROGRAMMING 2\Final Term\Tasks\LabTask7\DB\Logineithverification.mdf;Integrated Security=True;Connect Timeout=30");
            scon.Open();
            string que = "select * from Login_info where username ='"+ textBox1.Text.Trim()+ "' and pass = '" + textBox2.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(que, scon);
            SqlDataAdapter sda = new SqlDataAdapter(que, scon);
            DataTable dt = new DataTable();

            sda.Fill(dt); ;

            if(dt.Rows.Count == 1)
            {
                Home h = new Home();
                this.Hide();
                h.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password");
            }

            cmd.ExecuteNonQuery();
            scon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                button4.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                button3.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "username must be filled");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        
    }
}