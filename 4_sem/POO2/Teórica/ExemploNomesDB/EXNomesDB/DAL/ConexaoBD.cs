using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EXNomesDB.DAL
{
    class ConexaoBD
    {
        private static SqlConnection Conexao;
        public ConexaoBD()
        {
            if (Conexao == null)
            {
                Conexao = new SqlConnection();
                //Conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|;Integrated Security=True";
                Conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\T-Gamer\Desktop\CORONA\4_sem\POO2\Teórica\ExemploNomesDB\EXNomesDB\nomes.mdf;Integrated Security=True";
            }
        }
        public SqlConnection AbrirConexao()
            {
                try
                {
                    if (Conexao.State != ConnectionState.Open)
                    {
                        Conexao.Open();
                    }
                    return Conexao;

                }
                catch (SqlException e)
                {
                    Console.WriteLine("Erro de conexao" + e.Message);
                }
                return null;
            }
        public bool FecharConexao()
            {
                try
                {
                    Conexao.Close();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Erro ao fechar a conexao" + e.Message);
                }
                return false;
            }
        }
    }

