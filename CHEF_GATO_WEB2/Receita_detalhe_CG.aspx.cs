using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CHEF_GATO_WEB2
{
    public partial class Receita_detalhe_CG : System.Web.UI.Page
    {
        int recid { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.MaintainScrollPositionOnPostBack = true;
            }
            string id = Request.QueryString["id"];
            int rec = Convert.ToInt32(id);

            DataTable dti = new DataTable();
            dti = DAL.Receita.Rec_por_recid(id);
            nome_lbl.Text = dti.Rows[0]["Nome"].ToString();
            categoria.Text = "Categoria: " + dti.Rows[0]["Categoria"].ToString();
            doses.Text = "Números de Doses: " + dti.Rows[0]["Doses"].ToString();
            dificuldade.Text = "Dificuldade: " + dti.Rows[0]["Dificuldade"].ToString();
            tempo_exec.Text = "Tempo de Execução: " + dti.Rows[0]["TempoPrep"].ToString();
            autor.Text = "Autor: " + dti.Rows[0]["Autor"].ToString();
            Preparacao.Text = "Preparação: " + dti.Rows[0]["Preparacao"].ToString();
            string recid = dti.Rows[0]["ReceitaID"].ToString();

            Image1.ImageUrl = "data:Image/png;base64," + Convert.ToBase64String((byte[])dti.Rows[0]["Foto"]);
            Image1.DataBind();
            Voto_txb.Text = "Votação: " + (Convert.ToString(DAL.Votacao.Voto_por_recid(rec)));

            DataTable dt_ing = new DataTable();
            dt_ing = DAL.IngredientesReceita.Ingredientes_da_Receita(id);
            GridView1.DataSource = dt_ing;

            GridView1.DataBind();

       



        }
        protected void GridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[4].Visible = false;
        }
    }
}