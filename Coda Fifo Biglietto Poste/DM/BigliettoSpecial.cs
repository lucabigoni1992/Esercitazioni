using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coda_Fifo_Biglietto_Poste.DM
{
    internal class BigliettoSpecial : Biglietto
    { //le variabili di tipo static sono condivise tra  le varie istanze della classe quindi se una la modifica, è modificata per tutte

        public BigliettoSpecial() : base() { Caratteristica = TipoPriorita.Prioritario; }
        public BigliettoSpecial(TipoBiglietto tb) : base(tb) { Caratteristica =  TipoPriorita.Prioritario; }

        public override string ToString()
        {
            return $"{base.ToString()} :  Biglietto Prioritario ";
        }
        //si va a sovrascrivere la funzione base della stampa 1 della classe base
        public override string Stampa1()
        {
            return $"S1 BigliettoSpecial : {nBiglietto}";
        }
        /*in questo caso si va a nascondere la funzione stampa2 della classe base quindi
         se si utilizza un elemento di tipo BigliettoSpecial  e si chiama la stampa 2 stampa: $"S2 BigliettoSpecial : {nBiglietto}";
        ma se si mette inun altro elemento di tipo Biglietto viene invocata la stampa del Biglietto   $"S2 Biglietto: {nBiglietto}"; 
        quind qua abbiamo una coesistenza delle due funzionalità al medesimo tempo 
         */
        public string Stampa2()
        {
            return $"S2 BigliettoSpecial : {nBiglietto}";
        }

    }
}
