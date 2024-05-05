using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.Konzolna.Model;

namespace UcenjeCS.Konzolna
{
    
        


    
        internal class ObradaKupac
        {
            public List<Kupac> Kupci { get; }

            public ObradaKupac()
            {
                Kupci = new List<Kupac>();
                if (Pomocno.dev)
                {
                    TestniPodaci();
                }
            }

            public void PrikaziIzbornik()
            {

                Console.WriteLine("Izbornik za rad s kupcima");
                Console.WriteLine("1. Pregled postojećih kupaca");
                Console.WriteLine("2. Unos novog kupca");
                Console.WriteLine("3. Promjena postojećeg kupca");
                Console.WriteLine("4. Brisanje kupca");
                Console.WriteLine("5. Povratak na glavni izbornik");
                switch (Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika kupaca: ",
                    "Odabir mora biti 1-5", 1, 5))
                {

                    case 1:
                        PregledKupaca();
                        PrikaziIzbornik();
                        break;
                    case 2:
                        UcitajKupca();
                        PrikaziIzbornik();
                        break;
                    case 3:
                        PromjenaKupca();
                        PrikaziIzbornik();
                        break;
                    case 4:
                        BrisanjeKupca();
                        PrikaziIzbornik();
                        break;
                    case 5:
                        Console.WriteLine("Gotov rad s kupcima");
                        break;


                }
            }

            private void PromjenaKupca()
            {
                PregledKupaca();
                int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj kupca: ", "Nije dobar odabir", 1, Kupci.Count());
                var p = Kupci[index - 1];
                p.Sifra = Pomocno.ucitajCijeliBroj("Unesite šifra kupca (" + p.Sifra + "): ",
                    "Unos mora biti pozitivni cijeli broj");
                p.Ime = Pomocno.UcitajString("Unesi ime kupca (" + p.Ime + "): ", "Ime obavezno");
                p.Prezime = Pomocno.UcitajString("Unesi Prezime kupca (" + p.Prezime + "): ", "Prezime obavezno");
                p.Email = Pomocno.UcitajString("Unesi Email kupca (" + p.Email + "): ", "Email obavezno");
                p.Telefon = Pomocno.UcitajString("Unesi telefon kupca (" + p.Telefon + "): ", "Telefon obavezno");
            }

            private void BrisanjeKupca()
            {
                PregledKupaca();
                int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj kupca: ", "Nije dobar odabir", 1, Polaznici.Count());
                Kupci.RemoveAt(index - 1);
            }

            public void PregledKupaca()
            {
                Console.WriteLine("------------------");
                Console.WriteLine("------ Kupci -----");
                Console.WriteLine("------------------");
                int b = 1;
                foreach (Kupac kupac in Kupci)
                {
                    Console.WriteLine("{0}. {1}", b++, kupac);
                }
                Console.WriteLine("------------------");
            }

            private void UcitajKupca()
            {
                var p = new Kupac();
                p.Sifra = Pomocno.ucitajCijeliBroj("Unesite šifru kupca: ",
                    "Unos mora biti pozitivni cijeli broj");
                p.Ime = Pomocno.UcitajString("Unesi ime kupca: ", "Ime obavezno");
                p.Prezime = Pomocno.UcitajString("Unesi Prezime kupca: ", "Prezime obavezno");
                p.Email = Pomocno.UcitajString("Unesi Email kupca: ", "Email obavezno");
                p.Telefon = Pomocno.UcitajString("Unesi telefon kupca: ", "Telefon obavezno");
                Kupci.Add(p);

            }

            private void TestniPodaci()
            {

                for (int i = 0; i < 20; i++)
                {
                    Kupci.Add(new Kupac
                    {
                        Sifra = i + 1,
                        Ime = Faker.Name.First(),
                        Prezime = Faker.Name.Last(),
                        Email = Faker.Internet.Email(),
                        Telefon = Faker.Phone.Number(),
                    });
                }

                
            }
        }
    }



