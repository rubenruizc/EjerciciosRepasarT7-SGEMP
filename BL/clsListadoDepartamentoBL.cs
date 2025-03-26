using ENT;

namespace BL
{
    public class clsListadoDepartamentoBL
    {
        public static List<clsDepartamento> obtenerDepartamentosBL()
        {
            return DAL.clsListadoDepartamentosDAL.obtenerDepartamentos();   
        }
    }
}
