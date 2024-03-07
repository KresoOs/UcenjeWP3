namespace UcenjeCS.E13Nasljedivanje
{
    // Jedna klasa može nasljediti samo jednu nadklasu
    internal class Predavac : Osoba // Klasa Predavac nasljeđuje klasu osoba
    {
        public string? Iban { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime + ": " + Iban;
        }
    }
}
