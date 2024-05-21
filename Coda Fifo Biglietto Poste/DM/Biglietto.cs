using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coda_Fifo_Biglietto_Poste.DM
{
    public enum TipoBiglietto
    {
        None = -1,
        Spedizione = 0,
        Finanza = 1,
        Telefonia = 2
    }
    public class Biglietto
    {

        //le variabili di tipo static sono condivise tra  le varie istanze della classe quindi se una la modifica, è modificata per tutte
        private static int _instance = 0;
        private int nBiglietto;
        private TipoBiglietto Tiplologia;
        private DateTime OrarioIngresso;
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
            return $"Hai il biglietto n° {nBiglietto}, Staccato alle {OrarioIngresso}, di tipo {Tiplologia}";
        }

    }
}
