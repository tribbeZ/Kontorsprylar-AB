using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLLibraryKAB
{
    public class Cart
    {
        int ID { get; set; }

        public List<Product> productList = new List<Product>();

        /// <summary>
        /// Get total price 
        /// </summary>
        /// <returns></returns>
        public int GetTotal()
        {
            int total = 0;
            foreach (Product p in productList)
            {
                total += int.Parse(p.ProductPrice);
            }

            return total;
        }


    }
}
