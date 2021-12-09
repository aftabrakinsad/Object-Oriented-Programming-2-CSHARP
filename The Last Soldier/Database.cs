using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace The_Last_Soldier
{
    class Database
    {
        SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\OBJECT ORIENTED PROGRAMMING 2\Project\DataBase\ArmyManInfo.mdf;Integrated Security=True;Connect Timeout=30");
        //private string connectionString = "Data Source=.;Initial Catalog=ArmyManInfo;Integrated Security=True";
       //private SqlCommand sqlCommand; //Used to execute the query

        public Database()
        {
            //sqlConnection = new SqlConnection(this.connectionString);
            scon.Open();
        }

        /*public int InsertData(params string[] data)
        {
            string query = $@"INSERT INTO ArmyManLogin (Imagex) values ('{data[0]}')";
            sqlCommand = new SqlCommand(query, scon);
            int rows = sqlCommand.ExecuteNonQuery();
            return rows;
        }
        */
    }

    
}
