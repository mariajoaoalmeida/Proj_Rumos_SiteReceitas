using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHEF_GATO_ADMIN
{
    public partial class Ver_Receita : Form
    {


        public Ver_Receita(string Recid)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Recid_txt.Text = Recid;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataTable dti = new DataTable();
            dti = DAL.Receita.Rec_por_recid(Recid_txt.Text);
            Nome_rec_txb.Text = dti.Rows[0]["Nome"].ToString();
            Categoria_cbx.Text = dti.Rows[0]["Categoria"].ToString();
            doses_txb.Text = dti.Rows[0]["Doses"].ToString();
            Dificuldade_cbx.Text = dti.Rows[0]["Dificuldade"].ToString();
            TempoPrep_cbx.Text = dti.Rows[0]["TempoPrep"].ToString();
            autor_txb.Text = dti.Rows[0]["Autor"].ToString();
            Preparacao_txb.Text = dti.Rows[0]["Preparacao"].ToString();

            try
            {
                MemoryStream ms = new MemoryStream((byte[])dti.Rows[0]["Foto"]);

                Foto_receita_picbox.Image = new Bitmap(ms);
            }
            catch
            {
                Foto_receita_picbox.ImageLocation = "../IMG.sem_foto3";
                Foto_receita_picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            string estado = dti.Rows[0]["Aprovada"].ToString();
            if (estado == "True")
            { estado_cbx.Text = "Validada"; }
            else
            { estado_cbx.Text = "Não Validada"; }

            DataTable dt_ing = new DataTable();

            dt_ing = DAL.IngredientesReceita.Ingredientes_da_Receita(Recid_txt.Text);
            Ingredientes_dgv.DataSource = dt_ing;
            this.Ingredientes_dgv.Columns[0].Visible = false;
            this.Ingredientes_dgv.Columns[1].Visible = false;
            this.Ingredientes_dgv.Columns[4].Visible = false;

        }

        private void Foto_receita_picbox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ValidaGrid(Ingredientes_dgv) == true && ValidaRec_pt1() == true)

            { MessageBox.Show(DAL.Receita.Update_Receita(Ingredientes_dgv, Convert.ToInt32(Recid_txt.Text), Parte1())); }

            else

            { MessageBox.Show("Nice try... :)"); }


        }

        private bool ValidaGrid(DataGridView dgv)

        {
            int a = 0;
            bool resultado = true;
            Ingrediente ing = new Ingrediente();

            foreach (DataGridViewRow rw in dgv.Rows)
            {
                for (int i = 0; i < rw.Cells.Count - 2; i++)
                {
                    if (rw.Cells[i].Value == null || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        a++;
                        MessageBox.Show("Não é possível editar...há células sem informação!");
                    }
                }
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 3)
                    {
                        if (double.TryParse((Convert.ToString(cell.Value)), out double k) == false || k == 0)
                        {
                            a++;
                            MessageBox.Show("Há algo de errado com uma quantidade que registaste.." + (Convert.ToString(cell.Value)) + " ??");
                        }
                    }
                }
            }
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 2)
                    {
                        if (DAL.Ingrediente.Ingredientes().Contains(Convert.ToString(cell.Value)) == false)
                        {
                            a++;
                            MessageBox.Show((Convert.ToString(cell.Value)) + "??? Esse ingrediente não existe. Vai adiciona-lo e depois volta aqui!");
                        }
                    }
                }
            }
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 5)
                    {
                        if (DAL.UnidadeMedida.UnidadesMedida().Contains(Convert.ToString(cell.Value)) == false)
                        {
                            a++;
                            MessageBox.Show((Convert.ToString(cell.Value)) + "??? Essa unidade de medida não existe! Não inventes!!!");
                        }
                    }
                }
            }

            if (a == 0)
            { resultado = true; }

            else
            { resultado = false; }

            return resultado;
        }

        private void Ingredientes_dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("A quantidade tem de ser um número! ");
        }
        private bool ValidaRec_pt1()

        {
            int a = 0;
            bool resultado = true;

            if (String.IsNullOrWhiteSpace(Nome_rec_txb.Text) == true ||
                String.IsNullOrWhiteSpace(doses_txb.Text) == true ||
                String.IsNullOrWhiteSpace(Preparacao_txb.Text) == true)
            {
                a++;
                MessageBox.Show("Não é possível editar...há campos sem informação!");
            }

            Regex nonNumericRegex = new Regex(@"\D");
            if (nonNumericRegex.IsMatch(doses_txb.Text))
            {
                a++;
                MessageBox.Show("Há algo de errado com o nº doses que registaste.." + (Convert.ToString(doses_txb)) + " ??");
            }


            if (a == 0)
            { resultado = true; }

            else
            { resultado = false; }

            return resultado;
        }

        private string[] Parte1()
        {
            string[] parte1 = new string[8];

            parte1[0] = Nome_rec_txb.Text;
            parte1[1] = Categoria_cbx.Text;
            parte1[2] = doses_txb.Text;
            parte1[3] = Dificuldade_cbx.Text;
            parte1[4] = TempoPrep_cbx.Text;
            parte1[5] = autor_txb.Text;
            parte1[6] = Preparacao_txb.Text;

            if (estado_cbx.Text == "Validada")

            { parte1[7] = "1"; }
            else { parte1[7] = "0"; }
            return parte1;


        }

    }



}
