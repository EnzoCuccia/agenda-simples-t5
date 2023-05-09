using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda_simples_t5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contato objetoContato= new Contato();
            lstcontatos.Items.Add(objetivoContato.ToString())
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
