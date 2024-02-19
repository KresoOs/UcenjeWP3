namespace UcenjeCS
{
    internal class DevilTable1
    {
        public static void Izvedi()
        {

            Console.WriteLine("unesi prvi broj: ");
            int redova = int.Parse(Console.ReadLine());
            Console.WriteLine("unesi drugi broj: ");
            int stupova = int.Parse(Console.ReadLine());
            int[,] tab = new int[redova, stupova];
            int broj = redova * stupova;
            int red = redova-1;
            int stup = stupova-1;
            string smjer = "lijevo";
            
            for (int i = 1; i <= broj; i++)
            {
                if (smjer == "desno" && (stup > stupova - 1 || tab[red, stup] != 0))
                {
                    smjer = "dolje";
                    stup--;
                    red++;
                }
                if (smjer == "dolje" && (red > redova - 1 || tab[red, stup] != 0))
                {
                    smjer = "lijevo";
                    red--;
                    stup--;
                }
                if (smjer == "lijevo" && (stup < 0 || tab[red, stup] != 0))
                {
                    smjer = "gore";
                    stup++;
                    red--;
                }
                if (smjer == "gore" && (red < 0 || tab[red, stup] != 0))
                {
                    smjer = "desno";
                    red++;
                    stup++;


                }
                tab[red, stup] = i;
                switch (smjer)
                {
                    case "desno":
                        {
                            stup++;
                            break;
                        }
                    case "lijevo":
                        {
                            stup--;
                            break;
                        }
                    case "gore":
                        {
                            red--;
                            break;
                        }
                    case "dolje":
                        {
                            red++;
                            break;
                        }

                }






            }
            for (int j = 0; j < redova; j++)
            {
                for (int k = 0; k < stupova; k++)
                {
                    Console.Write("{0,4}", tab[j, k]);
                }
                Console.WriteLine();
            }
            




        }
    }
}
