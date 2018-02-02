using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSys
{
    public class MC : Køretøj
    {
        public override int Pris()
        {
            int PrisMedBrobizz = 125 - Rabat;

            if (PrisMedBrobizz <= 0)
                throw new ArgumentException("For stor rabat");
            return PrisMedBrobizz;
        }
        public override string Type()
        {
            return "MC";
        }
    }
}
