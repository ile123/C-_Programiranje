using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vjezba2_ile
{
    class Program
    {
        static void Main(string[] args)
        {
            Primatelj reciver = new Primatelj("Ante Antić", "Vukovarska 2", "091-555-2222", "5.2.2000", "Nebitno");
            Platitelj sender = new Platitelj("Ivan Ivić", "Stepinćeva 4", false, "kn", 100, "HR2724020061100292949", "091-222-1234");
            Provjera provjera = new Provjera();
            if (!provjera.checkUplatnica(sender, reciver))
            {
                Console.WriteLine("Problem sa jednim od parametra");
            }
            else
            {
                Console.WriteLine("Sve Uspijelo!");
                Tuple<Platitelj, Primatelj>[] lista =
                {
                    Tuple.Create(sender,reciver)
                }
            }
        }
    }
}
