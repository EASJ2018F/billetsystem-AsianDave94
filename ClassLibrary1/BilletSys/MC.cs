using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSys
{
    public class MC
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
            return 125;
        }
        public string Køretøj()
        {
            return "MC";
        }
    }
}
