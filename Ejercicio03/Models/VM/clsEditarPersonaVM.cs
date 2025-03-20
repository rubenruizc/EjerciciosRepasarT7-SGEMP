using DAL;
using ENT;

namespace Ejercicio04.Models.VM
{
    public class clsEditarPersonaVM : clsPersona
    {
        private List<clsDepartamento> departamentos;

        public List<clsDepartamento> Departamentos { get; set; }

        // Llenar el listado de departamentos al iniciar el ViewModel
        public clsEditarPersonaVM() {

            Departamentos = clsListadoDepartamentosDAL.obtenerDepartamentos();
        }


    }
}
