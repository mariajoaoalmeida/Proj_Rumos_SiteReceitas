using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CHEF_GATO_WEB2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
          
            Response.Redirect("Receita_detalhe_CG.aspx?id=7");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);

            Response.Redirect("Receita_detalhe_CG.aspx?id=8");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);

            Response.Redirect("Receita_detalhe_CG.aspx?id=4");
        }
    }
}