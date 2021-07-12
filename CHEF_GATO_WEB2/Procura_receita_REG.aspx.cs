using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CHEF_GATO_WEB2
{
    public partial class Procura_receita_REG : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.MaintainScrollPositionOnPostBack = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Image1.Visible = false;
            Repeater1.DataSource = DAL.Receita.Rec_por_nome(TextBox1.Text);
            if (DAL.Receita.Rec_por_nome(TextBox1.Text).Rows.Count == 0)
            {
                Image1.Visible = true;
                TextBox1.Text = String.Empty;
            }
            Repeater1.DataBind();
        }
        protected void Button2_Click1(object sender, EventArgs e)
        {
            Image1.Visible = false;
            Repeater1.DataSource = DAL.Receita.Rec_por_ingrediente(TextBox2.Text);
            if (DAL.Receita.Rec_por_ingrediente(TextBox2.Text).Rows.Count == 0)
            {
                Image1.Visible = true;
                TextBox2.Text = String.Empty;
            }

            Repeater1.DataBind();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Image1.Visible = false;
            Repeater1.DataSource = DAL.Receita.Rec_por_categoria(TextBox3.Text);
            if (DAL.Receita.Rec_por_categoria(TextBox3.Text).Rows.Count == 0)
            {
                Image1.Visible = true;
                TextBox3.Text = String.Empty;
            }

            Repeater1.DataBind();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            string id = btn.CommandArgument;
            Response.Redirect("Receita_detalheREG.aspx?id=" + id);
        }

        protected void Button_VerTodas_Click1(object sender, EventArgs e)
        {
            Repeater1.DataSource = DAL.Receita.Todas_receitas();
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}