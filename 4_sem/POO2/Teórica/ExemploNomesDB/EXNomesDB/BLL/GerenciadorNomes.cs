using EXNomesDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXNomesDB.BLL
{
    class GerenciadorNomes
    {
        private INomesDAO dao;

        public GerenciadorNomes()
        {
            dao = DAOFactory.CriarNomesDao();
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
