using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
    {
    public class RandomNumber
    {
        private static readonly
        System.Security.Cryptography.RNGCryptoServiceProvider_seed = 
        new System.Security.Cryptography.RNGCryptoServiceProvider();
            publicstatic int NumberBetween(int minimum, int maximum)
        {
            byte[] randomNumber = new byte[1];  // uusi byte taulukko

            _seed.GetBytes(randomNumber);

            double asciiValue = Convert.ToDouble(randomNumber[0]);

            double multiplier = Math.Max(0, (asciiValue / 255d) - 0.00000000001d);

            int range = maximum - minimum + 1; // lisätään yksi, jotta pyöristäminen mahdollistuu

            double randomValue = Math.Floor(multiplier * range); // varmistaa että pysytään annetulla alueella

            return (int)(minimum + randomValue); // lisää minimin randomiin
        }
    }
}
