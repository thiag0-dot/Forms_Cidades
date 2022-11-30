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
using _211079.Models;

namespace _211079.Views
{
    public partial class FormProduto : Form
    {
        Produto P;
        Categoria C;
        Marca M;
        public FormProduto()
        {
            InitializeComponent();
        }
        void limpaControles()
        {
            txtdescricao.Clear();
            txtvalorvenda.Clear();
            txtestoque.Clear();
            cboCategoria.SelectedIndex = -1;
            cboMarca.SelectedIndex = -1;
            picFoto.ImageLocation = "";
            txtPesquisa.Clear(); ;
        }

        void carregarGrid(string pesquisa)
        {
            P = new Produto()
            {
                Descricao = pesquisa
            };

            dgv_Produtos.DataSource = P.Consultar();
        }


        private void FormProduto_Load(object sender, EventArgs e)
        {
            C = new Categoria();
            cboCategoria.DataSource = C.Consultar();
            cboCategoria.DisplayMember = "descricao_categoria";
            cboCategoria.ValueMember = "id";

            M = new Marca();
            cboMarca.DataSource = M.Consultar();
            cboMarca.DisplayMember = "descricao_marca";
            cboMarca.ValueMember = "id";
        }

        private void dgv_Produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdescricao.Text = dgv_Produtos.CurrentRow.Cells["descricao"].Value.ToString();
            txtvalorvenda.Text = dgv_Produtos.CurrentRow.Cells["valor"].Value.ToString();
            txtestoque.Text = dgv_Produtos.CurrentRow.Cells["estoque"].Value.ToString();
            cboCategoria.Text = dgv_Produtos.CurrentRow.Cells["descricao_categoria"].Value.ToString();
            cboMarca.Text = dgv_Produtos.CurrentRow.Cells["descricao_marca"].Value.ToString();
            picFoto.ImageLocation = dgv_Produtos.CurrentRow.Cells["foto"].Value.ToString();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (txtdescricao.Text == String.Empty)
                return;

            P = new Produto
            {
                Descricao = txtdescricao.Text,
                Valor = double.Parse(txtvalorvenda.Text),
                Estoque = int.Parse(txtestoque.Text),
                Foto = picFoto.ImageLocation,
                Id_Marca = (int)cboMarca.SelectedValue,
                Id_Categoria = (int)cboCategoria.SelectedValue
            };

            P.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string a;
            a = dgv_Produtos.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja alterar o cadastro?", "alterar", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                P = new Produto
                {
                    Descricao = txtdescricao.Text,
                    Valor = double.Parse(txtvalorvenda.Text),
                    Estoque = int.Parse(txtestoque.Text),
                    Foto = picFoto.ImageLocation,
                    Id_Marca = (int)cboMarca.SelectedValue,
                    Id_Categoria = (int)cboCategoria.SelectedValue
                };
            }

            P.Alterar();

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
            a = dgv_Produtos.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja excluir o cadastro?", "Exclusão", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                P = new Produto()
                {
                    Id = int.Parse(a)
                };

                P.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }
    }
}
