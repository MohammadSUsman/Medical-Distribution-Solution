using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Medcine_ManagmentSystem
{
    class Company
    {
        public static bool Insert(int CompanyID, string CompanyName, string CompanyAddress, string phone)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO  Company(CompanyID,CompanyName,CompanyAddress)VALUES(@CompanyID,@CompanyName,@CompanyAddress)";
            cmd.Parameters.AddWithValue("@CompanyID", CompanyID);
            cmd.Parameters.AddWithValue("@CompanyName", CompanyName);
            cmd.Parameters.AddWithValue("@CompanyAddress", CompanyAddress);
            //cmd.Parameters.AddWithValue("@phone", phone);

            con.Open();
                if(cmd.ExecuteNonQuery() == 1)
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
        public static bool Update(int CompanyID, string CompanyName, string CompanyAddress, string phone)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
           // cmd.CommandText = "UPDATE  Company SET CompanyID=@CompanyID , SET  CompanyName, SET  CompanyAddress, SET phone)VALUES(,@CompanyName,@CompanyAddress,@phone)";
            cmd.CommandText = "UPDATE Company SET CompanyID=@CompanyID,CompanyName=@CompanyName,CompanyAddress=@CompanyAddress WHERE CompanyID=@CompanyID ";
            cmd.Parameters.AddWithValue("@CompanyID", CompanyID);
            cmd.Parameters.AddWithValue("@CompanyName", CompanyName);
            cmd.Parameters.AddWithValue("@CompanyAddress", CompanyAddress);
            cmd.Parameters.AddWithValue("@phone", phone);

            con.Open();
            if (cmd.ExecuteNonQuery() >0)
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
        public static bool Delete(int CompanyID, string ComapnayName, string CompanyAddress, string phone)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
           // cmd.CommandText = "DELETE FROM Company WHERE ((CompanyID,CompanyName,CompanyAddress,Form)VALUES(@CompanyID,@CompanyName,@CompanyAddress,@Form)";
            cmd.CommandText = "DELETE FROM Company WHERE CompanyID = @CompanyID";
            cmd.Parameters.AddWithValue("@CompanyID", CompanyID);
            cmd.Parameters.AddWithValue("@CompanyName", ComapnayName);
            cmd.Parameters.AddWithValue("@CompanyAddress", CompanyAddress);
            cmd.Parameters.AddWithValue("@Form", phone);

            con.Open();
            if (cmd.ExecuteNonQuery() >0 )
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
        public static DataTable getTable()
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Company";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tab = new DataTable();
            con.Open();
            da.Fill(tab);
//            da.FillSchema(tab, SchemaType.Mapped);
            con.Close();
            return tab;

        }

    }
}
