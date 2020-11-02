using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Catalog;
namespace DAL
{
    public class DbManagers
    {
        public static IEnumerable<Product> GetAllProduct()
        {
            List<Product> allProducts = new List<Product>();
            IDbConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CDACAssignment\ASPNET\ASPDOTNET\EcommerseApplication\AmazonOnline\AmazonOnline\eCom.mdf;Integrated Security=True";
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
    }
}  

