namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(11);
            list.Add(12);
            list.Add(13);
            list.Add(15);
            list.Add(-51);
            list.ForEach(x => Console.WriteLine(x));
            /* foreach (int x in list)
           {
               Console.WriteLine(x);
           }*/
            Console.WriteLine();
            list.ForEach(x => { Console.Write(x); Console.Write(" "); ; Console.WriteLine(x + 2); });
            /* foreach (int x in list)
           {
              Console.Write(x); 
              Console.WriteLine(x + 2);
           }*/
            Console.WriteLine();
            list.Where(pippo => pippo < 10).ToList().ForEach(x => Console.WriteLine(x));
            /*lista2= new List<int>();
             * foreach (int x in list)
           {
            if(pippo > 10){
              lista2.add(x); 
            }
           }
            foreach (int x in lista2)
           {
              Console.Write(x); 
           }*/

            

        }
    }
}
