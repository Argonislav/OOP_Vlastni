using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vlastni
{
    class Zbran
    {
        protected int serioveCislo;
        protected string nazev;
        public Zbran(int serioveCislo, string nazev)
        {
            Nazev = nazev;
            this.serioveCislo = serioveCislo;
        }

        int SerioveCislo { get; }

        public string Nazev
        {
            get
            {
                return nazev;
            }
            set
            {
                string s = value;
                int i = 0;
                bool nalezeno = false;
                while (i < s.Length)
                {
                    if (char.IsLetter(s[i]) && !nalezeno)
                    {
                        char znak = char.ToUpper(s[i]);
                        s = s.Replace(s[i], znak);
                    }
                    else if (char.IsLetter(s[i]) && nalezeno)
                    {
                        char znak = char.ToLower(s[i]);
                        s = s.Replace(s[i], znak);
                    }
                    if (s[i] <= 'a' && s[i] <= 'z' || s[i] <= 'A' && s[i] <= 'Z' || s[i] <= '0' && s[i] <= '9')
                    {
                        s = s.Remove(i, 1);
                    }
                    else ++i;
                    this.nazev = s;
                }
            }
        }
        public override string ToString()
        {
            string s = "Zbraň se jmenuje: " + Nazev + "\nJejí sériové číslo je: " + serioveCislo;
            return s;
        }
    }
}
