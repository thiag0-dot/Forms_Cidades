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
    public partial class FormCidades : Form
    {
        Cidade c;
        public FormCidades()
        {
            InitializeComponent();
        }

        void limpaControles()
        {
            txtNome.Clear();
            txtUF.Clear();
            txtPesquisa.Clear();
        }

        void carregarGrid(string pesquisa)
        {
            c = new Cidade()
            {
                Nome = pesquisa
            };
            dgv_cidades.DataSource = c.Consultar();
        }

        private void FormCidades_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgv_cidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_cidades.RowCount > 0)
            {
                txtNome.Text = dgv_cidades.CurrentRow.Cells["nome"].Value.ToString();
                txtUF.Text = dgv_cidades.CurrentRow.Cells["uf"].Value.ToString();
            }
        }

        private void btn_iniciar_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty) return;
            c = new Cidade()
            {
                Nome = txtNome.Text,
                Uf = txtUF.Text
            };
            c.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string a;
            a = dgv_cidades.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja alterar o cadastro?", "alterar", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Cidade()
                {
                    Id = int.Parse(a),
                    Nome = txtNome.Text,
                    Uf = txtUF.Text
                };

                c.Alterar();

                limpaControles();
                carregarGrid("");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string a;
            a = dgv_cidades.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja excluir o cadastro?", "Exclusão", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Cidade()
                {
                    Id = int.Parse(a)
                };

                c.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void FormCidades_Load_1(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void dgv_cidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
