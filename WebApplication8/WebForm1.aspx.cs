using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ime = TextBox1.Text;
            string lozinka = TextBox2.Text;
            var doc = XDocument.Load(Server.MapPath("~/XMLFile2.xml"));
            var result = doc.Descendants("korisnik").
                Where(x => x.Element("ime").Value == ime && x.Element("lozinka").Value == lozinka).
                Select(x => new
                {
                    ime = x.Element("ime").Value,
                    lozinka = x.Element("lozinka").Value
                });
            if (result.Count() > 0)
            {
                Label1.Text = "Dobrodosli na sajt!";
            }
            else
            {
                Label1.Text = "Pogresni podaci!";
            }
        }
    }
}