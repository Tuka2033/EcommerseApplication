﻿using CRM;
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

        IEnumerable<Customer> Icustomer.GetAllCustomer()

        {
            List<Customer> allCustomer = new List<Customer>();
            IDbConnection con = new SqlConnection();
            con.ConnectionString = connectionstring;
            IDbCommand cmd = new SqlCommand();
            string query = "SELECT * FROM customers";
            cmd.Connection = con;
            cmd.CommandText = query;
            IDataReader reader = null;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["customerID"].ToString());
                    string firstName = reader["firstName"].ToString();
                    string lastName = reader["lastName"].ToString();
                    string email = reader["email"].ToString();
                    string contactNumber = reader["contact"].ToString();
                    string fax = reader["fax"].ToString();
                    DateTime date = DateTime.Parse(reader["registrationDate"].ToString());
                    string zip = reader["zip"].ToString();
                    string state = reader["state"].ToString();
                    string address = reader["Address"].ToString();
                    Customer theCustomer = new Customer
                    {
                    Id = id,
                    Firstname = firstName,
                    Lastname = lastName,
                    Email = email,
                    ContactNumber = contactNumber,
                    Fax = fax,
                    Registrationdate = date,
                    Address = address,
                    Zip = zip,
                    State = state,
                    };
                    allCustomer.Add(theCustomer);
                }
                reader.Close();
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return allCustomer;
        }

        Customer Icustomer.GetCustomerByID(int customerID)
        {

           Customer theCustomer = null;
            try
            {
                using (IDbConnection con = new SqlConnection())
                {
                    con.ConnectionString = connectionstring;
                    IDbCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    string query = "SELECT * FROM customers WHERE  customerID=@Id";
                    cmd.CommandText = query;
                    cmd.Parameters.Add(new SqlParameter("@Id", customerID));
                    con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["customerID"].ToString());
                        string firstName = reader["firstName"].ToString();
                        string lastName = reader["lastName"].ToString();
                        string email = reader["email"].ToString();
                       string contactNumber = reader["contact"].ToString();
                        string fax = reader["fax"].ToString();
                        DateTime date = DateTime.Parse(reader["registrationDate"].ToString());
                        string zip = reader["zip"].ToString();
                        string state = reader["state"].ToString();
                        string address = reader["Address"].ToString();
                        theCustomer = new Customer
                        {
                            Id = id,
                            Firstname = firstName,
                            Lastname = lastName,
                            Email = email,
                            ContactNumber = contactNumber,
                            Fax = fax,
                            Registrationdate = date,
                            Address = address,
                            Zip = zip,
                            State = state,
                        };
                    }
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return theCustomer;

        }
      
        bool Icustomer.deleteCustomer(int id)
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

        bool Icustomer.insertCustomer(Customer theCustomer)
        {
            bool status = false;
            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionstring;
                IDbCommand cmd = new SqlCommand();
                string query = "Insert Into customers(customerID, firstName,lastName, email,contact,registrationDate,fax,state,zip,Address,userName,password) VALUES (@customerid, @firstname,@lastname, @email,@contact,@registrationdate,@fax,@state,@zip,@Address,@username,@password)";
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
                cmd.Parameters.Add(new SqlParameter("@username", theCustomer.UserName));
                cmd.Parameters.Add(new SqlParameter("@password", theCustomer.Password));
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

       bool Icustomer.updateCustomer(Customer theCustomer)
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

        bool Icustomer.Validate(string username,string password)
        {
            bool status = false;
            try
            {
                using (IDbConnection con = new SqlConnection())
                {
                    con.ConnectionString = connectionstring;
                    IDbCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    string query = "SELECT * FROM customers WHERE  userName=@username";
                    cmd.CommandText = query;
                    cmd.Parameters.Add(new SqlParameter("@username", username));
                    con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string uid = reader["userName"].ToString();
                        string pwd = reader["password"].ToString();
                    
                    if ((username == uid) &&(password == pwd))
                    {
                        status = true;
                    }
                    }
                    if (con.State == ConnectionState.Open)
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
