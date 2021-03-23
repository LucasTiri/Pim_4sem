using System.Collections.Generic;
using SQLite;
using Android.Util;
using CamadaMobileAndroid.Resources.modelo;

namespace CamadaMobileAndroid.Resources.DataBaseHelper
{
    public class dataBase
    {
        public class DataBase
        {
            string pasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            public bool CriarBancoDeDados()
            {
                try
                {
                    using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "dbAluno.db")))
                    {
                        conexao.CreateTable<aluno>();
                        return true;
                    }
                }
                catch (SQLiteException ex)
                {
                    Log.Info("SQLiteEx", ex.Message);
                    return false;
                }
            }
            public bool InserirAluno(aluno _aluno)
            {
                try
                {
                    using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "dbAluno.db")))
                    {
                        conexao.Insert(_aluno);
                        return true;
                    }
                }
                catch (SQLiteException ex)
                {
                    Log.Info("SQLiteEx", ex.Message);
                    return false;
                }
            }
            public List<aluno> GetAlunos()
            {
                try
                {
                    using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "dbAluno.db")))
                    {
                        return conexao.Table<aluno>().ToList();
                    }
                }
                catch (SQLiteException ex)
                {
                    Log.Info("SQLiteEx", ex.Message);
                    return null;
                }
            }
            public bool AtualizarAluno(aluno _aluno)
            {
                try
                {
                    using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "dbAluno.db")))
                    {
                        conexao.Query<aluno>("UPDATE aluno set Nome=?,Rg=?, Cpf=? Where Id=?", _aluno.Nome, _aluno.Rg, _aluno.Cpf, _aluno.Id);
                        return true;
                    }
                }
                catch (SQLiteException ex)
                {
                    Log.Info("SQLiteEx", ex.Message);
                    return false;
                }
            }
            public bool DeletarAluno(aluno _aluno)
            {
                try
                {
                    using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "dbAluno.db")))
                    {
                        conexao.Delete(_aluno);
                        return true;
                    }
                }
                catch (SQLiteException ex)
                {
                    Log.Info("SQLiteEx", ex.Message);
                    return false;
                }
            }
            public bool ConsultarAluno(int Id)
            {
                try
                {
                    using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "dbAluno.db")))
                    {
                        conexao.Query<aluno>("SELECT * FROM aluno Where Id=?", Id);                        
                        return true;
                    }
                }
                catch (SQLiteException ex)
                {
                    Log.Info("SQLiteEx", ex.Message);
                    return false;
                }
            }
        }
    }
}