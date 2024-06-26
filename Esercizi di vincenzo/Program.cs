﻿using Esercizi_di_vincenzo.DataModel;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Esercizi_di_vincenzo


{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int lunghezzalista;
                string val = "";
                do
                {
                    Console.WriteLine("inserisci la lunghezza massima della lista");
                    val = Console.ReadLine() ?? "0";
                } while (!int.TryParse(val, out lunghezzalista));

                var elenco = new ElencoPersone(lunghezzalista);
                Persone pera = new Persone("csnmvinwve", "cello", "cose");
                Persone perb = new Persone("csnmvinwve", "cello", "cose");
                //  elenco.Aggiungi(pera);
                //elenco.Aggiungi(perb);



                while (true)
                {
                    Console.WriteLine("Decidi cosa inserire\n1 Persona\n2 Studente\n3 Docente\n4 <Esci");
                    int z = Convert.ToInt32(Console.ReadLine() ?? "0");
                    switch (z)
                    {
                        case 1:
                            Console.WriteLine("inserisci Un CodiceFiscale");
                            string codicefiscale = Console.ReadLine() ?? "";
                            Console.WriteLine("inserisci Un Nome");
                            string nome = Console.ReadLine() ?? "";
                            Console.WriteLine("inserisci Un Cognome");
                            string cognome = Console.ReadLine() ?? "";
                            Persone per1 = new Persone(codicefiscale, nome, cognome);
                            elenco.Aggiungi(per1);

                            break;
                        case 2:
                            Console.WriteLine("inserisci Un CodiceFiscale");
                            string codicefiscale2 = Console.ReadLine() ?? "";
                            Console.WriteLine("inserisci Un Nome");
                            string nome2 = Console.ReadLine() ?? "";
                            Console.WriteLine("inserisci Un Cognome");
                            string cognome2 = Console.ReadLine() ?? "";
                            Console.WriteLine("inserisci Una matricola");
                            int matricola = Convert.ToInt32(Console.ReadLine() ?? "0");
                            Console.WriteLine("inserisci Una Università");
                            string Universita = Console.ReadLine() ?? "";
                            Studente stud1 = new Studente(codicefiscale2, nome2, cognome2, matricola, Universita);
                            elenco.Aggiungi(stud1);

                            break;
                        case 3:
                            Console.WriteLine("inserisci Un CodiceFiscale");
                            string codicefiscale3 = Console.ReadLine() ?? "";
                            Console.WriteLine("inserisci Un Nome");
                            string nome3 = Console.ReadLine() ?? "";
                            Console.WriteLine("inserisci Un Cognome");
                            string cognome3 = Console.ReadLine() ?? "";
                            Console.WriteLine("inserisci Una matricola");
                            int salario = Convert.ToInt32(Console.ReadLine() ?? "0");
                            Console.WriteLine("inserisci Una materia");
                            List<string> list = new List<string>();
                            string mate = Console.ReadLine() ?? "";
                            list.Add(mate);
                            Docente doc1 = new Docente(codicefiscale3, nome3, cognome3, salario, list);
                            bool cont = true;
                            while (cont == true)
                            {
                                Console.WriteLine("vuoi inserire altre materie? Y/N");
                                string altre = Console.ReadLine() ?? "";
                                if (altre == "y")
                                {
                                    doc1.Addmaterie();

                                }
                                else
                                if (altre == "n")
                                {
                                    cont = false;
                                }
                            }
                            elenco.Aggiungi(doc1);
                            break;

                        case 4:
                            Console.WriteLine("Stampa per Elemento:");
                            elenco.Stampalista();
                            Console.WriteLine("Stampa tutta la lista:");
                            Console.WriteLine(elenco);
                            return;

                        default:
                            Console.WriteLine("Selezione non valida");
                            break;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); return; }
        }
    }
}






