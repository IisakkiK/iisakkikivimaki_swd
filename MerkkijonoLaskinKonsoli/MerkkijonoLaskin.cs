﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace MerkkijonoLaskinKonsoli
{
    public class MerkkijonoLaskin
    {
        public int Laske(string syote)
        {
            if (OnkoTyhjaSyote(syote))
                return 0;

            string[] erotinmerkit = new string[] { ",", "\n", "\\n" };
            string[] numerot = syote.Split(erotinmerkit, StringSplitOptions.RemoveEmptyEntries);

            int summa = 0;

            foreach (string yksittainenNumero in numerot)
            {
                int luku = int.Parse(yksittainenNumero);

                if (JosLukuOnPienempiKuinNolla(luku))
                    throw new ArgumentException(" Luku ei voi olla negatiivinen.");

                if (LukuOnSuurempiKuinTuhat(luku))
                    continue;

                summa += luku;
            }

            return summa;
        }

        private bool OnkoTyhjaSyote(string syote)
        {
            return syote.Length == 0;
        }

        private bool JosLukuOnPienempiKuinNolla(int luku)
        {
            return luku < 0;
        }

        private bool LukuOnSuurempiKuinTuhat(int luku)
        {
            return luku > 1000;
        }
    }
}
