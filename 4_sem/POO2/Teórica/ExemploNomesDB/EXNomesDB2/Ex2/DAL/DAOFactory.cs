using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.DAL
{
    class DAOFactory
    {
        public static INomesDAO CriarNomesDAO()
        {
            return new NomesDAOBD();
        }
    }
}
