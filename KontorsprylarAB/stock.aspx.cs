using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLLibraryKAB;
using Newtonsoft.Json;

namespace KontorsprylarAB
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            List<Stock> stock = SQLClass.ReadStockContent();

            if (stock != null)
            {
                string stockTableContent = "";

                foreach (var item in stock)
                {
                    stockTableContent += $"<tr><td>{item.StockID}</td><td>{item.ProductID}</td><td>{item.StockQuantity}</td></tr>";
                    //$ lägger på ToString() på variabler som skrivs mellan måsvingar. 
                }

                Stock.Text = stockTableContent;
            }
            //todo - what to do else..?
        }

        protected void ButtonUpdateStock_Click(object sender, EventArgs e)
        {
            int sid = int.Parse(TextBoxStockID.Text);

            List<Stock> stock = SQLClass.ReadStockContent();
            var querry = from s in stock
                         where s.StockID == sid
                         select s.StockQuantity;

            int cid = querry.First();


            int quantity = int.Parse(TextBoxQuantity.Text);

            SQLClass.UpdateStock(sid, cid + quantity);
        }
    }
}