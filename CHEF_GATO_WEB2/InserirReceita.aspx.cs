using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace CHEF_GATO_WEB2
{
    public partial class InserirReceita : System.Web.UI.Page
    {
        MembershipUser uti;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.MaintainScrollPositionOnPostBack = true;
            }

            uti = Membership.GetUser(User.Identity.Name);
            
            Session["user"] = uti;


            if (!IsPostBack)
            {
                DropDownList1.DataSource = DAL.Ingrediente.Lista_Todos_Ingrediente();
                DropDownList1.DataTextField = "Nome";
                DropDownList1.DataValueField = "IngredienteID";
                DropDownList1.DataBind();

                DropDownList7.DataSource = DAL.Categoria.Lista_Todas_Categorias();
                DropDownList7.DataTextField = "Nome";
                DropDownList7.DataValueField = "CategoriaID";
                DropDownList7.DataBind();



                DropDownList8.DataSource = DAL.UnidadeMedida.UnidadesMedida();

                DropDownList8.DataBind();
                GridView1.DataSource = ViewState["GridviewData"];
                GridView1.DataBind();


            }

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["GridviewData"] == null)
            {
                erro_sem_ings.Visible = true;

            }


            else
            {
                Panel1.Visible = false;
                GridView2.Visible = true;
                GridView2.DataSource = ViewState["GridviewData"];
                GridView2.DataBind();
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        protected void Adicionar_ing_bt_Click(object sender, EventArgs e)
        {
            Label18.Visible = false;
            erro_sem_ings.Visible = false;
            erro_qt.Visible = false;
            DataTable dt = (DataTable)ViewState["GridviewData"];

            Regex nonNumericRegex = new Regex(@"\D");
            if (nonNumericRegex.IsMatch(TextBox1.Text) == true ||
                String.IsNullOrWhiteSpace(TextBox1.Text) == true || Convert.ToInt32(TextBox1.Text) == 0)
            {
                erro_qt.Visible = true;
            }

            else
            {
                if (dt is null)
                {
                    DataTable dt2 = new DataTable();
                    dt2.Columns.Add("Ingredientes", typeof(string));
                    dt2.Columns.Add("Quantidade", typeof(string));
                    dt2.Columns.Add("Unidade", typeof(string));
                    DataRow dr = dt2.NewRow();
                    dr["Ingredientes"] = DropDownList1.SelectedItem.Text;
                    dr["Quantidade"] = TextBox1.Text;
                    dr["Unidade"] = DropDownList8.SelectedItem.Text;
                    dt2.Rows.Add(dr);
                    ViewState["GridviewData"] = dt2;
                    GridView1.DataSource = dt2;
                    GridView1.DataBind();
                }

                else
                {
                    List<string> ings = new List<string>();
                    foreach (DataRow dr in dt.Rows)
                    { ings.Add(dr["Ingredientes"].ToString()); }

                    if (ings.Contains(DropDownList1.SelectedItem.Text))
                    { Label18.Visible = true; }
                    else
                    {
                        int a = GridView1.Rows.Count;
                        DataRow NewRow = dt.NewRow();
                        NewRow["Ingredientes"] = DropDownList1.SelectedItem.Text;
                        NewRow["Quantidade"] = TextBox1.Text;
                        NewRow["Unidade"] = DropDownList8.SelectedItem.Text;
                        dt.Rows.InsertAt(NewRow, a + 1);
                        GridView1.DataSource = dt;
                        ViewState["GridviewData"] = dt;
                        GridView1.DataBind();
                    }
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int c = 0;
            nome_erro.Visible = false;
            erro_prep.Visible = false;
            erro_sem_ings.Visible = false;
            Label15.Visible = false;

            if (GridView1.Visible == true)
            {
                erro_sem_ings.Visible = true;
            }


            if (String.IsNullOrWhiteSpace(TextBox3.Text) == true)
            {
                c++;
                nome_erro.Visible = true;
            }

            if (String.IsNullOrWhiteSpace(TextBox2.Text) == true)
            {
                c++;
                erro_prep.Visible = true;
            }
            if (ViewState["GridviewData"] == null)
            {
                c++;
                erro_sem_ings.Visible = true;
            }

            if (DAL.Receita.NomesRec().Contains(TextBox3.Text) == true)
            {
                Label15.Visible = true;
                c++;
            }

            if (c == 0)
            {
                finalizar.Visible = true;
                Button3.Visible = true;
                Button4.Visible = true;

            }





        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            finalizar.Visible = false;
            Button3.Visible = false;
            Button4.Visible = false;
            TextBox3.Text = String.Empty;
            TextBox1.Text = String.Empty;
            TextBox2.Text = String.Empty;
            DropDownList8.SelectedIndex = default;
            DropDownList1.SelectedIndex = default;
            DropDownList7.SelectedIndex = default;
            DropDownList5.SelectedIndex = default;
            DropDownList6.SelectedIndex = default;
            ViewState["GridviewData"] = null;


        }
        protected void DeletingRow(int rowIndex)
        {
            DataTable dt3 = (DataTable)ViewState["GridviewData"];
            dt3.Rows.RemoveAt(rowIndex);
            GridView1.DataSource = dt3;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DeletingRow(e.RowIndex);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            uti = Membership.GetUser(User.Identity.Name);

            DataTable dti = (DataTable)ViewState["GridviewData"];


            string[] parte1 = new string[8];

            parte1[0] = TextBox3.Text;
            parte1[1] = DropDownList7.SelectedItem.Text;
            parte1[2] = DropDownList6.SelectedItem.Text;
            parte1[3] = DropDownList9.SelectedItem.Text;
            parte1[4] = DropDownList5.SelectedItem.Text;
            parte1[5] = uti.UserName;
            parte1[6] = TextBox2.Text;
            parte1[7] = "0";

            byte[] bytes = FotoCarregada();

            if (DAL.Receita.Insere_Receita(dti, parte1, bytes) == 1)
            { Label16.Visible = true; }
            else { Label17.Visible = true; }

            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            GridView2.Visible = false;
            Button6.Visible = true;

        }

        protected byte[] FotoCarregada()
        {

            if (FileUpload1.FileContent == null)
            { return null; }
            else
            {
                HttpPostedFile postedfile = FileUpload1.PostedFile;
                string filename = Path.GetFileName(postedfile.FileName);
                string fileExtension = Path.GetExtension(filename);

                if (fileExtension != ".jpg" || fileExtension != ".bmp" || fileExtension != ".gif" || fileExtension != ".png")

                {
                    Image2.Visible = true;
                    return null;
                }

                else
                {
                    Stream stream = postedfile.InputStream;
                    BinaryReader binaryReader = new BinaryReader(stream);
                    byte[] bytes = binaryReader.ReadBytes((int)stream.Length);


                    return bytes;
                }
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            string strBase64 = Convert.ToBase64String(FotoCarregada());
            Image1.ImageUrl = "data:Image/png;base64," + strBase64;
            Image1.DataBind();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/InserirReceita.aspx");
        }

        protected void Adicionar_ing_btn_Click(object sender, EventArgs e)
        {

        }

        protected void adicionar_ing_btn_Click(object sender, EventArgs e)
        {

        }
    }
}

