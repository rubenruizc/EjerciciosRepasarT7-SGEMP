using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class clsDepartamento
    {
        #region Atributos

        private int idDepartamento;

        private string nombreDepartamento;
        #endregion

        #region Propiedades

        public int IdDepartamento { 
            get 
            { 
                return idDepartamento; 
            }
            set 
            { 
                if(value > 0)
                {
                    idDepartamento = value;
                }
            }
        }

        public string NombreDepartamento 
        { 
            get 
            { 
                return nombreDepartamento; 
            } 
            set 
            {
                if (!String.IsNullOrEmpty(value))
                {
                    nombreDepartamento = value;
                }
            } 
        }
        #endregion

        #region Constructores
        public clsDepartamento() { }

        public clsDepartamento(int idDepartamento,string nombreDepartamento)
        {
            this.idDepartamento=idDepartamento;
            this.nombreDepartamento = nombreDepartamento;
        }
        #endregion

    }
}
