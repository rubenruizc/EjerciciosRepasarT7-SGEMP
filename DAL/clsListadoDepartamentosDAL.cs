using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsListadoDepartamentosDAL
    {
        private static List<clsDepartamento> departamentos = new List<clsDepartamento>
        {
            new clsDepartamento (1,"BETIS"),
            new clsDepartamento (2,"SEVILLA"),
            new clsDepartamento (3,"BARSA"),
            new clsDepartamento (4,"MADRID"),
        };

        public static List<clsDepartamento> obtenerDepartamentos()
        {
            return departamentos;
        }
    }
}
