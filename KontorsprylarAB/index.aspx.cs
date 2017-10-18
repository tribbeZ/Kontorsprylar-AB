using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLLibraryKAB;

namespace KontorsprylarAB
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request["action"]!=null)
            {
                int cid = int.Parse(Request["cid"]);


                List<Customer> tempList = SQLClass.ReadAllCustomers();

                var userQuery =
                    from n in tempList
                    where n.CustomerID == cid
                    select n.Firstname;

                string name = userQuery.FirstOrDefault();

                labelUser.Text = name;
            }
        }        


    }
}