

namespace _06Tipi_Generici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generico<int> g = new Generico<int>();
            Generico<String> f = new Generico<String>();
            Generico<float> k= new Generico<float> ();
            Console.WriteLine($"{g.Somma(5, 6)}");
            g.Stampa(5);
            f.Stampa("ciao");
            Console.WriteLine($"{f.Somma("ciao", "mondo")}");
            k.Somma(5.5f, 6.6f);
        }
    }
}
