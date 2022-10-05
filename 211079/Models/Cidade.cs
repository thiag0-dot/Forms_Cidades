using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace _211079.Models
{
    internal class Cidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Uf { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                //Fazendo o insert no banco na tabela de cidades
                Banco.Comando = new MySqlCommand("INSERT INTO cidades (nome, uf) VALUES (@nome, @uf)", Banco.Conexao);
                //Criando os parâmetros
                Banco.Comando.Parameters.AddWithValue("@nome", Nome);
                Banco.Comando.Parameters.AddWithValue("@uf", Uf);
                //Executando o Comando
                Banco.Comando.ExecuteNonQuery();
                //Fecha a conexão
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
