using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Vjezba2_ile
{

        public class Platitelj
        {
            public Platitelj(string ime_platitelja, string adresa, bool hitno, string valuta, int iznos, string iBAN_platitelj, String broj_platitelja)
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

            public String ime_platitelja { get; set; }
            public String adresa { get; set; }
            public bool hitno { get; set; }
            public String valuta { get; set; }
            public int iznos { get; set; }
            public String IBAN_platitelj { get; set; }
            public String model { get; set; }
            public String broj_platitelja { get; set; }
        }

        public class Primatelj
        {
            public Primatelj(string ime_primatelja, string adresa, String broj_primatelja, string datum, string opis_placanja)
            {
                this.ime_primatelja = ime_primatelja;
                this.adresa = adresa;
                this.broj_primatelja = broj_primatelja;
                this.datum = datum;
                this.opis_placanja = opis_placanja;
            }

            public String ime_primatelja { get; set; }
            public String adresa { get; set; }
            public String broj_primatelja { get; set; }
            public String datum { get; set; }
            public String opis_placanja { get; set; }
        }

}