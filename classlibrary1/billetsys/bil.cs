﻿using System;
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
            if (Brobizz == true)
            {
                return (5/100*240) - 240;
            }
            return 240;
        }
        public override string Type()
        {
            return "Bil";
        }
        public Bil(string Nummerplade, DateTime Dato) 
            :base(Nummerplade, Dato)
        {

        }
        public string Nummerplade()
        {
            return "13245678";
        }
    }
    
}