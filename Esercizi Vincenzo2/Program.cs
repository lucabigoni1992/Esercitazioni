namespace Esercizi_Vincenzo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string numero;
                int scelta;

                do
                {
                    Console.WriteLine("Inserisci il tpo di forma da Inserire");
                    numero = Console.ReadLine() ?? "0";

                }
                while (int.TryParse(numero, out scelta));

                while(true)
                {
                    Console.WriteLine("Inserisci il tpo di forma da Inserire");

                    switch ()
                }
            }
            catch { }


        }
    }
}
