using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coda_Fifo_Biglietto_Poste.DM
{
    public abstract class BaseBiglietto
    {
        public abstract TipoBiglietto GetTipo();
        public abstract int GetNbiglietto();
        public abstract string Stampa2();
    }
}
