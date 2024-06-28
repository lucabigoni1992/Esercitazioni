using Esercizi_di_Vincenzo_Interfacce.DM;

namespace Esercizi_di_Vincenzo_Interfacce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random m = new Random();
            int batt=m.Next(0,100);
            
            Smartphone s= new Smartphone( batt);
           
            batt = m.Next(0, 100);
            Laptop l =new Laptop(batt);

            s.TurnOn();   

            if ( s.BatteryLevel() == 0 )
            {
                Console.WriteLine("Lo Smartphone è spento");
            }
            else
            {
                Console.WriteLine("Batteria Smartphone= " + s.BatteryLevel() + "%");
            }
            
            l.TurnOn();
            

            if (l.BatteryLevel() == 0)
            {
                Console.WriteLine("Il Laptop è spento");
            }
            else
            {
                Console.WriteLine("Batteria Laptop= " + l.BatteryLevel() + "%");
            }

        }
    }
}
