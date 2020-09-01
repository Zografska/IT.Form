using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forms
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Items.aspx?catId=0&name=Math");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Items.aspx?catId=1&name=Bio");
        }
    }
}