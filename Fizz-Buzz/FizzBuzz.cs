﻿namespace Fizz_Buzz
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        public static string Luku(int syote)
        {
            if (OnkoJaollinenViidellaToista(syote))
            {
                return "FizzBuzz";
            }
            if (OnkoJaollinenKolmella(syote))
            {
                return "Fizz";
            }

            if (OnkoJaollinenViidella(syote))
            {
                return "Buzz";
            }

            return syote.ToString();
        }

        public static bool OnkoJaollinenViidellaToista(int syote)
        {
            return OnkoJaollinenKolmella(syote) && OnkoJaollinenViidella(syote);
        }

        public static bool OnkoJaollinenKolmella(int syote)
        {
            return syote % 3 == 0;
        }

        public static bool OnkoJaollinenViidella(int syote)
        {
            return syote % 5 == 0;
        }
    }
}