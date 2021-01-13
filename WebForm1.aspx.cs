using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using entity_classes;
using business_logic_layer;
using System.Data;
using System.Data.SqlClient;
namespace three_layer_architecture_in_asp.net
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static BLL ob = new BLL(GCON.str);
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Entity emp = new Entity { name = TextBox2.Text, dob = TextBox3.Text };
            ob.add("inserttab", emp);
            GridView1.DataSource = ob.show("display");
            GridView1.DataBind();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = ob.show("display");
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
             HiddenField1.Value= TextBox8.Text ;
            GridView1.DataSource=ob.search("search", Convert.ToInt32(HiddenField1.Value));
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox8.Text = HiddenField1.Value;
            System.Threading.Thread.Sleep(5000);
            ob.delete("deletetab", Convert.ToInt32(TextBox8.Text));
            GridView1.DataSource = ob.show("display");
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox8.Text = HiddenField1.Value;
            System.Threading.Thread.Sleep(5000);
            ob.update("updatetab",Convert.ToInt32(TextBox8.Text),TextBox6.Text,TextBox7.Text);
            System.Threading.Thread.Sleep(5000);
            GridView1.DataSource = ob.show("display");
            GridView1.DataBind();
        }
    }
}