using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Medcine_ManagmentSystem
{
    class Customer
    {

        public static bool Insert(int CustomerID, string CustomerName, string CustomerAddress, string CustomerPhoneNo, string CustomerDescription)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Customers (CustomerID,CustomerName,CustomerAddress,CustomerPhoneNo,CustomerDescription)VALUES (@CustomerID,@CustomerName,@CustomerAddress,@CustomerPhoneNo,@CustomerDescription)";
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
            cmd.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
            cmd.Parameters.AddWithValue("@CustomerPhoneNo", CustomerPhoneNo);
            cmd.Parameters.AddWithValue("@CustomerDescription", CustomerDescription);

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
        public static bool Update(int CustomerID, string CustomerName, string CustomerAddress, string CustomerPhoneNummber, string Description)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            //cmd.CommandText = "UPDATE INTO Medicine (CustomerID,CusotmerName,CusotmerAddress,CustomerPhoneNummber)VALUES (@CustomerID,@CusotmerName,@CusotmerAddress,@CustomerPhoneNummber)";
            cmd.CommandText = "UPDATE Customers SET CustomerID,CustomerName=@CustomerName,CustomerAddress=@CustomerAddress,CustomerPhoneNo=@CustomerPhoneNo,CustomerDescription=@CustomerDescription"; 
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
            cmd.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
            cmd.Parameters.AddWithValue("@CustomerPhoneNummber", CustomerPhoneNummber);
            cmd.Parameters.AddWithValue("@Description", Description);

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
        public static bool Delete(int CustomerID)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM Customers WHERE CustomerID =@CustomerID";
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static DataTable getTable()
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Customers";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tab = new DataTable();
            con.Open();
            da.Fill(tab);
            //da.FillSchema(tab, SchemaType.Mapped);
            con.Close();
            return tab;

        }

    }
}
