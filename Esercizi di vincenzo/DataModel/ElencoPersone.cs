using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//modifiacti nomi persone in elencopersoni e errori
namespace Esercizi_di_vincenzo.DataModel
{
    internal class ElencoPersone
    {

        List<Persone> Elenco;
        int max;

        public ElencoPersone(int qta)
        {
           Elenco =new List<Persone>(qta);
            max = qta;
        }
        public List<Persone> Aggiungi(Persone p)
        {
            if (Elenco.Count == max)
            {
                Console.WriteLine("la lista è piena");
                return Elenco;
            }
            else
            {
                Elenco.Add(p);
                return Elenco;
            }
        
        }
        //----------------Domanda per luca ---------------------------
        //Perche se overraidato il metodo Tostring il console.Writeline nel foreach non so trasforma ??
        public void Stampalista()
        {
           // Elenco.ForEach(x =>Console.WriteLine(ToString(x));
           foreach(var x in Elenco) { Console.WriteLine(JsonConvert.SerializeObject(x)); }


        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
            // return $"Nome: {Nome} - Cognome: {Cognome} - Anno di nascita: {AnnoDiNascita}";
        }

    }
}
