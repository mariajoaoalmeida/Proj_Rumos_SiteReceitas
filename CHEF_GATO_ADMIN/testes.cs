using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHEF_GATO_ADMIN
{
    public partial class testes : Form
    {
        public testes()
        {
            InitializeComponent();
            textBox1.Text= "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex nonNumericRegex = new Regex(@"\D");
            if (nonNumericRegex.IsMatch(textBox1.Text)==true)
            {
                textBox2.Text = "true";
            }
            else
            { textBox2.Text = "false"; }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
