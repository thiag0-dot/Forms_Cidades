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
    public partial class FormClientes : Form
    {
        Cidade ci;
        Cliente cl;

        public FormClientes()
        {
            InitializeComponent();
        }

        public void limpaControles()
        {
            txtNome.Clear();
            cboCidades.SelectedIndex = -1;
            txtUF.Clear();
            mskCPF.Clear();
            txtRenda.Clear();
            dtpDataNasc.Value = DateTime.Now;
            picFoto.ImageLocation = "";
            chkVenda.Checked = false;
        }

        public void carregarGrid(string pesquisa)
        {
            cl = new Cliente()
            {
                nome = pesquisa
            };

            dgv_clientes.DataSource = cl.Consultar();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            ci = new Cidade();
            cboCidades.DataSource = ci.Consultar();
            cboCidades.DisplayMember = "nome";
            cboCidades.ValueMember = "id";

            limpaControles();
            carregarGrid("");

            dgv_clientes.Columns["id_cidade"].Visible = false;
            dgv_clientes.Columns["foto"].Visible = false;
        }

        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_clientes.RowCount > 0)
            {
                txtNome.Text = dgv_clientes.CurrentRow.Cells["nome"].Value.ToString();
                cboCidades.Text = dgv_clientes.CurrentRow.Cells["cidade"].Value.ToString();
                txtUF.Text = dgv_clientes.CurrentRow.Cells["uf"].Value.ToString();
                chkVenda.Checked = (bool)dgv_clientes.CurrentRow.Cells["venda"].Value;
                mskCPF.Text = dgv_clientes.CurrentRow.Cells["cpf"].Value.ToString();
                dtpDataNasc.Text = dgv_clientes.CurrentRow.Cells["data_nasc"].Value.ToString();
                txtRenda.Text = dgv_clientes.CurrentRow.Cells["renda"].Value.ToString();
                picFoto.ImageLocation = dgv_clientes.CurrentRow.Cells["foto"].Value.ToString();
            }
        }

        private void cboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCidades.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCidades.SelectedItem;
                txtUF.Text = reg["uf"].ToString();
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "C:/Users/Usuario/source/repos/Forms_Cidades/Images";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty) return;

            cl = new Cliente()

            {
                id_cidade = (int)cboCidades.SelectedValue,
                nome = txtNome.Text,
                data_nasc = dtpDataNasc.Value,
                renda = double.Parse(txtRenda.Text),
                cpf = mskCPF.Text,
                foto = picFoto.ImageLocation,
                venda = chkVenda.Checked
            };

            cl.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string a;
            a = dgv_clientes.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja alterar o cadastro?", "alterar", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes) return;
            {
                cl = new Cliente()
                {
                    id = int.Parse(a),
                    id_cidade = (int)cboCidades.SelectedValue,
                    nome = txtNome.Text,
                    data_nasc = dtpDataNasc.Value,
                    renda = double.Parse(txtRenda.Text),
                    cpf = mskCPF.Text,
                    foto = picFoto.ImageLocation,
                    venda = chkVenda.Checked
                };
                cl.Alterar();

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
            a = dgv_clientes.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja excluir o cadastro?", "Exclusão", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cl = new Cliente()
                {
                    id = int.Parse(a)
                };

                cl.Excluir();

                limpaControles();
                carregarGrid("");
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
