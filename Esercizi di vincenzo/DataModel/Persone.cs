using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_di_vincenzo.DataModel
{
    internal class Persone
    {
        public string Codicefiscale;
        public string Nome;
        public string Cognome;

        /*
                public Persone() 
                {
                    Codicefiscale = "";
                    Nome = "ND";
                    Cognome = "ND";

                }
        */


        public Persone(string Cf, string name, string surname)
        {
            Codicefiscale = Cf;
            Nome = name;
            Cognome = surname;

        }


        #region GETSET 

        public void Setcodicefiscale(string cf)
        {
            if (string.IsNullOrWhiteSpace(cf))
            {
                throw new Exception("Codicefiscale vuoto");
            }
            Codicefiscale = cf;

        }
        public void SetNome(string name)
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                throw new Exception("Nome non valido");
            }
            Nome = name;

        }
        public void SetCognome(string surname)
        {
            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new Exception("Cognome non valido");
            }
            Cognome = surname;

        }

        public string GetCodicefiscale()

        {
            if (string.IsNullOrWhiteSpace(Codicefiscale))
            {
                throw new Exception("Codicefiscale vuoto");
            }
            return Codicefiscale;
        }
        public string GetNome()

        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                throw new Exception("Nome non valido");
            }
            return Nome;
        }
        public string GetCognome()

        {
            if (string.IsNullOrWhiteSpace(Cognome))
            {
                throw new Exception("Cognome non valido");
            }
            return Cognome;
        }
        #endregion
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);

        }

    }
}
