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


        public Persone(string Cf, string name,string surname) 
        {
            Codicefiscale = Cf;
            Nome=name;
            Cognome= surname;
        
        }


        #region GETSET 

        public void setcodicefiscale(string cf)
        {
            if (cf == " ")
            {
                throw new Exception("Codicefiscale vuoto");
            }
            Codicefiscale = cf;

        }
        public void setNome(string name)
        {
            if (Nome == " ")
            {
                throw new Exception("Nome non valido");
            }
            Nome = name;

        }
        public void setCognome(string surname)
        {
            if (surname == " ")
            {
                throw new Exception("Cognome non valido");
            }
            Cognome = surname;

        }

        public string GetCodicefiscale()

        {
            if (Codicefiscale == " ")
            {
                throw new Exception("Codicefiscale vuoto");
            }
            return Codicefiscale;
        }
        public string GetNome()

        {
            if (Nome == " ")
            {
                throw new Exception("Nome non valido");
            }
            return Nome;
        }
        public string GetCognome()

        {
            if (Cognome == " ")
            {
                throw new Exception("Cognome non valido");
            }
            return Cognome;
        }
        #endregion 

       
    }
}
