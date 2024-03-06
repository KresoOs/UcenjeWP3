namespace UcenjeCS.E17KonzolnaAplikacija.Model
{
    internal class Predavac : Entitet
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Oib { get; set; }
        public string Email { get; set; }

        public string Iban { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime + ", " + Email ;
        }
    }
}
