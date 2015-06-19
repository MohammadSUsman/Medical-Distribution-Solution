using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Medcine_ManagmentSystem
{
    class CustomerRecpit
    {
        public static bool Insert(int VoucherID, String DateAndTime, double Amount, int CompanyID)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            //cmd.CommandText = "INSET INTO Medicine (VoucherID, DateAndTime, Amount, CompanyID) VALUES (@VoucherID, @DateAndTime, @Amount,@CompanyID)";
            cmd.CommandText = "INSERT INTO CustomerRecipit (VoucherID,DateAndTime,Amount, CompanyId ) VALUES (@VoucherID, @CompanyID, @Amount,@DateAndTime)";
            cmd.Parameters.AddWithValue("@VoucherID", VoucherID);
            cmd.Parameters.AddWithValue("@DateAndTime", DateAndTime);
            cmd.Parameters.AddWithValue("@Amount", Amount);
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
        public static bool Update(int VoucherID, string DateAndTime, double Amount, int CompanyID)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            //cmd.CommandText = "Update INTO Medicine (VoucherID, DateAndTime, Amount, CompanyID) VALUES (@VoucherID, @DateAndTime, @Amount,@CompanyID)";
            cmd.CommandText = "Update CustomerRecipit SET VoucherID= @VoucherID, DateAndTime= @DateAndTime, Amount=@Amount, CompanyID= @CompanyID WHERE VoucherID=@VoucherID";
            cmd.Parameters.AddWithValue("@VoucherID", VoucherID);
            cmd.Parameters.AddWithValue("@DateAndTime", DateAndTime);
            cmd.Parameters.AddWithValue("@Amount", Amount);
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
        public static bool Delete(int VoucherID)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            //cmd.CommandText = "DELETE FROM Medicine (VoucherID, DateAndTime, Amount, CompanyID) VALUES (@VoucherID, @DateAndTime, @Amount,@CompanyID)";
            cmd.CommandText = "DELETE FROM CustomerRecipit WHERE VoucherID = @VoucherID";
            cmd.Parameters.AddWithValue("@VoucherID", VoucherID);
            //cmd.Parameters.AddWithValue("@DateAndTime", DateAndTime);
            //cmd.Parameters.AddWithValue("@Amount", Amount);
            //cmd.Parameters.AddWithValue("@CompanyID", CompanyID);
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
            cmd.CommandText = "SELECT * FROM CustomerRecipit";
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
