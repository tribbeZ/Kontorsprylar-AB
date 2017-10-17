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
        static string connString = ""
        static SqlConnection sqlConnection = new SqlConnection(connString);

        AddCustomer();
        AddOrder();
        ReadAllProducts();
        ReadAllOrders();
        ReadStock();
        ReadAllCustomers();

    


    }
}
