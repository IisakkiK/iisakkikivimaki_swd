using System;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz -tehtävä");
            Console.WriteLine("-----------------");
            Console.WriteLine("Anna luku väliltä 1-100 ja paina Enter");

            int kayttajanSyote = int.Parse(Console.ReadLine());

            var fizzBuzz = new FizzBuzz();
            var vastaus = fizzBuzz.Luku(kayttajanSyote);

            Console.WriteLine();
            Console.WriteLine(vastaus);

        }
    }
}
