using ENT;

namespace DAL
{
    public class clsListadoPersonasDAL
    {

        private static List<clsPersona> personas = new List<clsPersona>
        {
            new clsPersona(1,"Rubén","Ruiz"),
            new clsPersona(2,"Max","Ruiz"),
            new clsPersona(3,"Amaro","Suarez"),
            new clsPersona(4,"Jenri","Muñoz"),
        };

        private static List<clsPersona> personasDept = new List<clsPersona>
    {
        new clsPersona ("Rubén","Ruiz",1),
        new clsPersona ("Amaro","Suarez",2),
        new clsPersona ("Jenri","Muñoz",3),
    };


        public static List<clsPersona> obtenerPersonas()
        {
            return personas;
        }

        public static clsPersona obtenerPersonaRandom()
        {
            Random r = new Random();

            int posicion = r.Next(personas.Count);

            return personasDept[posicion];
        }

    }
}
