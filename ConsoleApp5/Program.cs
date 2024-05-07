using ConsoleApp5.DM;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            try
            {
                Persona p = new Persona("Mario", "Rossi", 1980);
                Persona p2 = new Persona("Luigi", "Bianchi", 1980);
                var Livorno = new List<Persona>();
                var Pisa = new List<Persona>();
                Livorno.Add(p);
                Livorno.Add(p2);
                Livorno[0].GetNome();
                Livorno[1].GetNome();
                Pisa.Add(new Persona("Maria", "verdi", 1990));
                Pisa.Remove(p);
                Pisa[0].GetNome();
                //Console.WriteLine(p);
                //Console.WriteLine(p.ToString());
                Console.WriteLine(JsonConvert.SerializeObject(Livorno));
                Console.WriteLine(JsonConvert.SerializeObject(Pisa));
                //Livorno.RemoveAt(0);
                // Console.WriteLine(JsonConvert.SerializeObject(Livorno));
                // Console.WriteLine(JsonConvert.SerializeObject(Pisa));
                foreach (var item in Livorno)
                {
                    Console.WriteLine(item.GetNome());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
