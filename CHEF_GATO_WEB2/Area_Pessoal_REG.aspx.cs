using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CHEF_GATO_WEB2
{
    public partial class Area_Pessoal_REG : System.Web.UI.Page
    {

        MembershipUser uti;
        public void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack)
            {
                Page.MaintainScrollPositionOnPostBack = true;
            }


            uti = Membership.GetUser(User.Identity.Name);
            string userID = "'" + Membership.GetUser().ProviderUserKey.ToString() + "'";


            Session["user"] = uti;

            TextBox1.Text = "Olá " + uti.UserName +" !";
            email_tbx.Text = uti.Email;

            email_tbx.Visible = false;
            novo_email_txb.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Alterar_email_fim_btn.Visible = false;
            AntigaPass_txb.Visible = false;
            NovaPass_txb.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            Alterar_pass_fim_btn.Visible = false;

        }


        public void Button3_Click(object sender, EventArgs e)
        {
            DataTable res = new DataTable();
            res = DAL.Receita.Receitas_Favoritas(Membership.GetUser().ProviderUserKey.ToString());

            if (res.Rows.Count == 0)

            {
                resultado_rec_favoritas.Text = "Não tens receitas favoritas carregadas...";
                resultado_rec_favoritas.Visible = Visible;
            }
            else
            {
                Repeater1.DataSource = res;
                Repeater1.DataBind();
            }
        }

        protected void Repeater1_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {

        }
        protected void Button5_Click(object sender, EventArgs e)
        {

            Response.Redirect("InserirReceita.aspx");

        }

        protected void Button4_Click(object sender, EventArgs e)
        {   Button btn = (sender as Button);
            string id = btn.CommandArgument;
  
            Response.Redirect("Receita_detalheREG.aspx?id=" + id); 

        }

        protected void Mudar_email_inicio_Click(object sender, EventArgs e)
        {
            email_tbx.Visible = true;
            novo_email_txb.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Alterar_email_fim_btn.Visible = true;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            AntigaPass_txb.Visible = true;
            NovaPass_txb.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            Alterar_pass_fim_btn.Visible = true;


        }

        protected void Alterar_email_btn_Click(object sender, EventArgs e)
        {
            try
            {
                uti.Email = email_tbx.Text;
                uti.Email = novo_email_txb.Text;

                Membership.UpdateUser(uti);


                email_tbx.Visible = false;
                novo_email_txb.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Alterar_email_fim_btn.Visible = false;
                resultado_email_txb.Text = "Email foi alterado com sucesso!";
                resultado_email_txb.Visible = true;

            }
            catch (System.Configuration.Provider.ProviderException e2)
            {
                resultado_email_txb.Text = e2.Message;
                resultado_email_txb.Visible = true;
            }

        }

        protected void Alterar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (uti.ChangePassword(AntigaPass_txb.Text, NovaPass_txb.Text))
                {
                    Msg.Text = "Password alterada com sucesso.";
                    Msg.Visible = true;
                }
                else
                {
                    Msg.Text = "Alteração de Password falhou. Tenta de novo, sff";
                    Msg.Visible = true;
                }
            }
            catch (Exception e3)
            {
                Msg.Text = "Uma excepção ocorreu: " + Server.HtmlEncode(e3.Message) + ". Por favor tenta de novo.";
                Msg.Visible = true;
            }
        }

        protected void NovaPass_txb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}