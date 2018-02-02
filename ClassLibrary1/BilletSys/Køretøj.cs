using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSys
{
    class Køretøj
    {
        public string Nummerplade
        {
            get { return Nummerplade; }
            set { value = Nummerplade; }
        }
        public DateTime Dato
        {
            get { return Dato; }
            set { value = Dato; }
        }
        public int Pris()
        {
            return 0;
        }
    }
}
