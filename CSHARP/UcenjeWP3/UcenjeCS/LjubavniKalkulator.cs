using System.Runtime.CompilerServices;

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
            string znamenke = "";
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
                 znamenke += ponavljanje.ToString();
                
                ponavljanje = 0;


                Console.WriteLine(znamenke);

                 


            }


            Console.WriteLine(Zbroji(znamenke, znamenke.Length));
        }

        private static int Zbroji(string A, int n)
        {
               


            if (n == 0)
                return 0;

            return (A[A.Length - n]-'0')  + Zbroji(A, n - 1) ;



        }


    }
}
