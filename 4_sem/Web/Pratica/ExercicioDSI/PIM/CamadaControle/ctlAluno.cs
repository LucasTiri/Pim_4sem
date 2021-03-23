using CamadaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace CamadaControle
{
    public class ctlAluno
    {
        public bool Cadastrar(mdlAluno _mdlAluno)
        {
            string conexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\salat\Documents\dbAlunoCID.mdb";
            OleDbConnection conexaodb = new OleDbConnection(conexaoAccess);

            try
            {                
                conexaodb.Open();

                string query = "INSERT INTO tbAluno (nome, rg, cpf) VALUES (@Nome, @Rg, @Cpf)";
                OleDbCommand cmd = new OleDbCommand(query, conexaodb);

                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@Nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _mdlAluno.nome;
                cmd.Parameters.Add(pmtNome);

                var pmtRg = cmd.CreateParameter();
                pmtRg.ParameterName = "@Rg";
                pmtRg.DbType = DbType.String;
                pmtRg.Value = _mdlAluno.rg;
                cmd.Parameters.Add(pmtRg);

                var pmtCpf = cmd.CreateParameter();
                pmtCpf.ParameterName = "@Cpf";
                pmtCpf.DbType = DbType.String;
                pmtCpf.Value = _mdlAluno.cpf;
                cmd.Parameters.Add(pmtCpf);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    conexaodb.Close();
                    return true;
                }
                else
                {
                    conexaodb.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                conexaodb.Close();
                throw new Exception("Erro ao cadastrar aluno: " + ex.Message);
            }
            finally
            {
                conexaodb.Close();
            }            
        }
        public bool Alterar(mdlAluno _mdlAluno)
        {
            string conexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\salat\Documents\Livros\Unip\PIM\dbAluno.mdb";
            OleDbConnection conexaodb = new OleDbConnection(conexaoAccess);

            try
            {
                conexaodb.Open();

                string query = "UPDATE tbAluno set nome = @nome where cpf = @cpf";
                OleDbCommand cmd = new OleDbCommand(query, conexaodb);

                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@Nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _mdlAluno.nome;
                cmd.Parameters.Add(pmtNome);
                                
                var pmtCpf = cmd.CreateParameter();
                pmtCpf.ParameterName = "@Cpf";
                pmtCpf.DbType = DbType.String;
                pmtCpf.Value = _mdlAluno.cpf;
                cmd.Parameters.Add(pmtCpf);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    conexaodb.Close();
                    return true;
                }
                else
                {
                    conexaodb.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conexaodb.Close();
                throw new Exception("Erro ao alterar aluno: " + ex.Message);
            }
            finally
            {
                conexaodb.Close();
            }
        }
        public bool Excluir(mdlAluno _mdlAluno)
        {
            string conexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\salat\Documents\Livros\Unip\PIM\dbAluno.mdb";
            OleDbConnection conexaodb = new OleDbConnection(conexaoAccess);

            try
            {
                conexaodb.Open();

                string query = "DELETE FROM tbAluno where cpf = @cpf";
                OleDbCommand cmd = new OleDbCommand(query, conexaodb);
                
                var pmtCpf = cmd.CreateParameter();
                pmtCpf.ParameterName = "@Cpf";
                pmtCpf.DbType = DbType.String;
                pmtCpf.Value = _mdlAluno.cpf;
                cmd.Parameters.Add(pmtCpf);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    conexaodb.Close();
                    return true;
                }
                else
                {
                    conexaodb.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conexaodb.Close();
                throw new Exception("Erro ao excluir aluno: " + ex.Message);
            }
            finally
            {
                conexaodb.Close();
            }
        }
        public List<mdlAluno> Consultar(mdlAluno _mdlAluno)
        {
            string conexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\salat\Documents\Livros\Unip\PIM\dbAluno.mdb";
            OleDbConnection conexaodb = new OleDbConnection(conexaoAccess);
            List<mdlAluno> _lstmdlAluno = new List<mdlAluno>();
            try
            {
                conexaodb.Open();

                string query = "SELECT * FROM tbAluno WITH(NOLOCK) WHERE cpf = @cpf";
                OleDbCommand cmd = new OleDbCommand(query, conexaodb);

                var pmtCpf = cmd.CreateParameter();
                pmtCpf.ParameterName = "@Cpf";
                pmtCpf.DbType = DbType.String;
                pmtCpf.Value = _mdlAluno.cpf;
                cmd.Parameters.Add(pmtCpf);

                OleDbDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    _mdlAluno.nome = rd.GetString(1);
                    _mdlAluno.rg = rd.GetString(2);
                    _mdlAluno.cpf = rd.GetString(3);
                    _lstmdlAluno.Add(_mdlAluno);
                }
                return _lstmdlAluno;
                
            }
            catch (Exception ex)
            {
                conexaodb.Close();
                throw new Exception("Erro ao consultar dados do aluno: " + ex.Message);
            }
            finally
            {
                conexaodb.Close();
            }
        }
        public List<mdlAluno> ConsultarTodosAluno()
        {
            string conexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\salat\Documents\Livros\Unip\PIM\dbAluno.mdb";
            OleDbConnection conexaodb = new OleDbConnection(conexaoAccess);
            List<mdlAluno> _lstmdlAluno = new List<mdlAluno>();
            mdlAluno _mdlAluno = new mdlAluno();

            try
            {
                conexaodb.Open();

                string query = "SELECT * FROM tbAluno";
                OleDbCommand cmd = new OleDbCommand(query, conexaodb);

                var pmtCpf = cmd.CreateParameter();
                pmtCpf.ParameterName = "@Cpf";
                pmtCpf.DbType = DbType.String;
                pmtCpf.Value = _mdlAluno.cpf;
                cmd.Parameters.Add(pmtCpf);

                OleDbDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    _mdlAluno.nome = rd.GetString(1);
                    _mdlAluno.rg = rd.GetString(2);
                    _mdlAluno.cpf = rd.GetString(3);
                    _lstmdlAluno.Add(_mdlAluno);
                }
                return _lstmdlAluno;

            }
            catch (Exception ex)
            {
                conexaodb.Close();
                throw new Exception("Erro ao consultar dados do aluno: " + ex.Message);
            }
            finally
            {
                conexaodb.Close();
            }
        }
    }    
}
