using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KontorsprylarAB
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAddToCart_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                string format = PaperFormat.SelectedValue;
                string quantity = PaperQuantity.SelectedValue;

                Response.Redirect($"/checkout.aspx?format={format}&quantity={quantity}");
            }
        }
    }
}