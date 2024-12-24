using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practice_sem6_asp.net
{
    public partial class PRT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int p, r, t;
            p = Convert.ToInt32(TextBox1.Text);
            r = Convert.ToInt32(TextBox2.Text);
            t = Convert.ToInt32(TextBox3.Text);
            int intrest;
            intrest = (p * r * t) / 100;
            Response.Write(intrest);
        }
    }
}