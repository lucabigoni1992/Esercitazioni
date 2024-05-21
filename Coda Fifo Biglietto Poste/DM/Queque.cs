using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coda_Fifo_Biglietto_Poste.DM
{
    internal class Queque
    {
        public List<Biglietto> Coda;
        private const int MaxElem = 100;//le costanti sono dei valori che non possono essere mai modificati nel tempo

        public Queque()
        {
            Coda = new List<Biglietto>();
        }


        public bool Enqueque(TipoBiglietto tb)
        {
            if (Coda.Count >= 100 || tb == TipoBiglietto.None)
            {
                return false;
            }
            Coda.Add(new Biglietto(tb));
            return true;
        }
        public bool Dequeque()
        {
            if (Coda.Count== 0)
            {
                return false;
            }
            Console.WriteLine(Coda[0]);
            Coda.RemoveAt(0);//rimuoviamo il biglietto all'indice 0
            return true;
        }

        //implementa delle funzionalità:
        //stampare a schermo per ogni tipologia di biglietto quanti sono in coda 
        /*
         es
        Spedizione : 3 persone,
        Finanza : 1 persona,
        Telefonia : 30 persona         
         */


        //stampare a schermo tutti gli elementi nella lista

        //una funzione che prende in ingresso un numero e dice se quel numero è presente o meno nella lista (deve restituire un bool )



    }
}
