using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211079.Models
{
    internal class Marca
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                //Fazendo o insert no banco na tabela de cidades
                Banco.Comando = new MySqlCommand("INSERT INTO Marcas (nome) VALUES (@nome)", Banco.Conexao);
                //Criando os parâmetros
                Banco.Comando.Parameters.AddWithValue("@nome", Nome);
                //Executando o Comando
                Banco.Comando.ExecuteNonQuery();
                //Fecha a conexão
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Excluir()
        {
            try
            {
                Banco.AbrirConexao();
                //Fazendo o delete no banco na tabela de cidades
                Banco.Comando = new MySqlCommand("DELETE FROM Marcas WHERE id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", Id);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Alterar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("Update Marcas SET nome = @nome where id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", Nome);
                Banco.Comando.Parameters.AddWithValue("@id", Id);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("SELECT * FROM Marcas WHERE nome LIKE @nome" +
                    " ORDER BY nome", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", Nome + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.DatTable = new DataTable();
                Banco.Adaptador.Fill(Banco.DatTable);
                Banco.FecharConexao();
                return Banco.DatTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
