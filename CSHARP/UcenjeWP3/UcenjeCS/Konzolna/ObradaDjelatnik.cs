using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.Konzolna.Model;

namespace UcenjeCS.Konzolna
{
    internal class ObradaDjelatnik
    {

        public List<Djelatnik> Djelatnici { get; }

        public ObradaDjelatnik()
        {
            Djelatnici = new List<Djelatnik>();
            if (Pomocno.dev)
            {
                TestniPodaci();
            }

        }
        public void PrikaziIzbornik()
        {

            Console.WriteLine("Izbornik za rad s Djelatnicima");
            Console.WriteLine("1. Pregled postojećih djelatnika");
            Console.WriteLine("2. Unos novog djelatnika");
            Console.WriteLine("3. Promjena postojećeg djelatnika");
            Console.WriteLine("4. Brisanje djelatnika");
            Console.WriteLine("5. Povratak na glavni izbornik");
            switch (Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika djelatnika: ",
                "Odabir mora biti 1-5", 1, 5))
            {

                case 1:
                    PregledDjelatnika();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UcitajDjelatnika();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjenaDjelatnika();
                    PrikaziIzbornik();
                    break;
                case 4:
                    BrisanjeDjelatnika();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Gotov rad s Djelatnicima");
                    break;


            }
        }
        private void UcitajDjelatnika()
        {

            var p = new Djelatnik();
            p.Sifra = Pomocno.ucitajCijeliBroj("Unesite šifra polaznika: ",
                "Unos mora biti pozitivni cijeli broj");
            p.Ime = Pomocno.UcitajString("Unesi  ime Djelatnika: ", "Ime obavezno");
            p.Prezime = Pomocno.UcitajString("Unesi Prezime Djelatnika: ", "Prezime obavezno");
            Djelatnici.Add(p);

        }
        private void PromjenaDjelatnika()
        {

            PregledDjelatnika();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj polaznika: ", "Nije dobar odabir", 1, Djelatnici.Count());
            var p = Djelatnici[index - 1];
            var originalSifra = p.Sifra;
            var originalIme = p.Ime;
            var originalPrezime = p.Prezime;
            

            p.Sifra = Pomocno.ucitajCijeliBroj("Unesite šifra polaznika (" + p.Sifra + "): ",
                "Unos mora biti pozitivni cijeli broj");
            p.Ime = Pomocno.UcitajString("Unesi ime polaznika (" + p.Ime + "): ", "Ime obavezno");
            p.Prezime = Pomocno.UcitajString("Unesi Prezime polaznika (" + p.Prezime + "): ", "Prezime obavezno");
            

            string izbor = Pomocno.UcitajString("Želite li odustati od promjena? (da/ne): ", "Molimo unesite da ili ne");
            if (izbor.ToLower() == "da")
            {
                // Poništi promjene
                p.Sifra = originalSifra;
                p.Ime = originalIme;
                p.Prezime = originalPrezime;
               
            }
        }

        private void TestniPodaci()
        {

            for (int i = 0; i < 4; i++)
            {
                Djelatnici.Add(new Djelatnik
                {
                    Sifra = i + 1,
                    Ime = Faker.Name.First(),
                    Prezime = Faker.Name.Last(),

                });
            }
        }
    }
}
