using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class LjubavniKalkulator1
    {
        public static void Izvedi() 
        {
            Console.WriteLine("Unesi svoje ime :" );
               string ime1 = Console.ReadLine();
            Console.WriteLine( "Unesi njeno ime:" );
               string ime2 = Console.ReadLine();
            string ime3 = ime1.ToLower() + ime2.ToLower();
            int[] brojevi = new int[ime3.Length];
            int ponavljanje = 0;
            int i = 0;
            for (int j = 0; j < brojevi.Length; j++)
            {
                foreach (char c in ime3)
                {


                    if (c == ime3[j])
                    {

                        ponavljanje++;

                    }

                    

                }
                brojevi[j] = ponavljanje; ponavljanje =0;
                Console.Write(brojevi[j]);

            }
            

        }
        private static int Suma(int[] a,int položaj=0)
        {
            if (a[položaj])
        }

    }
}
