using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLLibraryKAB;

namespace KontorsprylarAB
{
    public partial class scissors : System.Web.UI.Page
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

                string price = ScissorQuantity.SelectedValue;

                Cart cartToSend = new Cart();



                switch (price)
                {
                    case "100":
                        Product p = new Product();
                        p.ProductName = "Scissors 100 - pack";
                        p.ProductPrice = price;
                        cartToSend.productList.Add(p);
                        break;

                    case "200":
                        Product d = new Product();
                        d.ProductName = "Scissors 200 - pack";
                        d.ProductPrice = price;
                        cartToSend.productList.Add(d);
                        break;

                    case "300":
                        Product f = new Product();
                        f.ProductName = "Scissors 300 - pack";
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