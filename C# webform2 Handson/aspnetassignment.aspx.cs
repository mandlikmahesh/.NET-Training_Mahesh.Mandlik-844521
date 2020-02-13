using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void anu_Click(object sender, EventArgs e)
        {

            suriyaEntities6 mahesh = new suriyaEntities6();
            web mandlik = new web();
            mandlik.FirstName = TextBox1.Text;
            mandlik.Age = int.Parse(TextBox2.Text);
            mandlik.LoginName = TextBox3.Text;

            mandlik.pwd = TextBox4.Text;
           
            mandlik.sal = int.Parse(TextBox7.Text);
            mandlik.experience = int.Parse(TextBox6.Text);
            mahesh.webs.Add(mandlik);
            mahesh.SaveChanges();

        }

       
    }
}