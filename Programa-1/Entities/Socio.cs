
namespace Programa_1.Entities
{
   public class Socio
    {
        private string nombre;
        private int antigüedad;

        public Socio(string nombre, int antigüedad)
        {
            this.nombre = nombre;
            this.antigüedad = antigüedad;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetAntigüedad()
        {
            return antigüedad;
        }
    }
}
