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


        public bool Enqueque(TipoBiglietto tb, TipoPriorita tp=TipoPriorita.Base)
        {
            if (Coda.Count >= 100 || tb == TipoBiglietto.None)
            {
                return false;
            }
            switch (tp)
            {
                case TipoPriorita.Base:
                    Coda.Add(new Biglietto(tb));
                    break;
                case TipoPriorita.Prioritario:
                    Coda.Add(new BigliettoSpecial(tb));
                    break;
            }
            return true;
        }
        public bool Dequeque()
        {
            if (Coda.Count == 0)
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

        //--------soluzione-------------
        public void  StampaPerTipo()
            {
            int spedi=0;
            int fina = 0;
            int Tele = 0;


            for (var i = 0;i<Coda.Count; i++)
            {
                TipoBiglietto app = Coda[i].GetTipo();
                switch(app)
                {
                    case TipoBiglietto.Spedizione: spedi++;
                        break;
                    case TipoBiglietto.Finanza: fina++;
                        break;
                    case TipoBiglietto.Telefonia: Tele++;
                        break;
                }    
                // --metodo 2--
                /*
                if (Coda[i].GetTipo()==TipoBiglietto.Spedizione)
                {
                    spedi++;
                }
               else if (Coda[i].GetTipo()==TipoBiglietto.Finanza)
                {
                    fina++;
                }
                else if (Coda[i].GetTipo() == TipoBiglietto.Telefonia)
                {
                    Tele++;
                }
                */
            }

            Console.WriteLine($"Ci sono :{spedi} nella sezione Spedizione\nCi sono :{fina} nella sezione Finanza\nCi sono :{Tele} nella sezione Telefonia ");
        }


        //stampare a schermo tutti gli elementi nella lista

        public void Stampatutto()
        {
            /*Corretto levato solo per esempio
             * foreach(var a in Coda)
            {
                Console.WriteLine(a);
            }*/


            Console.WriteLine("Stampa1:");
            Console.WriteLine("");
            foreach (var a in Coda)
            {
                Console.WriteLine(a.Stampa1());
            }
            Console.WriteLine("");
            Console.WriteLine("Stampa2:");
            foreach (var a in Coda)
            {
                Console.WriteLine(a.Stampa2());
            }
            Console.WriteLine("");
            /* metodo 2
              for (int i = 0; i < Coda.Count; i++)
              {
                  Console.WriteLine(Coda[i]);
              }
            */

        }

        //una funzione che prende in ingresso un numero e dice se quel numero è presente o meno nella lista (deve restituire un bool )

        public bool CercaNbiglietto()
        {
            int numero;
            string valore;
            do
            {
                Console.WriteLine("inserisci N del biglietto da cercare");                
                valore = Console.ReadLine() ?? "-1";
            }
            while (!int.TryParse(valore, out numero ));

            if (numero>Coda.Count)
            {
                Console.WriteLine("il numero del biglietto e maggiore del numero totale di biglietti");
                return false;
            }
            for (int i = 0;i<Coda.Count;i++)
            {
                if (Coda[i].GetNbiglietto()==numero)
                {
                    Console.WriteLine("il  biglietto e Presente");
                    return true;
                }
            }
            Console.WriteLine("il  biglietto NON e Presente");
            return false;
        }


    }
}
