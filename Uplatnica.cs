using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Vjezba_2_ile
{
    public class Uplatnica
    {
        public class Platitelj
        {
            public Platitelj(string ime_platitelja, string adresa, bool hitno, string valuta, int iznos, string iBAN_platitelj, int broj_platitelja)
            {
                this.ime_platitelja = ime_platitelja;
                this.adresa = adresa;
                this.hitno = hitno;
                this.valuta = valuta;
                this.iznos = iznos;
                this.IBAN_platitelj = iBAN_platitelj;
                this.model = "00";
                this.broj_platitelja = broj_platitelja;
            }

            String ime_platitelja { get; set; }
            String adresa { get; set; }
            bool hitno { get; set; }
            String valuta { get; set; }
            int iznos { get; set; }
            String IBAN_platitelj { get; set; }
            String model { get; set; }
            int broj_platitelja { get; set; }
        }

        public class Primatelj
        {
            public Primatelj(string ime_primatelja, string adresa,int broj_primatelja, string datum, string opis_placanja)
            {
                this.ime_primatelja = ime_primatelja;
                this.adresa = adresa;
                this.model = "00";
                this.broj_primatelja = broj_primatelja;
                this.datum = datum;
                this.opis_placanja = opis_placanja;
            }

            String ime_primatelja { get; set; }
            String adresa { get; set; }
            String model { get; set; }
            int broj_primatelja { get; set; }
            String datum { get; set; }
            String opis_placanja { get; set; }
        }

        private bool checkIBAN(String IBAN)
        {
            Regex regex = new Regex("HR[0-9]+");
            return regex.IsMatch(IBAN);
        }



    }
}
