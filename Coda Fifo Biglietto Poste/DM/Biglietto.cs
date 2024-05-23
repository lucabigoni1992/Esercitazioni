using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coda_Fifo_Biglietto_Poste.DM
{
    public class Biglietto
    {

        //le variabili di tipo static sono condivise tra  le varie istanze della classe quindi se una la modifica, è modificata per tutte
        private static int _instance = 0;
        protected int nBiglietto;
        protected TipoBiglietto Tiplologia;
        protected DateTime OrarioIngresso;
        protected TipoPriorita Caratteristica =TipoPriorita.Base;
        public Biglietto()
        {
            nBiglietto = _instance;
            _instance++;
            Tiplologia = TipoBiglietto.None;
            OrarioIngresso = DateTime.UtcNow;//Rappresenta l'orario del meridiano 0 
                                             // OrarioIngresso = DateTime.Now;//Rappresenta l'orario del meridiano in cui siamo (ora locale)
        }
        public Biglietto(TipoBiglietto tb)
        {
            nBiglietto = _instance;
            _instance++;
            Tiplologia = tb;
            OrarioIngresso = DateTime.UtcNow;//Rappresenta l'orario del meridiano 0 
                                             // OrarioIngresso = DateTime.Now;//Rappresenta l'orario del meridiano in cui siamo (ora locale)
        }

        public override string ToString()
        {
            return $"Ci sono in coda i biglietti n° {nBiglietto}, Staccato alle {OrarioIngresso}, di tipo {Tiplologia}";
        }

        //creo il metodo GetTipo 
        public TipoBiglietto GetTipo()
        {
            return Tiplologia;
        }
        // Creo il metodo GetNbiglietto

        public int GetNbiglietto()
        {
            return nBiglietto;

        }
        public virtual string Stampa1()
        {
            return $"S1 Biglietto: {nBiglietto}";
        }
        public string Stampa2()
        {
            return $"S2 Biglietto: {nBiglietto}";
        }

    }
}
