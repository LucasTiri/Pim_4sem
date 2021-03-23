using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ex2.DAL
{
    class ConexaoBD
    {
        // objeto de conexao com o banco de dados
        private static SqlConnection conexao;

        // construtor da classe
        public ConexaoBD()
        {
            if (conexao == null)
            {
                conexao = new SqlConnection();
                // string de conexao com o banco de dados
                conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Nomes.mdf;Integrated Security=True";
            }
        }

        // método responsável por abrir a conexao com o banco de dados
        public SqlConnection AbrirConexao()
        {
            try
            {
                if (conexao.State != ConnectionState.Open)
                {
                    conexao.Open();
                }
                return conexao;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Erro de conexao: " + e.Message);
            }
            return null;
        }

        // método responsável por fechar a conexao com o banco de dados
        public bool FecharConexao()
        {
            try
            {
                conexao.Close();
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Erro ao fechar a conexao: " + e.Message);
            }
            return false;
        }
    }
}
