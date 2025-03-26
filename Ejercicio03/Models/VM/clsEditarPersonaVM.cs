using BL;
using ENT;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio04.Models.VM
{
    public class clsEditarPersonaVM : clsPersona
    {
        public List<clsDepartamento> Departamentos { get; }

        // Llenar el listado de departamentos al iniciar el ViewModel
        public clsEditarPersonaVM(clsPersona persona) : base(persona.Nombre,persona.Apellido,persona.IdDepartamento) {

            Departamentos = clsListadoDepartamentoBL.obtenerDepartamentosBL();

        }


    }
}
