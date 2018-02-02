using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSys
{
    public class Bil : Køretøj
    {
        public override int Pris(int pris)
        {
            if (Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday && Brobizz)
            {
                return pris - (((pris / 100 * 5) + (pris / 100 * 20)));
            }
            if (Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday && Brobizz==false)
            {
                return pris - pris / 100 * 20;
            }
            if (Brobizz)
            {
                return pris - pris / 100 * 5;
            }
            return pris;
        }
        public override string Type()
        {
            return "Bil";
        }
        public Bil(string Nummerplade, DateTime Dato) 
            :base(Nummerplade, Dato)
        {

        }
    }
    
}
