﻿namespace UcenjeCS.E15Polimorfizam
{
    internal abstract class Osoba : Entitet
    {
        public abstract string Pozdravi();
        public string? Ime { get; set; }

        public string? Prezime { get; set; }

        public string? Oib { get; set; }

        public string? Email { get; set; }
    }
}
