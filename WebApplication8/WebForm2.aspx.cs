using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication8
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var doc = XDocument.Load(Server.MapPath("~/XMLFile1.xml"));
            var knjige = doc.Descendants("knjiga").
                Select(x => new
                {
                    ISBN = x.Attribute("ISBN").Value,
                    naslov = x.Element("naslov").Value,
                    stanje = x.Element("stanje").Value,
                    citano = x.Element("citano").Value
                });
            GridView1.DataSource = knjige;
            GridView1.DataBind();
        }
    }
}