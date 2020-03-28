using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResponseRedirectVsServerTransfer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Default1.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string url = "Default1.aspx";
            StringBuilder sb = new StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.open('");
            sb.Append(url);
            sb.Append("');");
            sb.Append("</script>");
            ClientScript.RegisterStartupScript(this.GetType(),
                    "script", sb.ToString());
        }
    }
}