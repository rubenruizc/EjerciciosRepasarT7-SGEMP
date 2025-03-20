namespace ENT
{
    public class clsPersona
    {
        #region Atributos
        private int id;

        private string nombre;

        private string apellido;

        private int idDepartamento;
        #endregion

        #region Propiedades 
        public int Id 
        { 
            get
            {
                return id;
            } 
            set
            {
                if(value > 0)
                {
                    id = value;
                }
                
            }
        } 

        public string Nombre 
        { 
            get 
            { 
                return nombre; 
            } 
            set 
            {
                if (!String.IsNullOrEmpty(value))
                {
                    nombre = value;

                }
            } 
        }

        public string Apellido 
        { 
            get 
            { 
                return apellido; 
            } 
            set 
            {
                if (!String.IsNullOrEmpty(value))
                {
                    apellido = value;
                }
            } 
        }

        public int IdDepartamento
        {
            get
            {
                return idDepartamento;
            }
            set
            {
                if (value > 0)
                {
                    idDepartamento = value;
                }
            }
        }
        #endregion

        #region Constructores
        public clsPersona() { }

        public clsPersona(int id,string nombre,string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public clsPersona(string nombre,string apellido, int idDepartamento)
        {
            
            this.nombre = nombre;
            this.apellido=apellido;
            this.idDepartamento = idDepartamento;
        }
        #endregion
    }
}
