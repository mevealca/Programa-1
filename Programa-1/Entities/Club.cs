using System;

namespace Programa_1.Entities
{
    public class Club
    {
        private Socio socio1;
        private Socio socio2;
        private Socio socio3;

        public Club(Socio socio1, Socio socio2, Socio socio3)
        {
            this.socio1 = socio1;
            this.socio2 = socio2;
            this.socio3 = socio3;
        }

        public void ImprimirAntiguedad()
        {
            Socio mayorAntiguedad = socio1;

            if (socio2.GetAntigüedad() > mayorAntiguedad.GetAntigüedad())
            {
                mayorAntiguedad = socio2;
            }
            if (socio3.GetAntigüedad() > mayorAntiguedad.GetAntigüedad())
            {
                mayorAntiguedad = socio3;
            }

            Console.WriteLine("El socio con mayor antigüedad es: " + mayorAntiguedad.GetNombre());
        }
    }
}
