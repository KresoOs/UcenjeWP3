﻿namespace UcenjeCS.E15Polimorfizam
{
    internal class Smjer : Entitet
    {
        public string? Naziv { get; set; }
        public int BrojSati { get; set; }

        public float Cijena { get; set; }

        public float Upisnina { get; set; }

        public bool Verificiran { get; set; }
    }
}
