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
        static string connString = "Data Source=.;Initial Catalog=KAB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection sqlConnection = new SqlConnection(connString);

        /// <summary>
        /// Create customer
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        public static void AddCustomer(string firstname, string lastname, string username, string password, string email)
        {

            try
            {
                // öppna strömmen
                sqlConnection.Open();

                // skapa sql-kommando
                SqlCommand mySQLCommand = new SqlCommand("AddCustomer", sqlConnection);

                // säg att det är en stored procedure
                mySQLCommand.CommandType = CommandType.StoredProcedure;

                // skapa parametrar
                SqlParameter paramFirstname = new SqlParameter("@firstname", SqlDbType.VarChar);
                paramFirstname.Value = firstname;

                SqlParameter paramLastname = new SqlParameter("@lastname", SqlDbType.VarChar);
                paramLastname.Value = lastname;

                SqlParameter paramUsername = new SqlParameter("@username", SqlDbType.VarChar);
                paramUsername.Value = username;

                SqlParameter paramPassword = new SqlParameter("@password", SqlDbType.VarChar);
                paramPassword.Value = password;

                SqlParameter paramEmail = new SqlParameter("@email", SqlDbType.VarChar);
                paramEmail.Value = email;

                SqlParameter paramCID = new SqlParameter("@cid", SqlDbType.Int);
                paramCID.Direction = ParameterDirection.Output;

                // lägg till parametrar
                mySQLCommand.Parameters.Add(paramFirstname);
                mySQLCommand.Parameters.Add(paramLastname);
                mySQLCommand.Parameters.Add(paramUsername);
                mySQLCommand.Parameters.Add(paramPassword);
                mySQLCommand.Parameters.Add(paramEmail);
                mySQLCommand.Parameters.Add(paramCID);



                mySQLCommand.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlConnection.Close();
            }


        }

        /// <summary>
        /// Add product
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public static void AddProduct(string name, string price)
        {
            try
            {
                sqlConnection.Open();

                // skapa sql-kommando
                SqlCommand mySQLCommand = new SqlCommand("CreateProducts", sqlConnection);

                // säg att det är en stored procedure
                mySQLCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter paramName = new SqlParameter("@name", SqlDbType.VarChar);
                paramName.Value = name;

                SqlParameter paramPrice = new SqlParameter("@price", SqlDbType.VarChar);
                paramPrice.Value = price;

                SqlParameter paramPID = new SqlParameter("@pid", SqlDbType.Int);
                paramPID.Direction = ParameterDirection.Output;

                mySQLCommand.Parameters.Add(paramName);
                mySQLCommand.Parameters.Add(paramPrice);
                mySQLCommand.Parameters.Add(paramPID);

                mySQLCommand.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Update customer password
        /// </summary>
        /// <param name="cid"></param>
        /// <param name="password"></param>
        public static void UpdateCustomer(int cid, string password)
        {

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("UpdateCustomer", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure; //vår commandtype är en stored procedure

                SqlParameter paramCID = new SqlParameter("@cid", SqlDbType.Int);
                paramCID.Value = cid;

                SqlParameter paramPass = new SqlParameter("@password", SqlDbType.VarChar);
                paramPass.Value = password;

                sqlCommand.Parameters.Add(paramCID);
                sqlCommand.Parameters.Add(paramPass);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }


        }

        /// <summary>
        /// Add to stock
        /// </summary>
        /// <param name="numberOfProducts"></param>
        /// <param name="pid"></param>
        public static void AddStockEntry(int numberOfProducts, int pid)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("CreateStockEntry", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter paramSID = new SqlParameter("@sid", SqlDbType.Int);
                paramSID.Direction = ParameterDirection.Output;

                SqlParameter paramPID = new SqlParameter("@pid", SqlDbType.Int);
                paramPID.Value = pid;

                SqlParameter paramNOP = new SqlParameter("@numberofproducts", SqlDbType.Int);
                paramNOP.Value = numberOfProducts;

                sqlCommand.Parameters.Add(paramSID);
                sqlCommand.Parameters.Add(paramPID);
                sqlCommand.Parameters.Add(paramNOP);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public static void UpdateProduct(int pid, string name, string price)
        {

            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("UpdateProduct", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter paramPID = new SqlParameter("@pid", SqlDbType.Int);
                paramPID.Value = pid;

                SqlParameter paramName = new SqlParameter("@name", SqlDbType.VarChar);
                paramName.Value = name;

                SqlParameter paramPrice = new SqlParameter("@price", SqlDbType.VarChar);
                paramPrice.Value = price;

                sqlCommand.Parameters.Add(paramPID);
                sqlCommand.Parameters.Add(paramName);
                sqlCommand.Parameters.Add(paramPrice);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Updating stock
        /// </summary>
        /// <param name="sid"></param>
        /// <param name="numberofproducts"></param>
        public static void UpdateStock(int sid, int numberofproducts)
        {

            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("UpdateStock", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter paramSID = new SqlParameter("@sid", SqlDbType.Int);
                paramSID.Value = sid;

                SqlParameter paramNRofProducts = new SqlParameter("@numberofproducts", SqlDbType.Int);
                paramNRofProducts.Value = numberofproducts;

                sqlCommand.Parameters.Add(paramSID);
                sqlCommand.Parameters.Add(paramNRofProducts);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }


        }

        /// <summary>
        /// Delete contact by contact id
        /// </summary>
        /// <param name="pid"></param>
        public static void DeleteProduct(int pid)
        {

            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteProduct", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter paramPID = new SqlParameter("@pid", SqlDbType.Int);
                paramPID.Value = pid;

                sqlCommand.Parameters.Add(paramPID);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }


        }

        /// <summary>
        /// Read all customer 
        /// </summary>
        /// <returns></returns>
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
                    customer.Username = (string)reader["Username"];
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

        /// <summary>
        /// Read all products
        /// </summary>
        /// <returns></returns>
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


        public static List<Stock> ReadStockContent()
        {
            List<Stock> stockContent = new List<Stock>();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "Select * from Stock";
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Stock stockItem = new Stock();
                    stockItem.StockID = (int)reader["ID"];
                    stockItem.ProductID = (int)reader["ProductID"];
                    stockItem.StockQuantity = (int)reader["NumberOfProducts"];

                    stockContent.Add(stockItem);
                }
            }
            catch
            {
                stockContent = null;
            }
            finally
            {
                sqlConnection.Close();
            }
            return stockContent;
        }

        /// <summary>
        /// Delete customer by customerID
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
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

        /// <summary>
        /// What the hell is this?
        /// </summary>
        /// <param name="paramaterName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
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
