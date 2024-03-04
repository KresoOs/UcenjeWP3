namespace UcenjeCS
{
    internal class LjubavniKalkulator1
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

            for (int j = 0; j < A.Length; j++)
            {
                foreach (char c in ime3)
                {


                    if (c == ime3[j])
                    {

                        ponavljanje++;

                    }



                }
                A[j] = ponavljanje; ponavljanje = 0;
                //Console.Write(A[j]);


            }

            Console.WriteLine(Zbroji(A, A.Length));


        }
        private static int Zbroji(int[] A, int n)
        {

            if (n == 0)
                return 0;

            return A[A.Length - n] + Zbroji(A, n - 1);



        }




    }
}
