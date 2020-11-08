using Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    class CatalogDisconnected : IconnectedServices
    {
        String connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CDACAssignment\ASPNET\ASPDOTNET\EcommerseApplication\AmazonOnline\AmazonOnline\eCom.mdf;Integrated Security=True";

        bool IconnectedServices.deleteProduct(int productID)
        {
            bool status = false;

            IDbConnection con = new SqlConnection();
            con.ConnectionString = connectionstring;
            IDbCommand cmd = new SqlCommand();
            string query = "SELECT * FROM flowers";
            cmd.Connection = con;
            cmd.CommandText = query;

            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd as SqlCommand);
                SqlCommandBuilder cmdbldr = new SqlCommandBuilder();
                da.Fill(ds); 

                DataTable dt = ds.Tables[0];
                DataColumn[] keyColumns = new DataColumn[1];
                keyColumns[0] = ds.Tables[0].Columns["productID"];
                ds.Tables[0].PrimaryKey = keyColumns;
               
                DataRow datarow = dt.Rows.Find(productID);

                datarow.Delete();
                da.Update(ds);

                status = true;
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return status;
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
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd as SqlCommand);
                da.Fill(ds);
            
                DataTable dt = ds.Tables[0];
               
                foreach (DataRow datarow in dt.Rows)
                {

                    int id = int.Parse(datarow["productID"].ToString());
                    string title = datarow["title"].ToString();
                    string description = datarow["description"].ToString();
                    float unitPrice = float.Parse(datarow["price"].ToString());
                    int quantity = int.Parse(datarow["quantity"].ToString());
                    allProducts.Add(new Product()
                    {
                        Id = id,
                        Title = title,
                        Description = description,
                        UnitPrice = unitPrice,
                        Quantity = quantity,

                    });
                }
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }

            return allProducts;
        }

        Product IconnectedServices.GetProductByID(int productID)
        {
            Product theProduct = null;
            IDbConnection con = new SqlConnection();
            con.ConnectionString = connectionstring;
            IDbCommand cmd = new SqlCommand();

            string query = "SELECT * FROM flowers";
            cmd.Connection = con;
            cmd.CommandText = query;
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd as SqlCommand);
                SqlCommandBuilder cmdbldr = new SqlCommandBuilder();
                da.Fill(ds);  

                DataTable dt = ds.Tables[0];
                DataColumn[] keyColumns = new DataColumn[1];
                keyColumns[0] = ds.Tables[0].Columns["productID"];
                ds.Tables[0].PrimaryKey = keyColumns;
               

                DataRow datarow = dt.Rows.Find(productID);

                int id = int.Parse(datarow["productID"].ToString());
                string title = datarow["title"].ToString();
                string description = datarow["description"].ToString();
                float unitPrice = float.Parse(datarow["price"].ToString());
                int quantity = int.Parse(datarow["quantity"].ToString());

                theProduct = new Product()
                {
                    Id = id,
                    Title = title,
                    Description = description,
                    UnitPrice = unitPrice,
                    Quantity = quantity,

                };
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }

            return theProduct;
        }

        bool IconnectedServices.insertProduct(Product theProduct)
        {
            bool status = false;

            IDbConnection con = new SqlConnection();
            con.ConnectionString = connectionstring;

            IDbCommand cmd = new SqlCommand();
            string query = "SELECT * FROM flowers";

            cmd.Connection = con;
            cmd.CommandText = query;

            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd as SqlCommand);
                SqlCommandBuilder cmdbldr = new SqlCommandBuilder();
                da.Fill(ds);  
                DataRow datarow = ds.Tables[0].NewRow();

                datarow["productID"] = theProduct.Id;
                datarow["title"] = theProduct.Title;
                datarow["description"] = theProduct.Description;
                datarow["price"] = theProduct.UnitPrice;
                datarow["quantity"] = theProduct.Quantity;

                ds.Tables[0].Rows.Add(datarow);
                da.Update(ds);

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

            IDbConnection con = new SqlConnection();
            con.ConnectionString = connectionstring;
            IDbCommand cmd = new SqlCommand();
            string query = "SELECT * FROM flowers";
            cmd.Connection = con;
            cmd.CommandText = query;

            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd as SqlCommand);
                SqlCommandBuilder cmdbldr = new SqlCommandBuilder();
                da.Fill(ds); 

                DataTable dt = ds.Tables[0];
                DataColumn[] keyColumns = new DataColumn[1];
                keyColumns[0] = ds.Tables[0].Columns["productID"];
                ds.Tables[0].PrimaryKey = keyColumns;
              
                DataRow datarow = dt.Rows.Find(theProduct.Id);

                datarow["tile"] = theProduct.Title;
                datarow["description"] = theProduct.Description;
                datarow["price"] = theProduct.UnitPrice;
                datarow["quantity"] = theProduct.Quantity;

                da.Update(ds); 

                status = true;
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return status;
        }
    }
}
