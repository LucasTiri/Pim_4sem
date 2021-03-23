using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Ex2.DAL;

namespace Ex2.BLL
{
    class GerenciadorNomes
    {
        private INomesDAO dao;

        public GerenciadorNomes()
        {
            dao = DAOFactory.CriarNomesDAO();
        }

        public bool Inserir(string nome)
        {
            return dao.Inserir(nome);
        }

        public List<string> Listar()
        {
            return dao.Listar();
        }
    }
}
