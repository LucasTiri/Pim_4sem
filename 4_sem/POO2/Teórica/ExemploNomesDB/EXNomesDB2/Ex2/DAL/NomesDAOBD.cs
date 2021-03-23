using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ex2.DAL
{
    class NomesDAOBD : INomesDAO
    {
        private ConexaoBD conexao;

        public NomesDAOBD()
        {
            conexao = new ConexaoBD();
        }

        public bool Inserir(string nome)
        {
            SqlConnection conn = conexao.AbrirConexao();
            if (conn != null)
            {
                // cria um objeto SqlCommand para executar a instrução no banco de dados
                SqlCommand cmd = conn.CreateCommand();
                // adiciona o comando SQL a ser executado
                cmd.CommandText = "INSERT INTO NOMES (NOME) VALUES (@nome)";
                // adiciona o valor do parametro
                cmd.Parameters.AddWithValue("@nome", nome);
                // executa o comando e fecha a conexao
                cmd.ExecuteNonQuery();
                conexao.FecharConexao();
                return true;
            }
            return false;
        }

        public List<string> Listar()
        {
            SqlConnection conn = conexao.AbrirConexao();
            if (conn != null)
            {
                // cria um objeto SqlCommand para executar a instrução no banco de dados
                SqlCommand cmd = conn.CreateCommand();
                // adiciona o comando SQL a ser executado
                cmd.CommandText = "SELECT NOME FROM NOMES";
                // executa o comando SQL e obtém os dados
                SqlDataReader dados = cmd.ExecuteReader();
                // cria uma lista de string a partir dos dados retornados
                List<string> nomes = new List<string>();
                while (dados.Read())
                {
                    // obtem os dados da linha atual e adiciona na lista
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
