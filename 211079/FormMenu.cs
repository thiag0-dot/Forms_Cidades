using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _211079.Views;

namespace _211079
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Banco.CriandoBanco();
        }


        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCidades form = new FormCidades();
            form.Show();
            
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMarca form = new FormMarca();
            form.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            form.Show();
        }
    }
}
