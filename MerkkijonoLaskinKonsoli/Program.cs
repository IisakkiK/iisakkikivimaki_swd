using System;

namespace MerkkijonoLaskinKonsoli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merkkijonolaskin");
            Console.WriteLine("Anna luvut pilkulla erotettuna:");

            string syote = Console.ReadLine();

            MerkkijonoLaskin laskin = new MerkkijonoLaskin();

            Console.WriteLine("Lukujen summa on:" + laskin.Laske(syote));
        }
    }
}
