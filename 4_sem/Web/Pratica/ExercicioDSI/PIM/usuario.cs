using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace PIM
{
    public class usuario
    {
        #region Atributos
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        #endregion

        #region Control
        public int incluirUsuario(usuario _usuario)
        {
            string conexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\salat\Documents\Livros\Unip\PIM\dbUsuario.mdb";
            OleDbConnection conexaodb = new OleDbConnection(conexaoAccess);

            try
            {
                conexaodb.Open();

                string query = "INSERT INTO tbUsuario (firstName) VALUES (@firstName)";
                OleDbCommand cmd = new OleDbCommand(query, conexaodb);

                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@firstName";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _usuario.firstName;
                cmd.Parameters.Add(pmtNome);               

                if (cmd.ExecuteNonQuery() > 0)
                {
                    conexaodb.Close();
                    return 1;
                }
                else
                {
                    conexaodb.Close();
                    return 0;
                }

            }
            catch (Exception ex)
            {
                conexaodb.Close();
                throw new Exception("Erro ao cadastrar usuario: " + ex.Message);
            }
            finally
            {
                conexaodb.Close();
            }
        }
        public int alterarUsuario(usuario _usuario)
        {
            int retornoIncluir = 0;
            return retornoIncluir;
        }
        public int excluirUsuario(usuario _usuario)
        {
            int retornoIncluir = 0;
            return retornoIncluir;
        }
        public List<usuario> consultarUsuario(usuario _usuario)
        {
            List<usuario> _lstUsuario = new List<usuario>();
            return _lstUsuario;
        }
        #endregion           
    }
}
