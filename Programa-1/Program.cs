using Programa_1.Entities;


namespace Programa_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Socio socio1 = new Socio("Rosa Pérez", 7);
            Socio socio2 = new Socio("Raquel Fantino", 22);
            Socio socio3 = new Socio("Roque Sosa", 34);

            Club club = new Club(socio1, socio2, socio3);
            club.ImprimirAntiguedad();
        }
    }
}
