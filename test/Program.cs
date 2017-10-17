using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLLibraryKAB;
using KontorsprylarAB;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //List<Product> product = SQLClass.ReadAllProducts();

            //foreach (var c in product)
            //{
            //    Console.WriteLine(c.ProductPrice);
            //}

            SQLClass.DeleteCustomer(1);
        }
    }
}
