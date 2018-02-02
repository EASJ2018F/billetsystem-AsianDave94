using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSys
{
    public class Bil : Køretøj
    {
        public override int Pris()
        {
            int PrisMedBrobizz = 240 - Rabat;

            if (PrisMedBrobizz <= 0)
                throw new ArgumentException("For stor rabat");
            return PrisMedBrobizz;
        }
        public override string Type()
        {
            return "Bil";
        }
        public Bil() 
            :base()
        {

        }
        public Bil(int rabat) 
            :base(rabat)
        {

        }
        public string Nummerplade()
        {
            return "13245678";
        }
    }
    
}
