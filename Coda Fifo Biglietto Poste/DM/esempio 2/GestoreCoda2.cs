using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coda_Fifo_Biglietto_Poste.DM
{
    internal class GestoreCoda2
    {
        public List<Biglietto2> Coda;
        private const int MaxElem = 100;//le costanti sono dei valori che non possono essere mai modificati nel tempo
        private int conta;
        public GestoreCoda2()
        {
            conta = 0;
            Coda = new List<Biglietto2>();
        }


        public bool Accoda(TipoBiglietto tb)
        {
            if (Coda.Count >= 100 ||tb==TipoBiglietto.None)
            {
                return false;
            }
            Coda.Append(new Biglietto2(tb,conta));
            conta++;
            return true;

        }
    }
}
