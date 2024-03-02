namespace UcenjeCS
{
    internal class LjubavniKalkulator

    {

        public static void Izvedi()
        {
            Console.Write("Unesi svoje ime: ");
            string ime1 = Console.ReadLine();
            Console.Write("Unesi ime simpatije: ");
            string ime2 = Console.ReadLine();
            string ime3 = ime1.ToLower() + ime2.ToLower();
            int[] A = new int[ime3.Length];
            int ponavljanje = 0;

            for (int j = 0; j < ime3.Length; j++)
            {
                foreach (char c in ime3)
                {


                    if (c == ime3[j])
                    {

                        ponavljanje++;

                    }



                }
                A[j] = ponavljanje;

                ponavljanje = 0;


                Console.WriteLine(A[j]);




            }


            Console.WriteLine(Zbroji(A, 0, A.Length-1));
        }

        private static int Zbroji(int[] A, int prvi, int zadnji)
        {
            if (prvi == zadnji)
                return A[prvi];

            int pocetak = A[prvi];
            int kraj = A[zadnji];

            if (pocetak > 9)
            {
                A[prvi] = pocetak / 10;
                A[prvi + 1] = pocetak % 10;
                pocetak = A[prvi] + A[prvi + 1];
                prvi++;
            }
            if (kraj > 9)
            {
                A[zadnji] = kraj / 10;
                A[zadnji - 1] = kraj % 10;
                pocetak = A[zadnji] + A[zadnji - 1];
                zadnji--;
            }
            int suma = pocetak + kraj;
            if (suma > 9)
            {
                A[prvi]= suma / 10;
                A[zadnji]= suma % 10;
                return A[prvi] + A[zadnji]+Zbroji(A,prvi,zadnji);
            }
            else
            {
                return suma + Zbroji(A,prvi+1,zadnji-1);
            }
        }


    }


}

