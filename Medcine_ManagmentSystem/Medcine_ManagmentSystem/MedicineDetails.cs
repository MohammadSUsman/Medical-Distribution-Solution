using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Medcine_ManagmentSystem
{
    class MedicineDetails
    {
        public static bool Insert(string MedicineName, int BatchNo, DateTime ManufacturingDate, DateTime ExpiryDate, decimal Price)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Medicine (MedicineName,BatchNo,ManufacturingDate,ExpiryDate,Price)VALUES(@Medicine,@BatchNo,@ManufacturingDate,@ExpiryDate,@Price)";
            cmd.Parameters.AddWithValue ("@Medicine",MedicineName);
            cmd.Parameters.AddWithValue("@BatchNo",BatchNo);
            cmd.Parameters.AddWithValue("@ManufacturingDate",ManufacturingDate);
            cmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
            cmd.Parameters.AddWithValue("@Price",Price);
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
        public static bool Update(String MedicineName, int BatchNo, DateTime ManufacturingDate, DateTime ExpiryDate, decimal Price)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Medicine SET (MedicineName =@MedicineName, BacthNo =@BacthNo, ManufacturingDate =@ManufacturingDate, ExpiryDate =@ExpiryDate, Price =@Price WHERE MedicineName =@MedicineName";
            cmd.Parameters.AddWithValue("@MedicineName", MedicineName);
            cmd.Parameters.AddWithValue("@BatchNo",BatchNo);
            cmd.Parameters.AddWithValue("@ManufacturingDate", ManufacturingDate);
            cmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
            cmd.Parameters.AddWithValue("@Price",Price);
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
        public static bool Delete(String MedicineName, int BatchNo, DateTime ManufacturingDate, DateTime ExpiryDate, decimal Price)
        {
            SqlConnection con = new SqlConnection(Connection.connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete FROM Medicine(MedicineName, BacthNo, ManufacturingDate, ExpiryDate, Price) VALUES(@MedicineName, @BacthNo, @ManufacturingDate, @ExpiryDate, @Price)";
            cmd.Parameters.AddWithValue("@MedicineName",MedicineName);
            cmd.Parameters.AddWithValue("@BatchNo", BatchNo);
            cmd.Parameters.AddWithValue("@ManufacturingDate",ManufacturingDate);
            cmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
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
            //da.FillSchema(tab, SchemaType.Mapped);
            con.Close();
            return tab;

        }

    }
}
