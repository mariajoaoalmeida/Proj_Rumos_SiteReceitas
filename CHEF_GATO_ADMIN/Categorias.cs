using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHEF_GATO_ADMIN
{
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<string> categorias = new List<string>();
            _ = new DataTable();
            DataTable dt = DAL.Categoria.Lista_Todas_Categorias();
            foreach (DataRow dr in dt.Rows)
            { categorias.Add(dr["Nome"].ToString()); }

            if (categorias.Contains(nova_cat_txb.Text))
            { MessageBox.Show("Essa categoria já existe."); }

            else
            {
                MessageBox.Show(DAL.Categoria.Insere_Categoria(nova_cat_txb.Text));

                Categorias_Load(sender, e);
                nova_cat_txb.Clear();
            }
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            elimina_cat_cbx.DataSource = DAL.Categoria.Lista_Todas_Categorias();
            elimina_cat_cbx.DisplayMember = "Nome";
            elimina_cat_cbx.ValueMember = "CategoriaID";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DAL.Categoria.Elimina_Categoria(Convert.ToInt32(elimina_cat_cbx.SelectedValue)));
            Categorias_Load(sender, e);
        }
    }
}
