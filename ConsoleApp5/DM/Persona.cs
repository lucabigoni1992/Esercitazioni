

using Newtonsoft.Json;
using System;

namespace ConsoleApp5.DM
{
    // un nome al singolare
    internal class Persona
    {
        //tutte le prorprietà che rappresentano quel'ente
        public string Nome;
        public string Cognome;
        public int AnnoDiNascita;

        public Persona(string nome, string cognome, int annoDiNascita)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = annoDiNascita;
        }
        public Persona()
        {
            Nome = "";
            Cognome = "";
            AnnoDiNascita = 1990;
        }
        #region GetSet
        public string GetNome()
        {
            if (Nome == "")
            {
                //una riga di log dove scrivo l'errore è BUON USO FRLO OGNI QUAL VOLTA SI LANCIA O GESTISCE UN ECCEZIONE
                throw new Exception("Nome non valido");
            }
            return Nome;
        }
        public string GetCognome()
        {
            if(Cognome == "")
            {
                throw new Exception("Cognome non valido");
            }
            return Cognome;
        }
        public int GetAnnoDiNascita()
        {
            if (AnnoDiNascita < 1900)
            {
                throw new Exception("Anno di nascita non valido");
            }
            return AnnoDiNascita;
        }
        public void SetNome(string nome)
        {
            if (nome == "")
            {
                throw new Exception("Nome non valido");
            }
            Nome = nome;
        }
        public void SetCognome(string cognome)
        {
            if (cognome == "")
            {
                throw new Exception("Cognome non valido");
            }
            Cognome = cognome;
        }
        public void SetAnnoDiNascita(int annoDiNascita)
        {
            if (annoDiNascita < 1900)
            {
                throw new Exception("Anno di nascita non valido");
            }
            AnnoDiNascita = annoDiNascita;
        }
        #endregion GetSet

        private void Test1() { }
        public void Test2() { }
        internal void Test3() { }
        protected void Test4() { }

        /// <summary>
        /// Funzioe che genera il codice fiscale
        /// </summary>
        /// <returns>Il codice fiscale</returns>
        public string GetCodiceFiscale()
        {
            return $"{Nome.Substring(0, 3)}{Cognome.Substring(0, 3)}{AnnoDiNascita}";
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
            // return $"Nome: {Nome} - Cognome: {Cognome} - Anno di nascita: {AnnoDiNascita}";
        }
    }
}
