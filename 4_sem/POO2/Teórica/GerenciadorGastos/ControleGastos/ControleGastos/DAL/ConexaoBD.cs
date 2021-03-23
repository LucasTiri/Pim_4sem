using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.DAL
{
    class ConexaoBD
    {
        private static SqlConnection conexao;

        public ConexaoBD()
        {
            if(conexao == null)
            {
                conexao = new SqlConnection();
                conexao.ConnectionString = ConfigurationMenager.ConnectionStrings["localbd"].ConnectionString;
            }
        }

        public SqlConnection AbrirConexao() 
        {
            try
            {
                if(ConnectionState != ConnectionState.Open)
                {
                    conexao.Open();
                }
                return conexao;

            }catch(SqlException e)
            {
                Console.WriteLine("Error " + e);
            }
            return null;
        }
        public bool FecharConexao()
        {
            try
            {
                conexao.Close();
                return true;
            }
            catch(SqlException e)
            {
                Console.WriteLine("Erro ao fechar conexão" + e);
            }
            return false;
        }
    }
}
