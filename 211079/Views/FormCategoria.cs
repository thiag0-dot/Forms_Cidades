using _211079.Models;
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
    public partial class FormCategoria : Form
    {
        Categoria c;
        public FormCategoria()
        {
            InitializeComponent();
        }
        public void limpaControles()
        {
            txtdescricao.Clear();
            txtPesquisa.Clear();
        }

        public void carregarGrid(string pesquisa)
        {
            c = new Categoria()
            {
                descricao = pesquisa
            };

            dgv_categoria.DataSource = c.Consultar();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (txtdescricao.Text == String.Empty) return;

            c = new Categoria()

            {
                descricao = txtdescricao.Text,
            };

            c.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string a;
            a = dgv_categoria.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            c = new Categoria()
            {
                id = int.Parse(a),
                descricao = txtdescricao.Text,
            };

            c.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string a;
            a = dgv_categoria.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja excluir o cadastro?", "Exclusão", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Categoria()
                {
                    id = int.Parse(a)
                };

                c.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void dgv_categoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_categoria.RowCount > 0)
            {
                txtdescricao.Text = dgv_categoria.CurrentRow.Cells["descricao"].Value.ToString();
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
