using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class clsListadoPersonasBL
    {

        public static List<clsPersona> obtenerPersonasBL()
        {
            return DAL.clsListadoPersonasDAL.obtenerPersonas();
        }

        public static clsPersona obtenerPersonaRandomBL()
        {
            return DAL.clsListadoPersonasDAL.obtenerPersonaRandom();
        }

    }
}
