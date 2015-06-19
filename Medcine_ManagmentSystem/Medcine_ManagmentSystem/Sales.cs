using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Medcine_ManagmentSystem
{
    class Sales
    {
        public static bool Insert(int SaleID, DateTime SaleDateAndTime, int CustomerID)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Sales (SaleID,SaleDateAndTime,CustomerID) VALUES(@SaleID, @SaleDateAndTime, @CustomerID) ";
            cmd.Parameters.AddWithValue("@SaleID", SaleID);
            cmd.Parameters.AddWithValue("@SaleDateAndTime", SaleDateAndTime);
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            con.Open();
            if(cmd.ExecuteNonQuery()== 1)
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
        public static bool Update(int SaleID, DateTime SaleDateAndTime, int CustomerID)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Sales set SaleID = @SaleID, SaleDateAndTime= @SaleDateAndTime,CustomerID=@CustomerID where SaleID=@SaleID ";
            cmd.Parameters.AddWithValue("@SaleID", SaleID);
            cmd.Parameters.AddWithValue("@SaleDateAndTime", SaleDateAndTime);
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            con.Open();
            if(cmd.ExecuteNonQuery()== 1)
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
        public static bool Delete(int SaleID)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM Sales WHERE SaleID = @SaleID ";
            cmd.Parameters.AddWithValue("@SaleID", SaleID);
     
            con.Open();
            if(cmd.ExecuteNonQuery()== 1)
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
            cmd.CommandText = "SELECT * FROM Sales";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tab = new DataTable();
            con.Open();
            da.Fill(tab);
            da.FillSchema(tab, SchemaType.Mapped);
            con.Close();
            return tab;

        }
        public static DataTable getTable(string id)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Sales where SaleID = "+id;
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
