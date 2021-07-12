using DAL;
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
    public partial class Ingredientes : Form
    {
        public Ingredientes()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<string> ingredientes = new List<string>();
            _ = new DataTable();
            DataTable dt = Ingrediente.Lista_Todos_Ingrediente();
            foreach (DataRow dr in dt.Rows)
            { ingredientes.Add(dr["Nome"].ToString()); }

            if (ingredientes.Contains(insere_ing_txb.Text))
            { MessageBox.Show("Esse ingrediente já existe."); }

            else
            {
                MessageBox.Show(DAL.Ingrediente.Insere_Ingrediente(insere_ing_txb.Text));

                Ingredientes_Load(sender, e);
                insere_ing_txb.Clear();
            }

        }

        private void Elimina_ind_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ingredientes_Load(object sender, EventArgs e)
        {
            elimina_ing_cbx.DataSource = DAL.Ingrediente.Lista_Todos_Ingrediente();
            elimina_ing_cbx.DisplayMember = "Nome";
            elimina_ing_cbx.ValueMember = "IngredienteID";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Ingrediente ing = new Ingrediente
            {
                IngredienteId = Convert.ToInt32(elimina_ing_cbx.SelectedValue)
            };
            MessageBox.Show(DAL.Ingrediente.Elimina_Ingrediente(ing));
            Ingredientes_Load(sender, e);
        }
    }
}
