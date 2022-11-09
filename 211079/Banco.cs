using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _211079
{
    internal class Banco
    {
        //Criando uma conexao com o banco de dados
        public static MySqlConnection Conexao;

        //Insere os comandos no mysql
        public static MySqlCommand Comando;

        public static MySqlDataAdapter Adaptador;

        public static DataTable DatTable;

        public static void AbrirConexao()
        {
            try
            {
                //Abrindo uma conexao com o mysql
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");

                Conexao.Open();
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                //Fechando a conexao
                Conexao.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.StackTrace, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CriandoBanco()
        {
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Cidades" +
                                           "(id INTEGER AUTO_INCREMENT PRIMARY KEY," +
                                           "nome VARCHAR(40)," +
                                           "uf CHAR(2))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Marcas" +
                                           "(id INTEGER AUTO_INCREMENT PRIMARY KEY," +
                                           "nome VARCHAR(40))", Conexao);
                Comando.ExecuteNonQuery();

                FecharConexao();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
