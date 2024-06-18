namespace Classivirtuali_astratte_ereditarieta.DM
{
    public class Prodotto
    {
        public string Nome { get; set; }
        public float Prezzo { get; set; }
        public int Quantita { get; set; }
        public Prodotto() { }
        public Prodotto(string nome, float prezzo, int quantita)
        {
            Nome = nome;
            Prezzo = prezzo;
            Quantita = quantita;
        }
    }
}