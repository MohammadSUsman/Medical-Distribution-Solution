using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Medcine_ManagmentSystem
{
    class SalesDetail
    {
        public static bool Insert(int SalesID, string ProductName, int Discount,int Quantity,int Price)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO SalesDetails (SaleID,ProductName,Discount,Quantity,Price) VALUES(@SaleID,@ProductName,@Discount,@Quantity,@Price)";
            cmd.Parameters.AddWithValue("@SaleID", SalesID);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.Parameters.AddWithValue("@Discount", Discount);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Price", Price);
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
        public static bool Update(int SaleID, string ProductName,int Discount, int Quantity, int Price)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE SalesDetails SET  ProductName= @ProductName,Discount =@Discount, Quantity =@Quantity, Price =@Price WHERE SaleID =@SaleID";
            cmd.Parameters.AddWithValue("@SaleID", SaleID);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.Parameters.AddWithValue("@Discount", Discount);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Price", Price);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
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
        public static bool Delete(int SalesID)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd =  new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM SalesDetails WHERE SaleID =@SalesID";
            cmd.Parameters.AddWithValue("@SalesID", SalesID);
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
            cmd.CommandText = "SELECT * FROM SalesDetails";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tab = new DataTable();
            con.Open();
            da.Fill(tab);
            da.FillSchema(tab, SchemaType.Mapped);
            con.Close();
            return tab;

        }
        public static DataTable getTable(string Id)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM SalesDetails where SaleID = "+Id;
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
