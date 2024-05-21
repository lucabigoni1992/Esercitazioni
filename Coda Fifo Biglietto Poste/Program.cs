using Coda_Fifo_Biglietto_Poste.DM;

namespace Coda_Fifo_Biglietto_Poste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Queque queque = new Queque();
            queque.Enqueque(TipoBiglietto.Spedizione);
            queque.Enqueque(TipoBiglietto.Finanza);
            queque.Enqueque(TipoBiglietto.Spedizione);
            queque.Enqueque(TipoBiglietto.Telefonia);
            queque.Enqueque(TipoBiglietto.Spedizione);
            queque.Enqueque(TipoBiglietto.Finanza);
            queque.Enqueque(TipoBiglietto.Spedizione);
            queque.Enqueque(TipoBiglietto.Telefonia);
            queque.Dequeque();
            queque.Dequeque();
            queque.Dequeque();
            queque.Dequeque();
        }
    }
}
