using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Medcine_ManagmentSystem
{
    class CompanyPayment
    {
        public static bool Insert(int VoucherID, int CompanyID, double Amount, string DateAndTime)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO CompanyPayment (VoucherID, CompanyID,Amount, DateAndTime) VALUES (@VoucherID, @CompanyID, @Amount,@DateAndTime)";
            cmd.Parameters.AddWithValue("@VoucherID", VoucherID);
            cmd.Parameters.AddWithValue("@CompanyID", CompanyID);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            cmd.Parameters.AddWithValue("@DateAndTime", DateAndTime);
            
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
        public static bool Update(int VoucherID, string DateAndTime, int Amount, int CompanyID)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update CompanyPayment SET VoucherID= @VoucherID, DateAndTime= @DateAndTime, Amount=@Amount, CompanyID= @CompanyID WHERE VoucherID=@VoucherID";
            //cmd.CommandText = "Update CompanyPayment SET VoucherID= @VoucherID,  WHERE VoucherID=@VoucherID";
            cmd.Parameters.AddWithValue("@VoucherID", VoucherID);
            cmd.Parameters.AddWithValue("@CompanyID", CompanyID);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            cmd.Parameters.AddWithValue("@DateAndTime", DateAndTime);
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
        public static bool Delete(int VoucherID)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            //cmd.CommandText = "DELETE FROM CompanyPayment (VoucherID, DateAndTime, Amount, CompanyID) VALUES (@VoucherID, @DateAndTime, @Amount,@CompanyID)";
            cmd.CommandText = "DELETE FROM CompanyPayment WHERE VoucherID = @VoucherID";
            cmd.Parameters.AddWithValue("@VoucherID", VoucherID);
           
            con.Open();
            if (cmd.ExecuteNonQuery() > 0 )
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
            cmd.CommandText = "SELECT * FROM CompanyPayment";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tab = new DataTable();
            con.Open();
            da.Fill(tab);
          //  da.FillSchema(tab, SchemaType.Mapped);
            con.Close();
            return tab;

        }

  
    }
}
