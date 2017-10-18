using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLLibraryKAB;

namespace TestUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> customer = SQLClass.ReadAllProducts();

            foreach (var c in customer)
            {
                Console.WriteLine(c.ProductName);
            }





        }
    }
}
