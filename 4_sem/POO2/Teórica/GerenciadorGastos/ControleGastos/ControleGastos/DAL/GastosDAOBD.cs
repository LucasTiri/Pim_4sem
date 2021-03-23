using ControleGastos.DLL;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.DAL
{
    class GastosDAOBD : IGastosDAO
    {
        private ConexaoBD conexao;

        public GastosDAOBD()
        {
            conexao = new ConexaoBD();
        }

        public bool Atualizar(Gasto gasto)
        {

            SqlConnection conn = conexao.AbrirConexao();
            if(conn != null)
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE GASTOS SET DATA = @data, VALOR = @valor, DESCRICAO = @descricao WHERE ID=@id";
                cmd.Parameters.AddWithValue("@id",gasto.Id);
                cmd.Parameters.AddWithValue("@data",gasto.Data);
                cmd.Parameters.AddWithValue("@valor",gasto.Valor);
                cmd.Parameters.AddWithValue("@descricao",gasto.Descricao);
                cmd.ExecuteNonQuery();
                conexao.FecharConexao();
                return true;
            }
            return false;
        }

        public bool Excluir(int id)
        {
            SqlConnection conn = conexao.AbrirConexao();
            if(conn != null)
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM GASTOS WHERE ID=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conexao.FecharConexao();
                return true;
            }
            return false;
        }

        public bool Inserir(Gasto gasto)
        {
            SqlConnection conn = conexao.AbrirConexao();
            if(conn!= null)
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO GASTOS(DATA, VALOR, DESCRICAO)" + "VALUES(@data,@valor,@descricao)";
                cmd.Parameters.AddWithValue("@data", gasto.Data);
                cmd.Parameters.AddWithValue("@valor", gasto.Valor);
                cmd.Parameters.AddWithValue("@descricao", gasto.Descricao);
                cmd.ExecuteNonQuery();
                conexao.FecharConexao();
                return true;
            }
            return false;
            //throw new NotImplementedException();
        }

        public DataSet ListarPorMesAno(int mes, int ano)
        {
            throw new NotImplementedException();
        }

        public DataSet ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
