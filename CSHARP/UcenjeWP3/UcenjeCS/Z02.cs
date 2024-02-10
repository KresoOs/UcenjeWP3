namespace UcenjeCS
{
    internal class Z02
    {

        public static void Izvedi()
        {
            // Program unosi dva broja
            // Ispisuje veći
            // DZ
            Console.WriteLine("Unesi prvi broj: ");
            int Broj1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj: ");
            int Broj2 = int.Parse(Console.ReadLine());
            if (Broj1 > Broj2)
            {
                Console.WriteLine("broj 1 je veći od broja 2");
            }
            else
            {
                Console.WriteLine("Broj 2 je veći od broja 1");
            }
        }
    }
}
