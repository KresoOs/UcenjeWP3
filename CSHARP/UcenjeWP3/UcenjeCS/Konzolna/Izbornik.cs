
namespace UcenjeCS.Konzolna
{
    internal class Izbornik
    {
        public ObradaDjelatnik ObradaDjelatnik { get; }
        public ObradaKupac ObradaKupac { get; }

        public ObradaProizvod ObradaProizvod { get; }

        public ObradaRadniNalog ObradaRadniNalog { get; }

        public ObradaStatus ObradaStatus { get; }



        public Izbornik()
        {

            Pomocno.dev = true;
            ObradaDjelatnik = new ObradaDjelatnik();
            ObradaKupac = new ObradaKupac();
            ObradaProizvod = new ObradaProizvod();
            ObradaRadniNalog = new ObradaRadniNalog();
            ObradaStatus = new ObradaStatus();
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("***** Reklamacijski Pult Console APP v 1.0 *****");
            Console.WriteLine("************************************************");
        }

        private void PrikaziIzbornik()
        {
            Console.Clear();
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Djelatnici");
            Console.WriteLine("2. Kupci");
            Console.WriteLine("3. Proizvodi");
            Console.WriteLine("4. Radni Nalozi");
            Console.WriteLine("5. Statusi");
            Console.WriteLine("6. Izlaz iz programa");
            Console.WriteLine("7. Times New Roman");
            Console.WriteLine("8. Arial");

            switch (Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika: ",
                "Odabir mora biti 1 - 8.", 1, 8))
            {
                case 1:
                    Console.Clear();
                    ObradaDjelatnik.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    ObradaKupac.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    ObradaProizvod.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObradaRadniNalog.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 5:
                    ObradaStatus.PrikaziIzbornik();
                    break;
                case 6:
                    Console.WriteLine("Hvala na korištenju, doviđenja");
                    break;
                case 7:
                    ConsoleHelper.SetConsoleFont("Times New Roman", 40);
                    PrikaziIzbornik();
                    break;
                case 8:
                    ConsoleHelper.SetConsoleFont("Arial", 50);
                    PrikaziIzbornik();
                    break;

            }


        }

    }
}
