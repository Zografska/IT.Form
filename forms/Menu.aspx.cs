using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected int Calculate(string city) {
            return city.Length * 200;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                ListItem li = new ListItem();
                li.Text = "Skopje";
                li.Value = Calculate(li.Text).ToString();
               Dest.Items.Add(li);
                li = new ListItem();
                li.Text = "Milano";
                li.Value = Calculate(li.Text).ToString();
                Dest.Items.Add(li);
                li = new ListItem();
                li.Text = "Kiev";
                li.Value = Calculate(li.Text).ToString();
                Dest.Items.Add(li);
                li = new ListItem();
                li.Text = "LosAndzeles";
                li.Value = Calculate(li.Text).ToString();
                Dest.Items.Add(li);

                Dest.DataBind();

                for (int i = 1; i <= 31; i++)
                {
                    li = new ListItem();
                    li.Text = i.ToString();
                    li.Value = i.ToString();
                    Day.Items.Add(li);
                }
                Day.DataBind();
                for (int i = 1; i <= 12; i++)
                {
                    li = new ListItem();
                    li.Text = i.ToString();
                    li.Value = i.ToString();
                    Month.Items.Add(li);
                }
                Month.DataBind();
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            NameVal.Text = Name.Text;
            AgeVal.Text = Age.Text;
            string day="",month="";
            foreach (ListItem item in Day.Items) {
                if (item.Selected)
                { day = item.Text;
                    break;
                }
            }
            foreach (ListItem item in Month.Items)
            {
                if (item.Selected)
                {
                    month = item.Value;
                    break;
                }
            }
            ClassVal.Text = "Day: " + day + " Month " + " " + month;
            DestVal.Text = Dest.SelectedItem.Text + " with cost " + Dest.SelectedValue;
            ClassVal.Text = Class.Text;
            Image1.ImageUrl = Mode.SelectedValue;
        }

        protected void Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                Image1.ImageUrl = Mode.SelectedValue;
            
        }
    }
}