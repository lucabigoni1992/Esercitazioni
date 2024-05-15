namespace ClassiVirtuali
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Offerta o = new Offerta(0.3f, "Base");
            Console.WriteLine($"Sconto: {o.CalcolaOfferta(100)}");
            Console.WriteLine($"Sconto: {o.CalcolaOfferta(100)}");
            OffertaGold u = new OffertaGold(0.3f, "Base");
            Console.WriteLine($"Sconto: {u.CalcolaOfferta(100)}");
            Console.WriteLine($"Sconto: {u.CalcolaOfferta(100)}");

        }
    }
}
