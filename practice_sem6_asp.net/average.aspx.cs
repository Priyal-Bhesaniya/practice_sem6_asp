using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practice_sem6_asp.net
{
    public partial class average : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = Convert.ToInt32(TextBox1.Text);
            num2 = Convert.ToInt32(TextBox2.Text);
            num3 = Convert.ToInt32(TextBox3.Text);
            int average = (num1 + num2 + num3) / 3;
            Response.Write(average);
        }
    }
}