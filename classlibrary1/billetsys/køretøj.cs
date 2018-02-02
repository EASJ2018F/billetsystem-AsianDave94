using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSys
{
    
    public abstract class Køretøj
    {
        private bool _broBizz;
        private DateTime _dato;
        private string _nummerplade;
        public abstract int Pris(int pris);
        
        public virtual string Nummerplade
        {
            get { return _nummerplade; }
            set { _nummerplade = value; }
        }
        public virtual DateTime Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }
        public abstract string Type();
        public bool Brobizz
        {
            get { return _broBizz; }
            set { _broBizz = value; }
        }

        public Køretøj( string Nummerplade, DateTime Dato)
        {
            _nummerplade = Nummerplade;
            _dato = Dato;
            if (Nummerplade.Length > 7)
            {
                throw new ArgumentException("Nummerplade er for lang");
            }
        }
    }
}
