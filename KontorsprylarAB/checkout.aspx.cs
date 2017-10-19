using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLLibraryKAB;

namespace KontorsprylarAB
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        //checkout, här ska vi visa totalpris och lista över valda produkter. 
        //totalpriset från metoden GetTotal();
        //listan över valda produkter från produktsidan.

        protected void Page_Load(object sender, EventArgs e)
        {

            List<Cart> cartList = (List<Cart>)Session["cartToSend"];




            string cartTableContent = "";

            foreach (Cart c in cartList)
            {
                

                if (c != null)
                {
                    

                    foreach (Product p in c.productList)
                    {
                        cartTableContent += $"<tr><td>{p.ProductID}</td><td>{p.ProductName}</td><td>{p.ProductPrice}</td></tr>";
                    }

                    

                }
                
            }

            CheckoutSumUp.Text = cartTableContent;

            //string priceSum = cart.GetTotal();

            //if (cart != null)
            //{
            //    string cartTableContent = "";

            //    foreach (var item in cart.productList)
            //    {
            //        cartTableContent += $"<tr><td>{item.ProductID}</td><td>{item.ProductName}</td><td>{item.ProductPrice}</td></tr>";
            //        //$ lägger på ToString() på variabler som skrivs mellan måsvingar. 
            //    }

            //    CheckoutSumUp.Text = cartTableContent;
            //    PriceSum.Text = priceSum;
        }
        //todo - what to do else..?
    }
}
