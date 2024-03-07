namespace UcenjeCS.E15Polimorfizam
{
    internal class Predavac : Osoba
    {
        public string? Iban { get; set; }

        public override string Pozdravi()
        {
            return "Dobar dan predavaču " + Prezime;
        }
    }
}
