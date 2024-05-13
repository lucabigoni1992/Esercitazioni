using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_di_vincenzo.DataModel
{
    internal class Docente : Persone
    {
        public int Salario;
        public List<string> Materie ;


        public Docente(string cf,string nome,string cognome,int sal, List<string> mat):base(cf,nome,cognome)
        {
            Salario = sal;
            Materie= mat;
        }



        #region GetSET

        public List<string>Addmaterie()
        {
            Console.WriteLine("Inserisci materia");
            string mate = Console.ReadLine();
            Materie.Add(mate);
            return Materie; 
        }
        
        
        public void SetSalario (int sala)
        {
            if (sala == 0)
            { throw new Exception("Il valore non è valido"); }
            
            Salario= sala;


        }
        public void Setmaterie(List<string> mate)
        {
            if (mate == null)
            { throw new Exception("La lista non è valida"); }

            Materie = mate;


        }
        public int GetSalario()

        {
            if (Salario == 0)
            {
                throw new Exception("Salario non valido");
            }
            return Salario;
        }


        public List<string> GetMaterie()

        {
            if (Materie == null)
            {
                throw new Exception("Materie non valide");
            }
            return Materie;
        }





        #endregion

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);

        }
    }

}
