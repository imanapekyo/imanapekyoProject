using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String message = "";
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    message += item.Text;
                    message += ", ";
                }
            }
            Response.Write("You have choosed " + message);
        }
    }
}