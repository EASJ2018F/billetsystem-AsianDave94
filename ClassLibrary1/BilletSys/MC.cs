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
            return 125;
        }
        public override string Type()
        {
            return "MC";
        }
    }
}
