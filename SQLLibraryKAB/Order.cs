using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLLibraryKAB
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string OrderDate { get; set; }
        public int OrderSum { get; set; }
        public int OrderQuantity { get; set; }
        public int ProductID { get; set; }
    }
}
