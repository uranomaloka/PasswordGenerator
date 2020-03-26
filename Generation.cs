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
        public bool chsmall;
        public bool chlarge;
        public bool chnumbers;
        public bool chspecial;
        int auswahl;

        public Generation()
        {
            chsmall = false;
            chlarge = false;
            chnumbers = false;
            chspecial = false;
        }

        public string Generationmethod(int length)
        {
            if(chsmall==false&&chlarge==false&&chnumbers==false&&chspecial==false)
            {
                
                return "";
            }

            psw = "";
            for (int i = 0; i < length;)
            {
                auswahl = rnd.Next(0, 4);
                if (auswahl == 0&&chsmall==true)
                {
                    psw += AddSmall();
                    i++;
                }
                else if (auswahl == 1&&chlarge==true)
                {
                    psw += AddLarge();
                    i++;
                }
                else if (auswahl == 2&&chnumbers==true)
                {
                    psw += AddNumber();
                    i++;
                }
                else if(auswahl==3&&chspecial==true)
                {
                    psw += AddSpecial();
                    i++;
                }
            }
            return psw;
        }

        private string AddSmall()
        {
            return small[rnd.Next(0, 25)].ToString();
        }

        private string AddLarge()
        {
            return large[rnd.Next(0, 25)].ToString();
        }

        private string AddNumber()
        {
            return numbers[rnd.Next(0, 9)].ToString();
        }

        private string AddSpecial()
        {
            return special[rnd.Next(025)].ToString();
        }

    }
}
