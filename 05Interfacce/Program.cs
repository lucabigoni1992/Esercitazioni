using _05Interfacce.DM;
using _05Interfacce.DM.Interfacce;

namespace _05Interfacce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Leone l = new Leone();
            l.Suono();
            l.Mangia();
            l.PredaPreferita();
            Gazzella g = new Gazzella();
            var animali = new List<IAnimale>();//i animale non è un oggetto ma un interfaccia 
            animali.Add(l);
            animali.Add(g);
            foreach (var animale in animali)
            {
                //qua posso usare i metodi dell'interfaccia IAnimale ma no quelli delle altre 2 interfacce perchè ho fatto un cast a IAnimale
                animale.Suono();
                animale.Mangia();
                if (animale is ICarnivori)
                {
                    ((ICarnivori)animale).PredaPreferita();
                }
                else if (animale is IErbivoro)
                {
                    ((IErbivoro)animale).PiantaPreferita();
                }
                if (animale is Gazzella)
                {
                   ((Gazzella) animale).PiantaPreferita();
                }
            }
        }
    }
}
