using UcenjeCS.E17KonzolnaAplikacija.Model;

namespace UcenjeCS.E17KonzolnaAplikacija

{
    internal class ObradaPredavac
    {
        public List<Predavac> Predavaci { get; }

        public ObradaPredavac()
        {
            Predavaci = new List<Predavac>();
            if (Pomocno.dev)
            {
                TestniPodaci();
            }
        }

        public void PrikaziIzbornik()
        {

            Console.WriteLine("Izbornik za rad s predavačima");
            Console.WriteLine("1. Pregled postojećih predavača");
            Console.WriteLine("2. Unos novog predavača");
            Console.WriteLine("3. Promjena postojećeg predavača");
            Console.WriteLine("4. Brisanje predavača");
            Console.WriteLine("5. Povratak na glavni izbornik");
            switch (Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika predavača: ",
                "Odabir mora biti 1-5", 1, 5))
            {

                case 1:
                    PregledPredavaca();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UcitajPredavaca();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjenaPredavaca();
                    PrikaziIzbornik();
                    break;
                case 4:
                    BrisanjePredavaca();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Gotov rad s predavačima");
                    break;


            }
        }

        private void PromjenaPredavaca()
        {
            PregledPredavaca();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj predavača: ", "Nije dobar odabir", 1, Predavaci.Count());
            var p = Predavaci[index - 1];
            p.Sifra = Pomocno.ucitajCijeliBroj("Unesite šifra predavača (" + p.Sifra + "): ",
                "Unos mora biti pozitivni cijeli broj");
            p.Ime = Pomocno.UcitajString("Unesi ime predavača (" + p.Ime + "): ", "Ime obavezno");
            p.Prezime = Pomocno.UcitajString("Unesi Prezime predavača (" + p.Prezime + "): ", "Prezime obavezno");
            p.Email = Pomocno.UcitajString("Unesi Email predavača (" + p.Email + "): ", "Email obavezno");
            p.Oib = Pomocno.UcitajString("Unesi OIB predavača (" + p.Oib + "): ", "OIB obavezno");
            p.Iban = Pomocno.UcitajString("Unesi IBAN predavača(" + p.Iban + "): ", "IBAN obavezan");
        }

        private void BrisanjePredavaca()
        {
            PregledPredavaca();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj predavača: ", "Nije dobar odabir", 1, Predavaci.Count());
            Predavaci.RemoveAt(index - 1);
        }

        public void PregledPredavaca()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("---- Predavači ----");
            Console.WriteLine("------------------");
            int b = 1;
            foreach (Predavac predavac in Predavaci)
            {
                Console.WriteLine("{0}. {1}", b++, predavac);
            }
            Console.WriteLine("------------------");
        }

        private void UcitajPredavaca()
        {
            var p = new Predavac();
            do
            {
                p.Sifra = Pomocno.ucitajCijeliBroj("Unesite šifra predavača: ",
                    "Unos mora biti pozitivni cijeli broj");

                if (Predavaci.Any(predavac => predavac.Sifra == p.Sifra))
                {
                    Console.WriteLine("Šifra predavača već postoji. Molimo unesite novu šifru: ");
                }
                else
                {
                    break;
                }
            }while (true);
            p.Ime = Pomocno.UcitajString("Unesi ime predavača: ", "Ime obavezno");
            p.Prezime = Pomocno.UcitajString("Unesi Prezime predavača: ", "Prezime obavezno");
            p.Email = Pomocno.UcitajString("Unesi Email predavača: ", "Email obavezno");
            p.Oib = Pomocno.UcitajString("Unesi OIB predavača: ", "OIB obavezno");
            p.Iban = Pomocno.UcitajString("Unesi IBAN predavača: ", "IBAN obavezno");
            Predavaci.Add(p);

        }

        private void TestniPodaci()
        {



            Predavaci.Add(new Predavac
            {
                Sifra = 1,
                Ime = "Shaq",
                Prezime = "'O neal",
                Email = "shaq@gmail.com",
                Oib = "25873465871",
                Iban = "HR4488855599771"
            });

            Predavaci.Add(new Predavac
            {
                Sifra = 2,
                Ime = "Marijan",
                Prezime = "Herceg",
                Email = "herceg091@gmail.com",
                Oib = "15789618248",
                Iban = "HR22555444999987"
            });
        }
    }
}
