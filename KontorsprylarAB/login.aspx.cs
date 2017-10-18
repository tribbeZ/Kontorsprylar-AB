using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLLibraryKAB;

namespace KontorsprylarAB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ta in username och password
            // jämföra mot databas
            // logga in om korrekt
            // annars "försök igen"


            
        }

        protected void buttonLogin_Click(object sender, EventArgs e)
        {
            
            List<Customer> userList = SQLClass.ReadAllCustomers();

            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // plocka ut användaren ur listan
            var loginQuery =
                from c in userList
                where c.Username == username && c.Password == password
                select c.CustomerID;

            string  cid = loginQuery.First().ToString();

            // kontrollera om användare finns
            if (loginQuery.Count() > 0)
            {
                // logga in , dvs byt sida och skicka med contactdID

                Response.Redirect("/index.aspx?action=login&cid=" + cid);


            }
            else
            {
                // säg till användaren att försöka igen via labels, säkra input??
            }
        }
    }
}