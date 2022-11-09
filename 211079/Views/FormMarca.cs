using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _211079.Models;

namespace _211079.Views
{
    public partial class FormMarca : Form
    {
        Marca m;
        public FormMarca()
        {
            InitializeComponent();
        }

        void limpaControles()
        {
            txtNome.Clear();
            txtPesquisa.Clear();
        }

        void carregarGrid(string pesquisa)
        {
            m = new Marca()
            {
                Nome = pesquisa
            };
            dgv_marcas.DataSource = m.Consultar();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty) return;
            m = new Marca()
            {
                Nome = txtNome.Text,
            };
            m.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_marcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_marcas.RowCount > 0)
            {
                txtNome.Text = dgv_marcas.CurrentRow.Cells["nome"].Value.ToString();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty) return;
            m = new Marca()
            {
                Nome = txtNome.Text,
            };
            m.Alterar();

            limpaControles();
            carregarGrid("");
        }
    }
}
