using OrderProcessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.Design;

namespace DAL
{
    public class Dborder : Iorder
    {
        String connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CDACAssignment\ASPNET\ASPDOTNET\EcommerseApplication\AmazonOnline\AmazonOnline\eCom.mdf;Integrated Security=True";
        IEnumerable<Order> Iorder.GetAllOrder()
        {
            List<Order> theAllOrder = new List<Order>();
            IDbConnection con = new SqlConnection();
            con.ConnectionString = connectionstring;
            IDbCommand cmd = new SqlCommand();
            string query = "select *from orders";
            cmd.Connection = con;
            cmd.CommandText = query;
            IDataReader reader = null;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int orderid = int.Parse(reader["OrderId"].ToString());
                    DateTime date = DateTime.Parse(reader["OrderDate"].ToString());
                    int customerid = int.Parse(reader["CustomerId"].ToString());
                    float amount = float.Parse(reader["Amount"].ToString());
                    Order theOrder = new Order
                    {
                      OrderID=orderid,
                      OrderDate=date,
                      CusomerId=customerid,
                      Amount=amount
                    };
                    theAllOrder.Add(theOrder);
                }
            }
            catch (SqlException exp)
            {
                string message = exp.Message;
            }
            return theAllOrder;
        }

        IEnumerable<Order> Iorder.GetAllOrderByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        Order Iorder.GetOrderByOrderID(int orderID)
        {
            throw new NotImplementedException();
        }

        bool Iorder.insertOrder(Order theOrder)
        {
            throw new NotImplementedException();
        }
    }
}
