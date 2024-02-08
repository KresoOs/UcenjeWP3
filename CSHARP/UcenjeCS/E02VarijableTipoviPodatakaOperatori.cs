namespace UcenjeCS
{
    internal class E02VarijableTipoviPodatakaOperatori
    {

        public static void Izvedi()
        {

            int CijeliBroj;
            CijeliBroj = 7;
            Console.WriteLine(CijeliBroj);
            Console.WriteLine("unesi cijeli broj");

            int Broj = int.Parse(Console.ReadLine());
            Console.WriteLine(Broj + CijeliBroj);


        }

    }
}
