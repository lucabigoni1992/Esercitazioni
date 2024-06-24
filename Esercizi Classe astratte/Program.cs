using Esercizi_Classe_astratte.DM;

namespace Esercizi_Classe_astratte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio di vincenzo-Classi Astratte");
            Automobile a=new Automobile("ge900tp",0,0);
            Bicicletta b = new Bicicletta(0,0);
            a.Avvia();

            a.Accellera(2.5, 5);
            b.pedala(60, 2);
            //X LUCA--------- PERCHE NON RIESCO AD INTERPOLARE ?
            //Console.WriteLine($"LA VELOCITà DELLA AUTOMOBILE ={ Veicolo.StampaVelocità(a)}"); 
            Console.Write("LA VELOCITA DELL'AUTOMOBILE =");Veicolo.StampaVelocità(a);
            Console.Write("LA VELOCITA DELLA BICICLETTA ="); Veicolo.StampaVelocità(b);

            Console.Write($"LE RUOTE DELL'AUTOMOBILE SONO="); a.Stampanruote();
            Console.Write($"LE RUOTE DELLa BICICLETTA SONO="); b.Stampanruote();

            Console.ReadLine();

        }
    }
}
