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
using System.Text.RegularExpressions;

namespace The_Last_Soldier
{
    public partial class Login : Form
    {
        public static string username, id;
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\OBJECT ORIENTED PROGRAMMING 2\Project\DataBase\ArmyManInfo.mdf;Integrated Security=True;Connect Timeout=30");
        
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void armyloginbttn8_Click(object sender, EventArgs e)
        {
            username = textBox6.Text;
            id = textBox8.Text;
            scon.Open();
            string que = "select * from ArmyManLogin where Username ='" + textBox6.Text.Trim() + "' and PASS ='"+textBox7.Text.Trim()+ "' and Uni_id = '"+textBox8.Text.Trim()+"'";
            SqlCommand cmd = new SqlCommand(que, scon);
            SqlDataAdapter sda = new SqlDataAdapter(que, scon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Armyman ar = new Armyman();
                this.Hide();
                ar.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username, Password or Unique id");
            }
            cmd.ExecuteNonQuery();
            scon.Close();
        }

        private void mregister_bttn_7_Click(object sender, EventArgs e)
        {
            if (checkuniid2() == true)
            {
                MessageBox.Show("Already Have an Account With This ID");
            }
            else
            {
                scon.Open();
                SqlCommand cmd = scon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into User_info_family values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
                cmd.ExecuteNonQuery();
                scon.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("Successfully Registered!");
                scon.Close();
            }
        }

        private Boolean checkuniid2()
        {
            Boolean uniidavaliable = false;
            string que = "SELECT * FROM User_info_family WHERE UNIQUE_ID = '" + textBox2.Text + "'";
            SqlCommand scmd = new SqlCommand(que, scon);
            scmd.CommandText = que;
            scmd.Connection = scon;
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = scmd;
            DataSet sd = new DataSet();
            sda.Fill(sd);
            if (sd.Tables[0].Rows.Count > 0)
            {
                uniidavaliable = true;
            }
            scon.Close();

            return uniidavaliable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                button2.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                button3.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.PasswordChar == '*')
            {
                button4.BringToFront();
                textBox4.PasswordChar = '\0';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.PasswordChar == '\0')
            {
                button5.BringToFront();
                textBox4.PasswordChar = '*';
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox7.PasswordChar == '*')
            {
                button6.BringToFront();
                textBox7.PasswordChar = '\0';
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox7.PasswordChar == '\0')
            {
                button7.BringToFront();
                textBox7.PasswordChar = '*';
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox8.PasswordChar == '\0')
            {
                button9.BringToFront();
                textBox8.PasswordChar = '*';
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox8.PasswordChar == '*')
            {
                button8.BringToFront();
                textBox8.PasswordChar = '\0';
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox10.PasswordChar == '\0')
            {
                button11.BringToFront();
                textBox10.PasswordChar = '*';
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox10.PasswordChar == '*')
            {
                button10.BringToFront();
                textBox10.PasswordChar = '\0';
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox11.PasswordChar == '\0')
            {
                button13.BringToFront();
                textBox11.PasswordChar = '*';
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox11.PasswordChar == '*')
            {
                button12.BringToFront();
                textBox11.PasswordChar = '\0';
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox13.PasswordChar == '\0')
            {
                button15.BringToFront();
                textBox13.PasswordChar = '*';
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox13.PasswordChar == '*')
            {
                button14.BringToFront();
                textBox13.PasswordChar = '\0';
            }
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox12.Text) == true)
            {
                textBox12.Focus();
                errorProvider1.SetError(this.textBox12, "User ID must be filled.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox13_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox13.Text) == true)
            {
                textBox13.Focus();
                errorProvider2.SetError(this.textBox13, "Password is Must.");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox9.Text) == true)
            {
                textBox9.Focus();
                errorProvider3.SetError(this.textBox9, "Please, Enter Your Name.");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox10.Text) == true)
            {
                textBox10.Focus();
                errorProvider4.SetError(this.textBox10, "Password is Must.");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox11.Text) == true)
            {
                textBox11.Focus();
                errorProvider5.SetError(this.textBox11, "Please, Enter Unique ID.");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text) == true)
            {
                textBox6.Focus();
                errorProvider6.SetError(this.textBox6, "Please, Enter Your Name.");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox7.Text) == true)
            {
                textBox7.Focus();
                errorProvider7.SetError(this.textBox7, "Password is Must.");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox8.Text) == true)
            {
                textBox8.Focus();
                errorProvider8.SetError(this.textBox8, "Please, Enter Unique ID.");
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider9.SetError(this.textBox1, "Please, Enter Your Name.");
            }
            else
            {
                errorProvider9.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider10.SetError(this.textBox2, "Please, Enter Unique ID.");
            }
            else
            {
                errorProvider10.Clear();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) == true)
            {
                textBox3.Focus();
                errorProvider11.SetError(this.textBox3, "Please, Enter Your Email.");
            }
            else if (Regex.IsMatch(textBox3.Text, pattern) == false)
            {
                textBox3.Focus();
                errorProvider1.SetError(this.textBox3, "Invalid Email Address.");
            }
            else 
            {
                errorProvider11.Clear();
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text) == true)
            {
                textBox4.Focus();
                errorProvider12.SetError(this.textBox4, "Password is Must.");
            }
            else
            {
                errorProvider12.Clear();
            }
        }

        private void adimnloginbttn10_Click(object sender, EventArgs e)
        {
            scon.Open();
            string que = "SELECT * FROM AdminA WHERE User_id = '"+ textBox12.Text.Trim()+ "' and PASS = '"+ textBox13.Text.Trim()+ "'";
            SqlCommand cmd = new SqlCommand(que, scon);
            SqlDataAdapter sdaa = new SqlDataAdapter(que, scon);
            DataTable dtt = new DataTable();
            sdaa.Fill(dtt);

            if (dtt.Rows.Count == 1)
            {
                Admin ad = new Admin();
                this.Hide();
                ad.Show();
            }
            else
            {
                MessageBox.Show("Invalid Userid or Password");
            }

        }

        private void armyfloginbttn9_Click(object sender, EventArgs e)
        {
            username = textBox9.Text;
            id = textBox11.Text;
            scon.Open();
            string quee = "select * from User_info_family where FNAME = '" + textBox9.Text.Trim() + "' and PASS = '" + textBox10.Text.Trim() + "' and UNIQUE_ID = '" + textBox11.Text.Trim()+"'";
            SqlCommand cmd = new SqlCommand(quee, scon);
            SqlDataAdapter sdaa = new SqlDataAdapter(quee, scon);
            DataTable dtt = new DataTable();
            sdaa.Fill(dtt);
            if (dtt.Rows.Count == 1)
            {
                Armymanfamily arf = new Armymanfamily();
                this.Hide();
                arf.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username, Password or Unique id");
            }

            cmd.ExecuteNonQuery();
            scon.Close();
        }
    }
}