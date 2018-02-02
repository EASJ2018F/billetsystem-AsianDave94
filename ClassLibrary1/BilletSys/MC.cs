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

        public override double Pris()
        {
            if (Brobizz == true)
            {
                return 125*0.95;
            }
            return 125;
        }
        public override string Type()
        {
            return "MC";
        }
        
    }
}
