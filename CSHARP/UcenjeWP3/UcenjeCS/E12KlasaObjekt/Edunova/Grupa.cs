namespace UcenjeCS.E12KlasaObjekt.Edunova
{
    internal class Grupa
    {
        public int? Sifra { get; set; }
        public string? Naziv { get; set; }
        public Smjer? Smjer { get; set; }

        public DateTime? DatumPocetka { get; set; }

        public int? MaxPolaznika { get; set; }

        public Predavac? Predavac { get; set; }
    }
}
