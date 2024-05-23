using Coda_Fifo_Biglietto_Poste.DM;

namespace Coda_Fifo_Biglietto_Poste
{
    internal class Program
    {
        static void Main(string[] args)

        {
            try
            {
                Console.WriteLine("Biglietto:");
                Biglietto b = new Biglietto();
                Console.WriteLine(b.Stampa1());
                Console.WriteLine(b.Stampa2());
                Console.WriteLine(b);
                Console.WriteLine("Biglietto Special:");
                BigliettoSpecial b2 = new BigliettoSpecial();
                Console.WriteLine(b2.Stampa1());
                Console.WriteLine(b2.Stampa2());
                Console.WriteLine(b2);
                Console.WriteLine("Biglietto Special in biglietto:");
                Biglietto b3 = new BigliettoSpecial();
                /*la funzione Stampa1 Della classe BASE è stata sovrascritta alla funzione Stamp1 della classe derivata
                 * quindi anche se uso un tipo base il suo metodo originario non potrà più essere usato per queto oggetto.*/
                Console.WriteLine(b3.Stampa1());
                /*la funzione Stampa2 Della classe BASE è NON stata sovrascritta alla funzione Stamp2 della classe derivata
                 * ma coesistono entrambe :
                 * - Se si crea un tipo Derivato (BigliettoSpecial) e si associa a un tipo base (Biglietto)  si utilizzerà il metodo della classe base.
                 * - Se si crea un tipo Derivato (BigliettoSpecial) e si associa a un tipo      (BigliettoSpecial)  si utilizzerà il metodo della classe dewrivata.
                */
                Console.WriteLine(b3.Stampa2());
                Console.WriteLine(b3);

                return ;
                Queque queque = new Queque();
                int selezione;
                string valore;
                int selezione2;
                string valore2;

                while (true)
                {
                    do
                    {
                        Console.WriteLine("-----------Sleziona cosa devi fare-------------");
                        Console.WriteLine("0 = Prendere un biglietto,\n1 = Persone in coda per tipo di biglietto,\n2 = Cercare un biglietto,\n3 = Vedi elco di tutti i biglietti\n4 = Esci");
                        valore = Console.ReadLine() ?? "-1";

                    }
                    while (!int.TryParse(valore, out selezione));


                    switch (selezione)
                    {

                        case 0:
                            #region case0
                            do
                            {
                                Console.WriteLine("Sleziona tipo di biglietto: ");
                                Console.WriteLine(" - Spedizione         = 0");
                                Console.WriteLine(" - Finanza            = 1");
                                Console.WriteLine(" - Telefonia          = 2");
                                Console.WriteLine(" - Telefonia Avanzato = 3");
                                Console.WriteLine("Esci");
                                valore2 = Console.ReadLine() ?? "-1";
                            }
                            while (!int.TryParse(valore2, out selezione2));

                            switch (selezione2)
                            {
                                case 0:
                                    queque.Enqueque(TipoBiglietto.Spedizione); break;
                                case 1:
                                    queque.Enqueque(TipoBiglietto.Finanza); break;
                                case 2:
                                    queque.Enqueque(TipoBiglietto.Telefonia); break;
                                case 3:
                                    queque.Enqueque(TipoBiglietto.Telefonia,TipoPriorita.Prioritario); break;
                                default:
                                    Console.WriteLine("NON VALIDO"); break;
                            }
                            break;
                        #endregion


                        case 1:
                            queque.StampaPerTipo();
                            break;
                        case 2:
                            Console.WriteLine("C'e il biglietto cercato nell'elenco ?:" + queque.CercaNbiglietto());
                            break;
                        case 3:
                            queque.Stampatutto();
                            break;
                        case 4:
                            Console.WriteLine("CIAO CIAO");
                            return;
                        default:
                            Console.WriteLine("NON VALIDO");
                            break;
                    }
                }

            }
            catch (Exception e) { Console.WriteLine(e); };
        }
    }
}
/*
            queque.Enqueque(TipoBiglietto.Spedizione);
            queque.Enqueque(TipoBiglietto.Finanza);
            queque.Enqueque(TipoBiglietto.Spedizione);
            queque.Enqueque(TipoBiglietto.Telefonia);
            queque.Enqueque(TipoBiglietto.Spedizione);
            queque.Enqueque(TipoBiglietto.Finanza);
            queque.Enqueque(TipoBiglietto.Spedizione);
            queque.Enqueque(TipoBiglietto.Telefonia);

            //queque.Dequeque();
            //queque.Dequeque();
            //queque.Dequeque();
            //queque.Dequeque();
            queque.Stampatutto();
            queque.StampaPerTipo();
            Console.WriteLine("C'e il biglietto cercato nell'elenco ?:"+queque.CercaNbiglietto());

*/
