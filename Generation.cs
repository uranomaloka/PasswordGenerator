using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwort_Generator
{
    class Generation
    {
        char[] small = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        char[] large = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] numbers = "0123456789".ToCharArray();
        char[] special = @"<>@#*-_.,:;!§$%&/()=?{[]}\".ToCharArray();
        string psw;
        Random rnd = new Random();

        public string Generationmethod()
        {
            psw += small[rnd.Next(0, 25)];
            psw += large[rnd.Next(0, 25)];
            return psw;
        }

    }
}
