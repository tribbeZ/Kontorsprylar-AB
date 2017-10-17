using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQLLibraryKAB
{
    public static class SQLClass
    {
        static string connString = @"Data Source=ACADEMY-72511C2;Initial Catalog=KAB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection sqlConnection = new SqlConnection(connString);

        public static List<Customer> ReadAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "Select * from Customer";
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerID = (int)reader["ID"];
                    customer.Firstname = (string)reader["Firstname"];
                    customer.Lastname = (string)reader["Lastname"];
                    customer.Email = (string)reader["Email"];
                    customer.Usename = (string)reader["Username"];
                    customer.Password = (string)reader["Password"];

                    customers.Add(customer);
                }
            }
            catch
            {
                customers = null;
            }
            finally
            {
                sqlConnection.Close();
            }
            return customers;
        }

        public static List<Product> ReadAllProducts()
        {
            List<Product> products = new List<Product>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "Select * from Product";
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductID = (int)reader["ID"];
                    product.ProductName = (string)reader["Name"];
                    product.ProductPrice = (string)reader["Price"];

                    products.Add(product);
                }
            }
            catch
            {
                products = null;
            }
            finally
            {
                sqlConnection.Close();
            }
            return products;
        }

        public static bool DeleteCustomer(int cid)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "DeleteCustomer";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Connection = sqlConnection;

            SqlParameter idParam = CreateIntParameter("@cid", cid);
            sqlCommand.Parameters.Add(idParam);
            int rowsAffected;

            try
            {
                sqlConnection.Open();
                rowsAffected = sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                rowsAffected = -1;
            }
            finally
            {
                sqlConnection.Close();
            }
            return rowsAffected > 0;
        }

        private static SqlParameter CreateIntParameter(string paramaterName, int value)
        {
            SqlParameter param = new SqlParameter();
            param.Direction = ParameterDirection.Input;
            param.ParameterName = paramaterName;
            param.SqlDbType = SqlDbType.Int;
            param.Value = value;

            return param;
        }
    }
}
