using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Medcine_ManagmentSystem
{
    class UserLogin
    {
        public static bool Insert(string name, string pass, byte[] finger)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO UserLogin(Name,Password,Finger)VALUES(@Name,@Password,@Finger)";
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Password", pass);
            cmd.Parameters.AddWithValue("@Finger", finger);
            con.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
            public static DataTable gettable()
            {
                SqlConnection con = new SqlConnection (Connection.connectionstring);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT Name,Password FROM UserLogin";
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable tab = new DataTable();
                con.Open();
                da.Fill(tab);
                da.FillSchema(tab,SchemaType.Mapped);
                con.Close();
                return tab;
        }
    }
}
