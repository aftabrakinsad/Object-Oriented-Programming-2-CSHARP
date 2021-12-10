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
    public partial class Admin : Form
    {
        SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\OBJECT ORIENTED PROGRAMMING 2\Project\DataBase\ArmyManInfo.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt;
        public Admin()
        {
            InitializeComponent();
        }

        private void armymanexit_bttn_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //Showing Army Table
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BringToFront();
            panel1.BringToFront();
            dataGridView1.BringToFront();
            scon.Open();
            SqlCommand cmd = scon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ARMYMAN";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            scon.Close();
        }

        // Showing Family table
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.BringToFront();
            panel2.BringToFront();
            dataGridView2.BringToFront();
            scon.Open();
            SqlCommand cmd = scon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from User_info_family";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView2.DataSource = dt;
            scon.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Username LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = dv;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("FNAME LIKE '%{0}%'", textBox2.Text);
            dataGridView2.DataSource = dv;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox7.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox8.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Row Selected");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;
            textBox7.Text = String.Empty;
            textBox8.Text = String.Empty;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBox12.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                textBox11.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                textBox10.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                textBox9.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Row Selected");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox12.Text = String.Empty;
            textBox11.Text = String.Empty;
            textBox10.Text = String.Empty;
            textBox9.Text = String.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            scon.Open();
            SqlCommand cmd = scon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from ARMYMAN where Username = '" + textBox3.Text + "'";
            cmd.ExecuteNonQuery();
            scon.Close();
            MessageBox.Show("Deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            scon.Open();
            SqlCommand cmd = scon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO ARMYMAN VALUES('" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "')";
            cmd.ExecuteNonQuery();
            scon.Close();
            MessageBox.Show("Inserted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            scon.Open();
            SqlCommand cmd = scon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE ARMYMAN SET Statuss ='"+textBox3.Text+ "' where Statuss = '" + textBox8.Text+"'";
            cmd.ExecuteNonQuery();
            scon.Close();
            MessageBox.Show("Updated");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            scon.Open();
            SqlCommand cmd = scon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO User_info_family VALUES('" + textBox12.Text + "', '" + textBox11.Text + "', '" + textBox10.Text + "', '" + textBox9.Text + "')";
            cmd.ExecuteNonQuery();
            scon.Close();
            MessageBox.Show("Inserted");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            scon.Open();
            SqlCommand cmd = scon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from User_info_family where FNAME = '" + textBox12.Text + "'";
            cmd.ExecuteNonQuery();
            scon.Close();
            MessageBox.Show("Deleted");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            scon.Open();
            SqlCommand cmd = scon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE User_info_family SET EMAIL ='" + textBox12.Text + "' where EMAIL = '" + textBox10.Text + "'";
            cmd.ExecuteNonQuery();
            scon.Close();
            MessageBox.Show("Updated");
        }
    }
}
