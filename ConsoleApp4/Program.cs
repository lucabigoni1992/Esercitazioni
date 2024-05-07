using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        private int N = 0;
        static void Main(string[] args)
        {
            int[] vettore = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            int[] vettore2 = new int[] { };
            int[] vettore3 = new int[] { 0, 6, 3, 5, 2, 1, 4 };
            /*int somma = SommaArray(vettore);
            string stampa= FormattaJson(vettore);
            Console.WriteLine($"La somma di {stampa} e': {somma}");*/
            BoubleSoarth(vettore);
            BoubleSoarth(vettore2);
            BoubleSoarth(vettore3);
            StampaDefinitivo(vettore);
            StampaDefinitivo(vettore2);
            StampaDefinitivo(vettore3);
            string s = "ciao";
            string s2 = "anna";
            string s3 = "i topi non avevano nipoti";
            Palindromo(s);
            Palindromo(s2);
            Palindromo(s3);
        }

        private static void BoubleSoarth(int[] vettore)
        {
            for (int i = 0; i < vettore.Length; i++)
            {
                for (int j = 0; j < vettore.Length - 1 - i; j++)
                {
                    if (vettore[j] > vettore[j + 1])
                    {
                        int temp = vettore[j];
                        vettore[j] = vettore[j + 1];
                        vettore[j + 1] = temp;
                    }
                }
            }
        }

        private static bool Palindromo(string s)
        {
            //s=s.Replace(" ", "");
            for (int i = 0, f = s.Length - 1; i < s.Length / 2; i++, f--)
            {
                if (s[i] == ' ')
                {
                    i++;
                }
                if (s[f] == ' ')
                {
                    f--;
                }
                if (s[i] != s[f])
                {
                    Console.WriteLine("Non e' palindromo");
                    return false;
                }
            }
            Console.WriteLine("E' palindromo");
            return true;
        }

        private static void StampaDefinitivo(int[] vettore)
        {
            Console.WriteLine($"La somma di {FormattaJson(vettore)} e': {SommaArray(vettore)}");
        }

        private static int SommaArray(int[] vettore)
        {
            int somma = 0, i = 0;
            while (i < vettore.Length)
            {
                somma += vettore[i];//somma =somma+ vettore[i];
                i++;
            }
            return somma;

        }
        private static string FormattaJson(int[] vettore)
        {
            string s = "["; ;
            for (int i = 0; i < vettore.Length; i++)
            {
                s += "'" + vettore[i] + "'";
                if (i < vettore.Length - 1)
                    s += ",";
            }
            s += "]";
            return s;
        }
    }
}
