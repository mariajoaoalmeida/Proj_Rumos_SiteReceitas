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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() == 0)

            {
                Categorias form = new Categorias
                {
                    MdiParent = this
                };
                form.Show();
                form.WindowState = FormWindowState.Maximized;
            }
            else

            {
                MessageBox.Show("Já tem um formulário aberto! Não pode abrir outro!!!");
            }
        }



        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void receitasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() == 0)

            {
                Receitas form = new Receitas
                {
                    MdiParent = this
                };
                form.Show();
                form.WindowState = FormWindowState.Maximized;
            }
            else

            {
                MessageBox.Show("Já tem um formulário aberto! Não pode abrir outro!!!");
            }
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() == 0)

            {
                Ingredientes form = new Ingredientes
                {
                    MdiParent = this
                };
                form.Show();
                form.WindowState = FormWindowState.Maximized;
            }
            else

            {
                MessageBox.Show("Já tem um formulário aberto! Não pode abrir outro!!!");
            }
        }

        private void utlizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() == 0)

            {
                Utilizadores form = new Utilizadores
                {
                    MdiParent = this
                };
                form.Show();
                form.WindowState = FormWindowState.Maximized;
            }
            else

            {
                MessageBox.Show("Já tem um formulário aberto! Não pode abrir outro!!!");
            }
        }
    }
}
