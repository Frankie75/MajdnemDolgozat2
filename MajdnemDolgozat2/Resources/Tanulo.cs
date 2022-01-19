using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajdnemDolgozat2
{
    internal class Tanulo
    {
        public string Nev { get; set; }
        public bool Nem { get; set; }   
        public int FinanszirozasFormaja { get; set; }
        public int BefizetettOsszeg { get; set; }
        public int Eredmeny1 { get; set; }
        public int Eredmeny2 { get; set; }
        public int Eredmeny3 { get; set; }
        public int Eredmeny4 { get; set; }

        public Tanulo(string sor)
        {
            var darabok = sor.Split(';');
            Nev = darabok[0];
            if (darabok[1]=="m") Nem = true;
            else Nem= false;

            FinanszirozasFormaja = int.Parse(darabok[2]) ;
            BefizetettOsszeg = int.Parse(darabok[3].TrimStart('$'));
            Eredmeny1 = int.Parse(darabok[4]);
            Eredmeny2 = int.Parse(darabok[5]);
            Eredmeny3 = int.Parse(darabok[6]);
            Eredmeny4 = int.Parse(darabok[7]);
        }
    }
}
