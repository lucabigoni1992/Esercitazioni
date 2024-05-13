using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_di_vincenzo.DataModel
{

    internal class Studente : Persone
    {
        public int Matricola;
        public string Università;


        public Studente(string cf,string name,string surname,int matr, string Uni) : base(cf,name,surname)
        {
            Matricola = matr;
            Università = Uni;
        }




        #region GetSET

        public void Setmatricola(int matricola)
        {
            if (Matricola == 0)
            {
                throw new Exception("la matrricoLla inserita non è valida");
            }

            Matricola = matricola;

        }
        public void SetUniversità(string uni)
        {
            if (uni== "")
            {
                throw new Exception("L'università non è valida");
            }

            Università = uni;

        }

        public int GetMatricola()

        {
            if (Matricola == 0)
            {
                throw new Exception("matricol non valida");
            }
            return Matricola;
        }


        public string GetUniversità()

        {
                if (Università == " ")
                {
                    throw new Exception("Uniersità inserita non valida");
                }
                return Università;
        }

        #endregion

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);

        }
    }
}

