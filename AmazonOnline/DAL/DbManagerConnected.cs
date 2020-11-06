using System;
using System.Collections.Generic;
using Catalog;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DbManagerConnected : IconnectedServices
    {
        String connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CDACAssignment\ASPNET\ASPDOTNET\EcommerseApplication\AmazonOnline\AmazonOnline\eCom.mdf;Integrated Security=True";

        Product IconnectedServices.GetProductByID(int productID)
        {

            Product theProduct = null;
            try
            {
                using (IDbConnection con = new SqlConnection())
                {
                    con.ConnectionString = connectionstring;
                    IDbCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    string query = "SELECT * FROM flowers WHERE  productID=@Id";
                    cmd.CommandText = query;
                    cmd.Parameters.Add(new SqlParameter("@Id", productID));
                    con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int id = int.Parse(reader["ProductID"].ToString());
                        string title = reader["title"].ToString();
                        string description = reader["description"].ToString();
                        int unitPrice = int.Parse(reader["price"].ToString());
                        int quantity = int.Parse(reader["quantity"].ToString());
                        string imagUrl = reader["picture"].ToString();
                        theProduct = new Product
                        {
                            Id= id,
                            Title = title,
                            Description = description,
                            UnitPrice = unitPrice,
                            Quantity = quantity,
                            ImageUrl=imagUrl
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
            return theProduct;

        }
      
        IEnumerable<Product> IconnectedServices.GetAllProduct()

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
                    string imagUrl = reader["picture"].ToString();

                    Product theProduct = new Product
                    {
                        Id = id,
                        Title = title,
                        Description = description,
                        UnitPrice = unitPrice,
                        Quantity = quantity,
                        ImageUrl = imagUrl
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
       
        bool IconnectedServices.insertProduct(Product theProduct)
        {
            bool status = false;
            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionstring;
                IDbCommand cmd = new SqlCommand();
                string query = "Insert Into flowers(productID, title, description, price, quantity,picture) VALUES (@Id, @Title, @Description, @Price, @Quantity,@ImagUrl)";
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@Id", theProduct.Id));
                cmd.Parameters.Add(new SqlParameter("@Title", theProduct.Title));
                cmd.Parameters.Add(new SqlParameter("@Description", theProduct.Description));
                cmd.Parameters.Add(new SqlParameter("@Price", theProduct.UnitPrice));
                cmd.Parameters.Add(new SqlParameter("@Quantity", theProduct.Quantity));
                cmd.Parameters.Add(new SqlParameter("@ImagUrl", theProduct.ImageUrl));
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

        bool IconnectedServices.updateProduct(Product theProduct)
        {
            bool status = false;
            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionstring;
                IDbCommand cmd = new SqlCommand();
                cmd.Connection = con;
                String query = "UPDATE flowers SET title=@Title, description=@Description, price=@Price, quantity=@Quantity,picture=@ImagUrl WHERE  productID=@Id";
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@Id", theProduct.Id));
                cmd.Parameters.Add(new SqlParameter("@Title", theProduct.Title));
                cmd.Parameters.Add(new SqlParameter("@Description", theProduct.Description));
                cmd.Parameters.Add(new SqlParameter("@Price", (int)theProduct.UnitPrice));
                cmd.Parameters.Add(new SqlParameter("@Quantity", theProduct.Quantity));
                cmd.Parameters.Add(new SqlParameter("@ImagUrl", theProduct.ImageUrl));
                con.Open();
                cmd.ExecuteNonQuery();
                status = true;
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return status;
        }

        bool IconnectedServices.deleteProduct(int ProductId)
        {
            bool status = false;
            try
            {
                IDbConnection con = new SqlConnection();
                con.ConnectionString = connectionstring;
                IDbCommand cmd = new SqlCommand();
                string query = "Delete from flowers where ProductId=@Id";
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@Id", ProductId));
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
