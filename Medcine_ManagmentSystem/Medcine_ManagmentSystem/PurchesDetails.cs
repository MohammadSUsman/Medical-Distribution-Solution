using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Medcine_ManagmentSystem
{
    class PurchesDetails
    {
        public static bool Insert(int PurchesID, string MedicineName, int Quantity, int Discount, int Price)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO PurchesDetails(PurchesID, MedicineName, Quantity, Discount, Price)VALUES (@PurchesID, @MedicineName, @Quantity,@Discount, @Price)";
            cmd.Parameters.AddWithValue("@PurchesID", PurchesID);
            cmd.Parameters.AddWithValue("@MedicineName", MedicineName);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Discount", Discount);
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
        public static bool Update(int PurchesID, string MedicineName, int Quantity, int Discount, int Price)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE PurchesDetails set MedicineName =@MedicineName,Quantity=@Quantity,Discount=@Discount,Price=@Price where PurchesID = @PurchesID and MedicineName = @MedicineName";
            cmd.Parameters.AddWithValue("@PurchesID", PurchesID);
            cmd.Parameters.AddWithValue("@MedicineName", MedicineName);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Discount", Discount);
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
        public static bool Delete(int PurchesID,string MedicineName)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM PurchesDetails where PurchesID = @PurchesID and MedicineName =@MedicineName";
            cmd.Parameters.AddWithValue("@PurchesID", PurchesID);
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
        public static DataTable getTableWithId(string id)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT  * FROM PurchesDetails where PurchesID="+id;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tab = new DataTable();
            con.Open();
            da.Fill(tab);
            da.FillSchema(tab, SchemaType.Mapped);
            con.Close();
            return tab;

        }
        public static DataTable getTable()
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT  * FROM PurchesDetails";
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
