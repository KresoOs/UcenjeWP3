using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.Konzolna.Model
{
    internal class Proizvodi:Entitet
    {
        public string ime { get; set; }
        public string opis { get; set; }

        public string jedinicakolicine { get; set; }
    }
}
