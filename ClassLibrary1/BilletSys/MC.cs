using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSys
{
    public class MC : Køretøj
    {
        public MC(string Nummerplade, DateTime Dato) : 
            base(Nummerplade, Dato)
        {
        }

        public override int Pris()
        {
            if (Brobizz == true)
            {
                return 125 - (125/100-5);
            }
            return 125;
        }
        public override string Type()
        {
            return "MC";
        }
        
    }
}
