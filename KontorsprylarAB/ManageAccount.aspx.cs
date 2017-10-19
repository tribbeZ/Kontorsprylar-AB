using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLLibraryKAB;

namespace KontorsprylarAB
{
    public partial class ManageAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {

            }
            else
            {
                LoadUser();
                LoadLastOrder();
            }
        }

        private void LoadLastOrder()
        {
            string CustomerID = (string)Session["CID"];
            SQLClass.GetOrders(Convert.ToInt32(CustomerID));

        }

        private void LoadUser()
        {
            string CustomerID = (string)Session["CID"];
            List<Customer> customers = SQLClass.ReadAllCustomers().FindAll(x => x.CustomerID == Convert.ToInt32(CustomerID));

            if (customers != null)
            {
                string stockTableContent = "";

                foreach (var item in customers)
                {
                    if (true)
                    {
                        stockTableContent += $"<tr><td>{item.Firstname}</td><td>{item.Lastname}</td><td>{item.Email}</td><td>{item.Username}</td><td>{item.Password}</td></tr>";

                    }
                }

                Stock.Text = stockTableContent;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CustomerID = (string)Session["CID"];
            SQLClass.UpdateCustomer(Convert.ToInt32(CustomerID), PasswordTextBox.Text);
            LoadUser();
        }
    }
}






