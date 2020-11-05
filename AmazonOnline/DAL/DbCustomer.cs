using CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DbCustomer: Icustomer
    {
        String connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CDACAssignment\ASPNET\ASPDOTNET\EcommerseApplication\AmazonOnline\AmazonOnline\eCom.mdf;Integrated Security=True";

        public bool deleteCustomer(int id)
        {
            bool status = false;
            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionstring;
                IDbCommand cmd = new SqlCommand();
                string query = "Delete from customers where customerID=@Id";
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@Id", id));
                con.Open();
                cmd.ExecuteNonQuery();
                status = true;
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return status;
        }

        public bool insertCustomer(Customer theCustomer)
        {
            bool status = false;
            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionstring;
                IDbCommand cmd = new SqlCommand();
                string query = "Insert Into customers(customerID, firstName,lastName, email,contact,registrationDate,fax,state,zip,Address) VALUES (@customerid, @firstname,@lastname, @email,@contact,@registrationdate,@fax,@state,@zip,@Address)";
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@customerid", theCustomer.Id));
                cmd.Parameters.Add(new SqlParameter("@firstname", theCustomer.Firstname));
                cmd.Parameters.Add(new SqlParameter("@lastname", theCustomer.Lastname));
                cmd.Parameters.Add(new SqlParameter("@email", theCustomer.Email));
                cmd.Parameters.Add(new SqlParameter("@contact", theCustomer.ContactNumber));
                cmd.Parameters.Add(new SqlParameter("@fax", theCustomer.Fax));
                cmd.Parameters.Add(new SqlParameter("@registrationdate", theCustomer.Registrationdate));
                cmd.Parameters.Add(new SqlParameter("@Address", theCustomer.Address));
                cmd.Parameters.Add(new SqlParameter("@zip", theCustomer.Zip));
                cmd.Parameters.Add(new SqlParameter("@state", theCustomer.State));
                con.Open();
                cmd.ExecuteNonQuery();
                status = true;
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return status;
        }

        public bool updateCustomer(Customer theCustomer)
        {
            bool status = false;
            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionstring;
                IDbCommand cmd = new SqlCommand();
                string query = "Update customers customerID=@customerid, firstName= @firstname,lastName=@lastname,email=@email,contact=@contact,registrationDate=@registrationdate,fax=@fax,state=@state,zip=@zip,Address=@Address";
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@customerid", theCustomer.Id));
                cmd.Parameters.Add(new SqlParameter("@firstname", theCustomer.Firstname));
                cmd.Parameters.Add(new SqlParameter("@lastname", theCustomer.Lastname));
                cmd.Parameters.Add(new SqlParameter("@email", theCustomer.Email));
                cmd.Parameters.Add(new SqlParameter("@contact", theCustomer.ContactNumber));
                cmd.Parameters.Add(new SqlParameter("@fax", theCustomer.Fax));
                cmd.Parameters.Add(new SqlParameter("@registrationdate", theCustomer.Registrationdate));
                cmd.Parameters.Add(new SqlParameter("@Address", theCustomer.Address));
                cmd.Parameters.Add(new SqlParameter("@zip", theCustomer.Zip));
                cmd.Parameters.Add(new SqlParameter("@state", theCustomer.State));
                con.Open();
                cmd.ExecuteNonQuery();
                status = true;
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return status;
        }
    }
}
