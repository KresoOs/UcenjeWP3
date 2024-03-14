namespace UcenjeCS.Konzolna
{
    internal class Pomocno
    {
        public static bool dev;


        public static int ucitajBrojRaspon(string poruka, string greska,
            int poc, int kraj)
        {
            int b;
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    b = int.Parse(Console.ReadLine());
                    if (b >= poc && b <= kraj)
                    {
                        return b;
                    }
                    Console.WriteLine(greska);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(greska);
                }
            }
        }

        internal static int ucitajCijeliBroj(string poruka, string greska)
        {
            int b;
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    b = int.Parse(Console.ReadLine());
                    if (b > 0)
                    {
                        return b;
                    }
                    Console.WriteLine(greska);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(greska);
                }
            }
        }

        internal static decimal ucitajDecimalniBroj(string poruka, string greska)
        {
            decimal b;
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    b = decimal.Parse(Console.ReadLine());
                    if (b > 0)
                    {
                        return b;
                    }
                    Console.WriteLine(greska);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(greska);
                }
            }
        }
        internal static bool ucitajBool(string poruka)
        {
            Console.Write(poruka);
            return Console.ReadLine().Trim().ToLower().Equals("da") ? true : false;
        }

        internal static string UcitajString(string poruka, string greska)
        {
            string s = "";
            while (true)
            {
                Console.Write(poruka);
                s = Console.ReadLine();
                if (s != null && s.Trim().Length > 0)
                {
                    return s;
                }
                Console.WriteLine(greska);
            }
        }

        internal static DateTime ucitajDatum(string v1, string v2)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(v1);
                    return DateTime.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(v2);
                }
            }
        }
    }
    // Napišite metodu koja prima string poruku i vraća
    // string koji ne smije biti prazan
    // metoda se zove UcitajString

    public static string UcitajString(string poruka)
        {
            string s;
            for (; ; )
            {
                Console.Write(poruka + ": ");
                s = Console.ReadLine().Trim();
                if (s.Length == 0)
                {
                    Console.WriteLine("Obavezan unos");
                    continue;
                }

                try
                {
                    int.Parse(s);
                    Console.WriteLine("Unos ne smije biti cijeli broj");
                    continue;
                }
                catch (Exception)
                {

                }

                try
                {
                    float.Parse(s);
                    Console.WriteLine("Unos ne smije biti decimalni broj");
                    continue;
                }
                catch (Exception)
                {

                }


                return s;
            }
        }
    }
}
