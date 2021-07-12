using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace CHEF_GATO_ADMIN
{
    public partial class Receitas : Form
    {


        public Receitas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }



        private void Procura_Rec_por_Nome_Btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(proc_rec_nome.Text))
            { MessageBox.Show("Termo de pesquisa sem informação!..."); }
            else
            {
                Resultado_cbx.DataSource = DAL.Receita.Rec_por_nome(proc_rec_nome.Text);
                if (DAL.Receita.Rec_por_nome(proc_rec_nome.Text).Rows.Count == 0)
                { MessageBox.Show("Sem resultados"); }
                else
                { Resultado_cbx.DisplayMember = "Nome"; }
            }
            proc_rec_nome.Clear();
        }

        private void Receitas_Load(object sender, EventArgs e)
        {

        }


        private void Proc_rec_categoria_btn_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(proc_rec_categoria.Text))
            { MessageBox.Show("Termo de pesquisa sem informação!..."); }
            else
            {
                Resultado_cbx.DataSource = DAL.Receita.Rec_por_categoria(proc_rec_categoria.Text);
                if (DAL.Receita.Rec_por_categoria(proc_rec_categoria.Text).Rows.Count == 0)
                { MessageBox.Show("Sem resultados"); }
                else
                { Resultado_cbx.DisplayMember = "Nome"; }
            }
            proc_rec_categoria.Clear();
        }

        private void Proc_rec_ing_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(proc_rec_ing.Text))
            { MessageBox.Show("Termo de pesquisa sem informação!..."); }
            else
            {
                Resultado_cbx.DataSource = DAL.Receita.Rec_por_ingrediente(proc_rec_ing.Text);
                if (DAL.Receita.Rec_por_ingrediente(proc_rec_ing.Text).Rows.Count == 0)
                { MessageBox.Show("Sem resultados"); }
                else
                {
                    Resultado_cbx.DisplayMember = "Nome";
                }
                proc_rec_ing.Clear();
            }

            }
        private void Rec__por_validar_btn_Click(object sender, EventArgs e)
        {
            Resultado_cbx.DataSource = DAL.Receita.Rec_nao_validadas();
            if (DAL.Receita.Rec_nao_validadas().Rows.Count == 0)
            {MessageBox.Show("Sem resultados"); }
            else
            { Resultado_cbx.DisplayMember = "Nome"; }

        }
        private void Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ver_detalhes_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Resultado_cbx.Text))
            { MessageBox.Show("Detalhes de quê??"); }
            else
            {
                Ver_Receita rec = new Ver_Receita(DAL.Receita.Recid_por_nome(Convert.ToString(Resultado_cbx.Text)));

                rec.Show();
            }
        }

        private void Proc_rec_nome_TextChanged(object sender, EventArgs e)
        {
            proc_rec_categoria.Clear();
            proc_rec_ing.Clear();
            
        }

        private void Proc_rec_ing_TextChanged(object sender, EventArgs e)
        {
            proc_rec_nome.Clear();
            proc_rec_categoria.Clear();
            
        }

        private void Proc_rec_categoria_TextChanged(object sender, EventArgs e)
        {
            proc_rec_nome.Clear();
            proc_rec_ing.Clear();
            
        }
    }
}
