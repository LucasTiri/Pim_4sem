using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXNomesDB.DAL
{
    interface INomesDAO
    {
        bool Inserir(string nome);
        List<string> Listar();
    }
}
