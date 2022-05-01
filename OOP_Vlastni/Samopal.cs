using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vlastni
{
    class Samopal:Zbran
    {
        private bool sklopnaPazba;

        public bool GetSklopnaPazba()
        {
            return sklopnaPazba;
        }

        public void SetSklopnaPazba(bool sklopnaPazba)
        {
            this.sklopnaPazba = sklopnaPazba;
        }
        public Samopal(int serioveCislo, string nazev, bool sklopnaPazba) : base(serioveCislo, nazev)
        {
            this.sklopnaPazba = sklopnaPazba;
        }
        public override string ToString()
        {
            string manema = "\n Nemá sklopnou pažbu.";
            if (sklopnaPazba)
            {
                manema = "\n Má sklopnou pažbu";
            }
            string s = "Zbraň se jmenuje: " + Nazev + "\nJejí sériové číslo je: " + serioveCislo + manema;
            return s;
        }
    }
}
