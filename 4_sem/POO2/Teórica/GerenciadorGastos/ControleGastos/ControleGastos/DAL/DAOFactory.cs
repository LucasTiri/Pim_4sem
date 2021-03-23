using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.DAL
{
    class DAOFactory
    {
        public static IGastosDAO CriarGastosDao()
        {
            return new GastosDAOBD();
        }
    }
}
