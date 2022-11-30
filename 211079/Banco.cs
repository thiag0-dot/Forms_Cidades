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

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Cliente (" +
                                          " id INT AUTO_INCREMENT," +
                                          " id_cidade INT," +
                                          " nome VARCHAR(150)," +
                                          " data_nasc DATE," +
                                          " renda DOUBLE," +
                                          " cpf CHAR(11)," +
                                          " foto VARCHAR(150)," +
                                          " venda BOOLEAN," +
                                          " PRIMARY KEY (id)," +
                                          " FOREIGN KEY (id_cidade) REFERENCES Cidades(id));", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Categoria (" +
                                          " id INT AUTO_INCREMENT," +
                                          " descricao VARCHAR(150)," +
                                          " PRIMARY KEY (id));", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Produto(" +
                                          "id int auto_increment, " +
                                          "descricao varchar(100), " +
                                          "id_categoria int, " +
                                          "id_marca int, " +
                                          "estoque int," +
                                          "foto varchar(100)," +
                                          "valor decimal(10, 2),"
                                           + "primary key(id)); ", Conexao);

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
