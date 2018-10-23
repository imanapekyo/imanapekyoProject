using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String NAME = Request.QueryString["NAME"];
            String IC = Request.QueryString["IC"];
            String BLOODGROUP = Request.QueryString["BLOODGROUP"];
            String GENDER = Request.QueryString["GENDER"];
            Label1.Text = "BLOOD DONOR INFORMATION" + NAME + " " + IC + BLOODGROUP + GENDER;
        }
    }
}