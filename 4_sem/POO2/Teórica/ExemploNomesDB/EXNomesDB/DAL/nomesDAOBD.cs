using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EXNomesDB.DAL
{
    class nomesDAOBD : INomesDAO
    {
        private ConexaoBD conexao;
        public nomesDAOBD()
        {
            conexao = new ConexaoBD();
        }
        public bool Inserir(string nome)
        {
            SqlConnection conn = conexao.AbrirConexao();
            if (conn != null)
            {
                SqlCommand comand = conn.CreateCommand();
                comand.CommandText = "INSERT INTO NOMES (NOME) VALUES (@nome)";
                comand.Parameters.AddWithValue("@nome", nome);
                comand.ExecuteNonQuery();
                conexao.FecharConexao();
                return true;
            }
            return false;
        }
        public List<string> Listar()
        {
            SqlConnection conn = conexao.AbrirConexao();
            if(conn!= null)
            {
                SqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT NOME FROM NOMES";
                SqlDataReader dados = command.ExecuteReader();
                List<string> nomes = new List<string>();
                while (dados.Read())
                {
                    string n = dados["nome"].ToString();
                    nomes.Add(n);
                }
                conexao.FecharConexao();
                return nomes;
            }
            return null;
        }
    }
}
