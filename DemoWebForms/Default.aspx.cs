﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_Click.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lbl_Click.Text = "Clicked!";
        }
    }
}