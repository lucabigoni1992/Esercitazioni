using Esercizi_Vincenzo2.DATAMODEL;
using System.Drawing;
using System.Threading.Tasks.Sources;

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
                // dati ( raggio,diametro,area,perimetro)
                double[] DatiCerchio= new double[4];
                // dati(Area,perimetro)
                double[] DatiRettangolo =new double[2];



                while (true)
                {
                    do
                    {
                        Console.WriteLine("Inserisci il tpo di forma da Inserire\n" + "1 Cerchio\n2 Rettangolo\n3 Esci");
                        numero = Console.ReadLine() ?? "0";

                    }
                    while (!int.TryParse(numero, out scelta));

                   
                        switch (scelta)
                        {
                            case 1:

                            string nome = "Cerchio";
                            Console.WriteLine( "Inserisci colore del cerchio" );
                            string color = Console.ReadLine() ?? "";
                            Console.WriteLine("Inserisci il raggio del cerchio");
                            double ragx =Convert.ToDouble( Console.ReadLine() ?? "");
                            Cerchio circle =new Cerchio(color,nome,ragx);
                            DatiCerchio[0] = ragx;
                            DatiCerchio[1] = circle.Diametro();
                            DatiCerchio[2]=circle.Area();
                            DatiCerchio[3]=circle.Perimetro();
                                          
                            
                            Console.WriteLine(circle);

                            //----------------- per luca-------------
                            //Perche non riesco a stampare con interpolazione i metodi get ma si i valori dentro array?
                            Console.WriteLine($"NomeForma: {circle.GetNomeForma()} - Colore: {circle.GetColore()} - Perimetro: {DatiCerchio[3]} - Area: {DatiCerchio[2]} ");


                                break;
                            case 2:
                            string nome2 = "rettangolo";
                            Console.WriteLine("Inserisci colore del rettangolo");
                            string color2 = Console.ReadLine() ?? "";
                            Console.WriteLine("Inserisci Base Rettangolo");
                            double basex = Convert.ToDouble(Console.ReadLine() ?? "");
                            Console.WriteLine("Inserisci Altezza Rettangolo");
                            double altex = Convert.ToDouble(Console.ReadLine() ?? "");
                            Rettanolo retta1 = new Rettanolo(color2,nome2,basex,altex);
                            DatiRettangolo[0] = retta1.Area();
                            DatiRettangolo[1]= retta1.Perimetro();

                           //----------------- per luca-------------
                           //Perche non riesco a stampare con interpolazione i metodi get ma si i valori dentro array?
                            Console.WriteLine($"NomeForma: {retta1.GetNome()} - Colore: {retta1.GetColore()} - Perimetro: {DatiRettangolo[1]} - Area: {DatiRettangolo[0]} ");

                            Console.WriteLine(retta1);

                                break;
                             case 3:
                                Console.WriteLine("CIAO CIAO");
                                return;
                            

                            default:
                                Console.WriteLine("NON VALIDO");
                                break;
                        }


                    }


                



            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); return; }


        }
    }
}

