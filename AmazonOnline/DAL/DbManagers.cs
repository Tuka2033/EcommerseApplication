using Catalog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DbManagers
    {
       static String connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CDACAssignment\ASPNET\ASPDOTNET\EcommerseApplication\AmazonOnline\AmazonOnline\eCom.mdf;Integrated Security=True";
        public static IEnumerable<Product> GetAllProduct()
        
        {
            List<Product> allProducts = new List<Product>();
            IDbConnection con = new SqlConnection();
            con.ConnectionString = connectionstring;
            IDbCommand cmd = new SqlCommand();
            string query = "SELECT * FROM flowers";
            cmd.Connection = con;
            cmd.CommandText = query;
            IDataReader reader = null;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["ProductID"].ToString());
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    int unitPrice = int.Parse(reader["price"].ToString());
                    int quantity = int.Parse(reader["quantity"].ToString());

                    Product theProduct = new Product
                    {
                        Id = id,
                        Title = title,
                        Description = description,
                        UnitPrice = unitPrice,
                        Quantity = quantity
                    };
                    allProducts.Add(theProduct);
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
            return allProducts;
        }


        public static bool Insert(Product theProduct)
        {
            bool status = false;
            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionstring;
                IDbCommand cmd = new SqlCommand();
                string query = "Insert Into flowers(productID, title, description, price, quantity) VALUES (@Id, @Title, @Description, @Price, @Quantity)";
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@Id", theProduct.Id));
                cmd.Parameters.Add(new SqlParameter("@Title", theProduct.Title));
                cmd.Parameters.Add(new SqlParameter("@Description", theProduct.Description));
                cmd.Parameters.Add(new SqlParameter("@Price", theProduct.UnitPrice));
                cmd.Parameters.Add(new SqlParameter("@Quantity", theProduct.Quantity));
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
    
        public static bool update(Product theProduct)
        {
            bool status = false;
            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionstring;
                IDbCommand cmd = new SqlCommand();
                cmd.Connection = con;
                String query="Update "

            }
            catch (SqlException exp)
            {

            }
            return status;
        }
    }

}

