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
            // kontrollera inputvärden med validators
            if (IsValid)
            {
                // hämta alla kunder
                List<Customer> userList = SQLClass.ReadAllCustomers();

                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;

                // plocka ut användaren ur listan
                var loginQuery =
                    from c in userList
                    where c.Username == username && c.Password == password
                    select c.CustomerID;

                var name =
                    from c in userList
                    where c.Username == username && c.Password == password
                    select c.Username;



                // kontrollera om användare finns
                if (loginQuery.Count() > 0)
                {

                    // logga in , dvs byt sida och skicka med contactdID
                    string cid = loginQuery.First().ToString();
                    string uName = name.First().ToString();

                    // värden vi vill spara i sessions
                    Session["Username"] = uName;
                    Session["CID"] = cid;

                    Response.Redirect("/index.aspx?action=login&cid=" + cid);

                   


                }
                else
                {
                    // visa label för felaktigt användarnamn/lösenord
                    labelUserPrompt.Visible = true;
                }
            }
        }
    }
}