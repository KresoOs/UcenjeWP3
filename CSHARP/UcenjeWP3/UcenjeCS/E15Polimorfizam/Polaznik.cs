namespace UcenjeCS.E15Polimorfizam
{
    internal class Polaznik : Osoba
    {
        public string? BrojUgovora { get; set; }

        public override string Pozdravi()
        {
            return "Dobar dan polazniče " + Ime + " " + Prezime;
        }
    }
}
