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


            if (Session["cartToSend"] != null)
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

                // fånga upp värden och släng in en order i en click-funktion
            }





        }

        protected void buttonCheckout_Click(object sender, EventArgs e)
        {
            string username = (string)Session["Username"];

            if (username != null)
            {
                List<Cart> cartList = (List<Cart>)Session["cartToSend"];

                if (cartList.Count() > 0)
                {
                    string dt = DateTime.Now.ToString();
                    int nop = cartList.Count();
                    int total = 0;
                    string cid = (string)Session["CID"];
                    int customerID = int.Parse(cid);

                    foreach (Cart c in cartList)
                    {
                        total += c.GetTotal();
                    }

                    SQLClass.AddOrder(dt, nop, total.ToString(), customerID);
                }
            }
            else
            {
                Response.Redirect("/login.aspx");
            }
        }

        protected void ButtonContinue_Click(object sender, EventArgs e)
        {
            
           Response.Redirect("/index.aspx");
        }
        //todo - what to do else..?
    }
}
