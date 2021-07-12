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
    public partial class Receita_detalhe : System.Web.UI.Page
    {
        int recid { get; set; }
        MembershipUser uti;
        public void Page_Load(object sender, EventArgs e)
        {

            Session["user"] = uti;

            string id = Request.QueryString["id"];
            int rec = Convert.ToInt32(id);
            ReceitaId.Text = id;
            DataTable dti = new DataTable();
            dti = DAL.Receita.Rec_por_recid(id);
            nome_lbl.Text = dti.Rows[0]["Nome"].ToString();
            categoria.Text = "Categoria:  " + dti.Rows[0]["Categoria"].ToString();
            doses.Text = "Números de Doses:  " + dti.Rows[0]["Doses"].ToString();
            dificuldade.Text = "Dificuldade:  " + dti.Rows[0]["Dificuldade"].ToString();
            tempo_exec.Text = "Tempo de Execução:  " + dti.Rows[0]["TempoPrep"].ToString();
            autor.Text = "Autor:  " + dti.Rows[0]["Autor"].ToString();
            Preparacao.Text = "Preparação:  " + dti.Rows[0]["Preparacao"].ToString();
            string recid = dti.Rows[0]["ReceitaID"].ToString();

            Image1.ImageUrl = "data:Image/png;base64," + Convert.ToBase64String((byte[])dti.Rows[0]["Foto"]);
            Image1.DataBind();
            Voto_txb.Text = "Votação:  " + (Convert.ToString(DAL.Votacao.Voto_por_recid(rec)));

            DataTable dt_ing = new DataTable();
            dt_ing = DAL.IngredientesReceita.Ingredientes_da_Receita(id);
            GridView1.DataSource = dt_ing;

            GridView1.DataBind();

            Repeater2.DataSource = DAL.Comentario.Comentarios_por_recid(rec);
            Repeater2.DataBind();
            RF_resultado.Visible = false;

            string previousPage = HttpContext.Current.Request.UrlReferrer.AbsolutePath;

            if (previousPage == "/Area_Pessoal_REG.aspx")
            {
                Image2.Visible = false;
                Adicionar_fv_btn.Visible = false;
            }
            if (Page.IsPostBack)
            {
                Page.MaintainScrollPositionOnPostBack = true;
            }




        }

        protected void Sbmt_Comt_btn_Click(object sender, EventArgs e)
        {
            uti = Membership.GetUser(User.Identity.Name);
            string user = Membership.GetUser().ProviderUserKey.ToString();

            Image4.Visible = false;

            if (Comentario_bx.Text == String.Empty ||
                String.IsNullOrWhiteSpace(Comentario_bx.Text))
            { Image4.Visible = true; }
            else
            {
                string comentario = Comentario_bx.Text;
                cmt_txb.Text=DAL.Comentario.Insere_Comentario(comentario, (Convert.ToInt32(ReceitaId.Text)), user);
                Comentario_bx.Text = String.Empty;
               
            }
        }

        protected void GridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[4].Visible = false;
        }

        protected void Sbmt_voto_btn_Click(object sender, EventArgs e)
        {
            filtro_voto.Visible = false;
            Image3.Visible = false;
            uti = Membership.GetUser(User.Identity.Name);
            string user = Membership.GetUser().ProviderUserKey.ToString();

            int valor = 0;
            if (Excelente.Checked) { valor = 5; }
            if (Bom.Checked) { valor = 4; }
            if (Medio.Checked) { valor = 3; }
            if (Mau.Checked) { valor = 2; }
            if (Pessimo.Checked) { valor = 1; }
            if(!Excelente.Checked && !Bom.Checked && !Medio.Checked &&! Mau.Checked && !Pessimo.Checked)
   
            {
                Image3.Visible = true;
            }

            if (DAL.Votacao.Filtra_Voto(Convert.ToInt32(ReceitaId.Text)).Contains(user)==true)
            {
                filtro_voto.Text = "Já votaste nesta receita...";
                filtro_voto.Visible = true;
            }

            else
            {
                DAL.Votacao.Insere_Voto(valor, user, (Convert.ToInt32(ReceitaId.Text)));
                filtro_voto.Text = "Voto inserido. Obrigada...";
                filtro_voto.Visible = true;

            }

        }

        protected void Repeater2_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void Adicionar_fv_btn_Click(object sender, EventArgs e)
        {
            uti = Membership.GetUser(User.Identity.Name);
            string user = Membership.GetUser().ProviderUserKey.ToString();
            int recid = Convert.ToInt32(ReceitaId.Text);
            RF_resultado.Text = DAL.Receita.Adiciona_Favoritas(recid, user);
            RF_resultado.Visible = true;
            Adicionar_fv_btn.Visible = false;

        }
    }
}