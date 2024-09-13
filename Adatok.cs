using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_13_sandorral
{
    internal class Adatok
    {
        public string vezetek_nev;
        public string kereszt_nev;
        public int ID;
        public int kor;

        public Adatok(string s)
        {
            string[] darabok = s.Split(';');
            this.vezetek_nev = darabok[0];
            this.kereszt_nev = darabok[1];

            string[] ints = darabok[2].Split("-");
            this.ID = Convert.ToInt32(ints[0]+ints[2]);
            this.kor = Convert.ToInt32(ints[1]);

        }
    }
}