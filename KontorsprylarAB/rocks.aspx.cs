using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLLibraryKAB;

namespace KontorsprylarAB
{
    public partial class rocks : System.Web.UI.Page
    {
        static List<Cart> cartList = new List<Cart>();

        protected void Page_Load(object sender, EventArgs e)
        {

            Session["cartToSend"] = cartList;

        }

        protected void ButtonAddToCart_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {

                string price = RocksQuantity.SelectedValue;

                Cart cartToSend = new Cart();



                switch (price)
                {
                    case "100":
                        Product p = new Product();
                        p.ProductName = "A3 100 - pack";
                        p.ProductPrice = price;
                        cartToSend.productList.Add(p);
                        break;

                    case "200":
                        Product d = new Product();
                        d.ProductName = "A4 100 - pack";
                        d.ProductPrice = price;
                        cartToSend.productList.Add(d);
                        break;

                    case "300":
                        Product f = new Product();
                        f.ProductName = "A5 100 - pack";
                        f.ProductPrice = price;
                        cartToSend.productList.Add(f);
                        break;

                    default:
                        break;
                }


                cartList.Add(cartToSend);

            }
        }
    }
}
    