namespace UcenjeCS
{
    internal class Z03
    {

        public static void Izvedi()
        {
            // Program unosi tri cijela broja
            // program ispisuje najmanji
            // DZ
            Console.Write("upiši broj 1: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("upiši broj 2: ");
            int b2 = int.Parse(Console.ReadLine());
            Console.Write("upiši broj 3: ");
            int b3 = int.Parse(Console.ReadLine());
            if (b1 < b2 && b1 < b3)
            {
                Console.WriteLine("Najmanji broj je broj 1");
            }
            else if (b2 < b3 && b2 < b1)

            {
                Console.WriteLine("Najmanji je broj 2");
            }
            else
            {
                Console.WriteLine("Najmanji je broj 3");
            }


        }
    }
}
