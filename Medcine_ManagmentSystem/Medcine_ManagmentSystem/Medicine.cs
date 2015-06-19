using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Medcine_ManagmentSystem
{
    class Medicine
    {
        public static bool Insert(string MedicineName, string Salt, int Strength, int CompanyID, string type)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Medicine (MedicineName,Salt,Strength,CompanyID,type) VALUES(@MedicineName,@Salt,@Strength,@CompanyID,@type)";
            cmd.Parameters.AddWithValue ("@MedicineName", MedicineName);
            cmd.Parameters.AddWithValue ("@Salt",Salt);
            cmd.Parameters.AddWithValue ("@Strength",Strength);
            cmd.Parameters.AddWithValue("@CompanyID", CompanyID);
            cmd.Parameters.AddWithValue  ("@type",type);
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
        public static bool Update(string MedicineName, string Salt, int Strength, int CompanyID, string type)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE  Medicine set MedicineName = @MedicineName, Salt =@Salt, Strength= @Strength,CompanyID= @CompanyID,type=@type WHERE MedicineName = @MedicineName";
            cmd.Parameters.AddWithValue ("@MedicineName", MedicineName);
            cmd.Parameters.AddWithValue ("@Salt",Salt);
            cmd.Parameters.AddWithValue ("@Strength",Strength);
            cmd.Parameters.AddWithValue ("@CompanyID",CompanyID);
            cmd.Parameters.AddWithValue  ("@type",type);
            con.Open();
            if(cmd.ExecuteNonQuery()==1)
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
        public static bool Delete(string MedicineName, string Salt, int Strength, int CompanyID, string type)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE Medicine where MedicineName =@MedicineName";
            cmd.Parameters.AddWithValue("@MedicineName", MedicineName);
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
        public static DataTable getTable() 
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Medicine";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tab = new DataTable();
            con.Open();
            da.Fill(tab);
            da.FillSchema(tab, SchemaType.Mapped);
            con.Close();
            return tab;

        }
        public static DataTable getTable(string MedicineName)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Medicine where MedicineName =" + MedicineName;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tab = new DataTable();
            con.Open();
            da.Fill(tab);
            da.FillSchema(tab, SchemaType.Mapped);
            con.Close();
            return tab;

        }

    }
}
