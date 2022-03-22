using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba1_Ile
{
    public class Zadatak1
    {
        static public void zadatak()
        {
            Console.WriteLine("Unesi brojeve: ");
            string broj1 = Console.ReadLine();
            string broj2 = Console.ReadLine();
            float rez = int.Parse(broj1) / int.Parse(broj2);
            Console.WriteLine("Currency -> " + "{0:C}", rez);
            Console.WriteLine("Integer -> " + Convert.ToInt32(rez));
            Console.WriteLine("Scientific -> " + "{0:E}", rez);
            Console.WriteLine("Fixed-Point -> " + "{0:F}", rez);
            Console.WriteLine("General -> " + "{0:G}", rez);
            Console.WriteLine("Number -> " + "{0:N}", rez);
            Console.WriteLine("Hex -> " + "{0:X3}", Convert.ToInt32(rez));
        }
    }
}
