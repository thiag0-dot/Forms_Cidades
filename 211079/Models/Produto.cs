using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _211079.Models
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Estoque { get; set; }
        public int Id_Categoria { get; set; }
        public int Id_Marca { get; set; }
        public string Foto { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("INSERT INTO Produto (descricao, valor, estoque,  id_categoria, id_marca, foto) VALUES (@descricao, @valor, @estoque, @id_categoria, @id_marca, @foto)", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@descricao", Descricao);
                Banco.Comando.Parameters.AddWithValue("@valor", Valor);
                Banco.Comando.Parameters.AddWithValue("@estoque", Estoque);
                Banco.Comando.Parameters.AddWithValue("@id_categoria", Id_Categoria);
                Banco.Comando.Parameters.AddWithValue("@id_marca", Id_Marca);
                Banco.Comando.Parameters.AddWithValue("@foto", Foto);

                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Alterar()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("UPDATE Produto SET descricao = @descricao, valor = @valor, estoque = @estoque, id_categoria = @id_categoria, id_marca = @id_marca, foto = @foto WHERE id = @id", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@descricao", Descricao);
                Banco.Comando.Parameters.AddWithValue("@valor", Valor);
                Banco.Comando.Parameters.AddWithValue("@estoque", Estoque);
                Banco.Comando.Parameters.AddWithValue("@id_categoria", Id_Categoria);
                Banco.Comando.Parameters.AddWithValue("@id_marca", Id_Marca);
                Banco.Comando.Parameters.AddWithValue("@foto", Foto);
                Banco.Comando.Parameters.AddWithValue("@id", Id);

                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Excluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("DELETE FROM Produto WHERE id = @id", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", Id);

                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("SELECT p.*, m.descricao_marca, c.descricao_categoria FROM Produto p JOIN Categoria c on (c.id = p.id_categoria) JOIN Marca m on (m.id = p.id_marca) WHERE p.descricao LIKE @descricao ORDER BY p.descricao", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@descricao", "%" + Descricao + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.DatTable = new DataTable();
                Banco.Adaptador.Fill(Banco.DatTable);
                Banco.FecharConexao();

                return Banco.DatTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
