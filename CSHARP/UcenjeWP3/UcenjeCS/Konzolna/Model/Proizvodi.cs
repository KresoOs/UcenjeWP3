﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.Konzolna.Model
{
    internal class Proizvodi:Entitet
    {
        public string Ime { get; set; }
        public string Opis { get; set; }

        public string JedinicaKolicine { get; set; }
    }
}
