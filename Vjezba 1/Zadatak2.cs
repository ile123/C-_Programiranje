using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba1_Ile
{
    class Zadatak2
    {
        static public void zadatak()
        {
            int prviBroj = int.MaxValue;
            long drugiBroj = long.MaxValue;
            try
            {
                checked
                {
                    var rez = prviBroj + drugiBroj;
                }
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
            }
        }
    }
}
