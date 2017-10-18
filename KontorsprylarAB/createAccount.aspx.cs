﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQLLibraryKAB;
using KontorsprylarAB;

namespace KontorsprylarAB
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegistration_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                string firstName = TextBoxFirstname.Text;
                string lastName = TextBoxLastname.Text;
                string email = TextBoxEmail.Text;
                string username = TextBoxUsername.Text;
                string password = TextBoxEmail.Text;

                try
                {
                    SQLClass.AddCustomer(firstName, lastName, email, username, password);

                }
                catch (Exception ex)
                {
                    
                }
            }

        }
    }
}