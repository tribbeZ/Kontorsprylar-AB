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

            Cart cart = new Cart();

            

            string priceSum = cart.GetTotal();

            if (cart != null)
            {
                string cartTableContent = "";

                foreach (var item in cart.productList)
                {
                    cartTableContent += $"<tr><td>{item.ProductID}</td><td>{item.ProductName}</td><td>{item.ProductPrice}</td></tr>";
                    //$ lägger på ToString() på variabler som skrivs mellan måsvingar. 
                }

                CheckoutSumUp.Text = cartTableContent;
                PriceSum.Text = priceSum;
            }
            //todo - what to do else..?
        }
    }
}