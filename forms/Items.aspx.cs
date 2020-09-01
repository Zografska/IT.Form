using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forms
{
    public partial class Items : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cart.DataSource = (ArrayList)Session["cart"];
            cart.DataBind();
            if (!this.IsPostBack) {
               
                // Database
                string[] math = {
                "Algebra I",
                "Calculus I",
                "Calculus II",
                "Calculus III",
                "Trigonometry"
                };
                string[] math_price = {
                "3","5","6","7","8"
                };
                string[] bio = {
                "Anatomy I",
                "Anatomy II",
                "Microbiology",
                "Citology",
                "Ecology"};
                string[] bio_price = {
                "2","4","3","5","9"
                };
                //Use of Query String
                switch (Convert.ToInt32(Request.QueryString.Get("catId"))) {
                    case 0:
                        items.DataSource = math;
                        prices.DataSource = math_price;
                       
                        break;
                    case 1:
                        items.DataSource = bio;
                        prices.DataSource = bio_price;
                        break;


                }
                header.Text = Request.QueryString.Get("name");
                items.DataBind();
                prices.DataBind();
            }
        }

        protected void items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ViewState["totalChanges"] == null)
            {
                ViewState["totalChanges"] = 1;
            }
            else
            {
                ViewState["totalChanges"] = Convert.ToInt32(ViewState["totalChanges"]) + 1;
            }
            //(int)ViewState["totalChanges"].ToString(); -> kolku pati e smenet indeksot
            price.Text = "oti nekjis";
            prices.SelectedIndex = items.SelectedIndex;
            price.Text = prices.SelectedValue;
        }

        protected void goback_Click(object sender, EventArgs e)
        {
            Response.Redirect("Categories.aspx");
        }

        protected void addtocart_Click(object sender, EventArgs e)
        {
            ArrayList list;
            if (Session["cart"] == null)
            {
                list = new ArrayList();
            }
            else
                list = (ArrayList)Session["cart"];
            list.Add(new ListItem(items.SelectedItem.Text, prices.SelectedItem.Text));
            // Ovie atributi treba da se setirani
            // za da se znae od kade se zema Text i Value, soodvetno
            cart.DataTextField = "Text";
            cart.DataValueField = "Value";
            cart.DataBind();

            Session["cart"] = list;
            CalculatePrice();
        }
        protected void CalculatePrice() {
            ArrayList list = (ArrayList)Session["cart"];
            int bill = 0;
            foreach (ListItem item in list)
            {
                bill += Convert.ToInt32(item.Value);
            }
            price.Text = bill.ToString();
        }

        protected void checkout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checkout.aspx");
        }
    }
}