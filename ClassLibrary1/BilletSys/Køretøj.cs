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
            get;set; 
        }
        public virtual DateTime Dato
        {
            get;set;
        }
        
        public bool Brobizz { get; set; }

        public Køretøj( string Nummerplade, DateTime Dato)
        {
            if (Nummerplade.Length > 7)
            {
                throw new ArgumentException("Nummerplade er for lang");
            }
        }
        public abstract string Type();
        
    }
}
