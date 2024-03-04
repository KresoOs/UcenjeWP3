using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.Konzolna.Model
{
    internal class Kupci:Entitet
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string Telefon { get; set; }
        public string Email { get; set; }
    }
}
