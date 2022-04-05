using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Vjezba2_ile
{
    class Provjera
    {
        private bool checkIBAN(String IBAN)
        {
            Regex regex = new Regex("HR[0-9]+");
            return regex.IsMatch(IBAN);
        }

        private bool checkDate(String date)
        {
            Regex regex = new Regex("([0-9]+(\\.[0-9]+)+)");
            return regex.IsMatch(date);
        }

        private static bool checkNumber(String input)
        {
            Regex regex = new Regex("([0-9]+(-[0-9]+)+)");
            return regex.IsMatch(input);
        }

        private bool compareIme(String payer, String reciver)
        {
            if(String.Equals(payer,reciver))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool compareAdress(String payer, String reciver)
        {
            if (String.Equals(payer, reciver))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool compareNumber(String payer, String reciver)
        {
            if (!checkNumber(payer) || !checkNumber(reciver)) { return false; }
            if (String.Equals(payer, reciver))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool checkUplatnica(Platitelj payer, Primatelj reciver)
        {
            if (!compareIme(payer.ime_platitelja, reciver.ime_primatelja)) { return false; }
            else if (!compareAdress(payer.adresa, reciver.adresa)) { return false; }
            else if (!compareNumber(payer.broj_platitelja, reciver.broj_primatelja)) { return false; }
            else if (!checkDate(reciver.datum)) { return false; }
            else { return true; }
        }
    }
}
