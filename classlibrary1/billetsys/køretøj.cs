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
            get
            {
                if (Nummerplade.Length >7)
                {
                    throw new ArgumentException("Nummerplade er for lang");
                }
                return Nummerplade;
            }
            set { value = Nummerplade; }
        }
        public virtual DateTime Dato
        {
            get { return Dato; }
            set { value = Dato; }
        }
        
        public virtual string Type()
        {
            return "Køretøj";
        }
        public int Rabat
        {
            get;set;
        }
        public Køretøj()
        {

        }
        public Køretøj(int rabat)
        {
            this.Rabat = rabat;
        }
       
    }
}
