﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("WebForm4.aspx" Session ["Firstname"] = TextBox1.Text ;
            Session["firstname"].ToString();
            Session["lastname"].ToString();
            Response.Redirect("WebForm4? ");
        }
    }
}