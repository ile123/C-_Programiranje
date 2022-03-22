using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba1_Ile
{
    public class Zadatak3
    {
        public enum Vrste_Racuna
        {
            Stednja,
            TekuCi,
            ziro
        }
        public struct BankAccount
        {
            public int broj_racuna;
            public float iznos;
            public Vrste_Racuna tip_racuna;
        }
        static public void zadatak()
        {
            BankAccount[] racuni= new BankAccount[5];
            Console.WriteLine("\n 1) Dodaj Novi Racun \t \t \t 2) Ispiši sve račune \t\t\t 3) EXIT");
            int i=0;
            while (true)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Upisi podatke te odaberi tip računa -> 1) Štednja \t 2) Tekući \t 3) Žiro");
                        racuni[i].broj_racuna = int.Parse(Console.ReadLine());
                        racuni[i].iznos = int.Parse(Console.ReadLine());
                        string tip = Console.ReadLine();
                        switch (tip)
                        {
                            case "1":
                                racuni[i].tip_racuna = Vrste_Racuna.Stednja;
                                break;
                            case "2":
                                racuni[i].tip_racuna = Vrste_Racuna.TekuCi;
                                break;
                            case "3":
                                racuni[i].tip_racuna = Vrste_Racuna.ziro;
                                break;
                            default:
                                racuni[i].tip_racuna = Vrste_Racuna.ziro;
                                break;
                        }
                        i++;
                        break;
                    case "2":
                        foreach(BankAccount racun in racuni)
                        {
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("ID -> " + racun.broj_racuna);
                            Console.WriteLine("IZNOS -> " + racun.iznos);
                            Console.WriteLine("VRSTA -> " + racun.tip_racuna);
                            Console.WriteLine("-------------------------------------");
                        }
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("KRIVI UNOS");
                        break;
                }
            }
        }
    }
}
