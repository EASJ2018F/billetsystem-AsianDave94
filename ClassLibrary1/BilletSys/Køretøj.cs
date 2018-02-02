using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSys
{
    public abstract class Køretøj
    {
        public abstract int Pris();
        
        public virtual string Nummerplade
        {
            get { return Nummerplade; }
            set { value = Nummerplade; }
        }
        public DateTime Dato
        {
            get { return Dato; }
            set { value = Dato; }
        }
        
        public virtual string Type()
        {
            return "Køretøj";
        }
    }
}
