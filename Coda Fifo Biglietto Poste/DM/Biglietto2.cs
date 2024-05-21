using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coda_Fifo_Biglietto_Poste.DM
{
    
    public class Biglietto2
    {

       
        private int nBiglietto;
        private TipoBiglietto Tiplologia;
        private DateTime OrarioIngresso;
     
        public Biglietto2(TipoBiglietto tb, int conta)
        {
            nBiglietto = conta;
            Tiplologia = tb;
            OrarioIngresso = DateTime.UtcNow;
        }

        public override string ToString()
        {
            return $"Hai il biglietto n° {nBiglietto}, Staccato alle {OrarioIngresso}, di tipo {Tiplologia}";
        }

    }
}
