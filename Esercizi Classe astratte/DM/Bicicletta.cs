using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_Classe_astratte.DM
{
    internal class Bicicletta:Veicolo
    {
        public int nruote = 2;

        //come fare a usare il costruttore della classe padre senza dareparametri.
        //se volessi creare una bici non dando parametri di ingresso perche esiste il costruttore veicolo ceh setta tutto a 0 quando 
        //non ci sono parametri di ingresso.
        public Bicicletta(double velo, double accelle):base(velo,accelle)
        {
            velo = 0;
            accelle = 0;

        }
        public void pedala(int numeropedalate, int secondi)
        {
            double acc = numeropedalate / System.Math.Pow(2,2);
            this.Setaccellera(acc);
            double velox = Getvelocità() + (Getaccellerazione() * secondi);
            Setvelocità(velox);
        }

        public int GetNRuote()
        {
            return this.nruote;
        }

        public override void Stampanruote()
        {
            Console.WriteLine(GetNRuote());
        }
    }
}
