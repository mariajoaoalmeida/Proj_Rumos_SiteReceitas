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
    public partial class Utilizadores : Form
    {
        public Utilizadores()
        {
            InitializeComponent();
        }



        public void Utilizadores_Load(object sender, EventArgs e)
        {
            users_cbx.ResetText();
            Bloqueados_cbx.ResetText();

            DataTable dtdesbl = new DataTable();
            dtdesbl = DAL.User.Lista_Users_estado(0);

           
            users_cbx.DataSource = dtdesbl;
            users_cbx.ForeColor = Color.DarkRed;
            users_cbx.DisplayMember = "Nome";
            users_cbx.ValueMember = "UserId";

            DataTable dtbloq = new DataTable();
            dtbloq = DAL.User.Lista_Users_estado(1);

            Bloqueados_cbx.DataSource = dtbloq;
            users_cbx.ForeColor = Color.DarkGreen;
            Bloqueados_cbx.DisplayMember = "Nome";
            Bloqueados_cbx.ValueMember = "UserId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (users_cbx.SelectedItem == null || this.users_cbx.SelectedIndex == -1)
            { MessageBox.Show("Não há users para bloquear..."); }
            else
            {
                DAL.User.Altera_Users_estado(users_cbx.Text, 1);
                Utilizadores_Load(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Bloqueados_cbx.SelectedItem == null || this.Bloqueados_cbx.SelectedIndex == -1)
            { MessageBox.Show("Não há users para desbloquear..."); }
            else
            {
                DAL.User.Altera_Users_estado(Bloqueados_cbx.Text, 0);

                Utilizadores_Load(sender, e);
            }
        }
    }
}
