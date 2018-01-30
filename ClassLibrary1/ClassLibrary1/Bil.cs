using System;

namespace ClassLibrary1
{
    public class Bil
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
            return 240;
        }
        public string Køretøj()
        {
            return "Bil";
        }
    }
}
