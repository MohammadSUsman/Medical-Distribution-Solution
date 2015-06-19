using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Medcine_ManagmentSystem
{
    class Purches
    {
        public static bool Insert(int PurchesID, DateTime DateAndTime, int CompanyID) 
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Purches (PurchesID,DateAndTime,CompanyID) VALUES (@PurchesID,@DateAndTime,@CompanyID)";
            cmd.Parameters.AddWithValue("@PurchesID", PurchesID);
            cmd.Parameters.AddWithValue("@DateAndTime", DateAndTime);
            cmd.Parameters.AddWithValue("@CompanyID", CompanyID);
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
        public static bool Update(int PurchesID, DateTime PurchesDateandTime, int CompanyID)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Purches set PurchesID=@PurchesID ,PurchesDateandTime=@PurchesDateandTime ,CompanyID =@CompanyID";
            cmd.Parameters.AddWithValue("@PurchesID", PurchesID);
            cmd.Parameters.AddWithValue("@PurchesDateandTime", PurchesDateandTime);
            cmd.Parameters.AddWithValue("@CompanyID", CompanyID);
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
        public static bool Delete(int PurchesID, DateTime PurchesDateandTime, int CompanyID)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM Purches where PurchesID =@PurchesID";
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
            //cmd.CommandText = "SELECT  Purches.PurchesID, PurchesDetails.Quantity, Purches.DateAndTime,PurchesDetails.Price  FROM Purches  INNER JOIN PurchesDetails ON Purches.PurchesID = PurchesDetails.PurchesID ";
            cmd.CommandText = "SELECT  * from Purches";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tab = new DataTable();
            con.Open();
            da.Fill(tab);
           // da.FillSchema(tab, SchemaType.Mapped);
            con.Close();
            return tab;

        }
        public static Boolean FrindRow(string pid)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT  * from Purches where PurchesID = "+pid;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tab = new DataTable();
            con.Open();
            da.Fill(tab);
            // da.FillSchema(tab, SchemaType.Mapped);
            con.Close();
            if (tab.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
