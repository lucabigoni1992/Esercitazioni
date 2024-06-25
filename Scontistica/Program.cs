
using Classivirtuali_astratte_ereditarieta.BLL;
using Classivirtuali_astratte_ereditarieta.DM;

Console.WriteLine("Benvenuto Nel programma di Scontistica");

var prodotti = new List<Prodotto>();
prodotti.Add(new Prodotto("Pasta", 1.5f, 2));
prodotti.Add(new Prodotto("Latte", 1.2f, 1));
prodotti.Add(new Prodotto("Pane", 0.5f, 3));
prodotti.Add(new Prodotto("Acqua", 0.8f, 2));
prodotti.Add(new Prodotto("Vino", 5.5f, 1));
prodotti.Add(new Prodotto("Birra", 2.5f, 1));
prodotti.Add(new Prodotto("Carne", 10.5f, 1));
prodotti.Add(new Prodotto("Pesce", 8.5f, 1));
Console.WriteLine("Calcolo per Spesa ");
Console.WriteLine($"Sconto calcolato per cliente  Gold:\t{new ScontiGold().CalcolaScontoProdotti(prodotti)}");
Console.WriteLine($"Sconto calcolato per cliente  Silver:\t{new ScontiSilver().CalcolaScontoProdotti(prodotti)}");
Console.WriteLine($"Sconto calcolato per cliente  Bronz:\t{new ScontiBronz().CalcolaScontoProdotti(prodotti)}");
Console.WriteLine("Calcolo per singolo prodotto");
float sconto = 0f;
for (int i = 0; i < prodotti.Count; i++)
{
    sconto += new ScontiGold().CalcolaScontoProdotto(prodotti[i]);
}
Console.WriteLine($"Sconto calcolato per cliente  Gold:\t{sconto}");
 sconto = 0f;
for (int i = 0; i < prodotti.Count; i++)
{
    sconto += new ScontiSilver().CalcolaScontoProdotto(prodotti[i]);
}
Console.WriteLine($"Sconto calcolato per cliente  Silver:\t{sconto}");
 sconto = 0f;
for (int i = 0; i < prodotti.Count; i++)
{
    sconto += new ScontiBronz().CalcolaScontoProdotto(prodotti[i]);
}
Console.WriteLine($"Sconto calcolato per cliente  Bronz:\t{sconto}");

Console.WriteLine("Fine Programma");


