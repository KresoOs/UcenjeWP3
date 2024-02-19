namespace UcenjeCS
{
    internal class KucnaVjezba
    {

        public static void Izvedi()
        {

            //int CijeliBroj;
            //CijeliBroj = 7;
            //Console.WriteLine(CijeliBroj);
            //Console.WriteLine("Unesi cijeli broj: ");
            //int Broj = int.Parse(Console.ReadLine());
            //Console.WriteLine(Broj);

            //string v1 = "Osijek";
            //var v2 = "Edunova";
            //Console.WriteLine(v1 +v2);



            //float db = 3.14f;
            //double vdb = 0.214887;
            //Console.WriteLine("Unesi visinu u metrima:");
            //float Visina = float.Parse(Console.ReadLine());
            //Console.WriteLine(Visina);

            //int i = 2, j = 3;
            //Console.WriteLine(i - j);

            //Console.WriteLine(i - j);
            //Console.WriteLine(i / (float)j);

            //Console.Write("unesi dvoznamenkasti broj : ");
            //int Broj = int.Parse(Console.ReadLine());
            //Console.WriteLine("Prva znamenka broja je : " + Broj / 10);
            //Console.WriteLine("druga znamenka broja je :" + Broj % 10);
            //bool uvjet = true;
            //int k = 2, l = 2;
            //Console.WriteLine("{0} {1} {2} {3}", k > l, k >= l, k <= l,k < l);
            //int v = 1;
            //Console.WriteLine(v);
            //v=v+1;
            //Console.WriteLine(v);
            //v += 1;
            //Console.WriteLine(v);
            //v++;
            //Console.WriteLine(v);
            //v = 1;
            //Console.WriteLine(++v);
            //int x = 2, y = 1;
            //x = x + ++y;
            //y = --x;
            //Console.WriteLine(x+y);
            //int i = 7;
            //bool uvjet = i == 7;
            //if (uvjet) 
            //{

            //    Console.WriteLine("1. Ušao sam u if granu");


            //}

            //int i = 5;
            //if (i == 1 )
            //{
            //    Console.WriteLine("i je 1");
            //}else if (i == 2 )

            //{
            //    Console.WriteLine("i je 2");


            //}
            //else
            //{
            //    Console.WriteLine("i nije 1 ni 2");
            //}


            // Console.WriteLine(i == 3 ? "i je 3" : "i nije 3");

            //int i = 2;

            //if (i == 1)
            //{
            //    Console.WriteLine("DOBAR");

            //}
            //else if (i == 2)
            //{
            //    Console.WriteLine("Loš");
            //}
            //else
            //{
            //    Console.WriteLine("Zao");
            //}
            //switch (i)
            //{
            //    case 1:
            //        Console.WriteLine("dobar");
            //        break;
            //    case 2:
            //        Console.WriteLine("Loš");
            //        break;
            //    case 3:
            //        Console.WriteLine("Zao");
            //        break;
            //    default:
            //        Console.WriteLine("Ostalo");
            //        break;
            //}
            //Console.WriteLine("Unesi ime grada");
            //string grad = Console.ReadLine();
            //switch (grad)
            //{
            //    case "Osijek":
            //    case "Vukovar":
            //        Console.WriteLine("Slavonija");
            //        break;
            //    case "Split":
            //    case "Zadar":
            //        Console.WriteLine("Dalmacija");
            //        break;

            //int[] Temperature = new int[12];
            //Temperature[0] = 1;
            //Temperature[Temperature.Length - 1] = 2;
            //Console.WriteLine(Temperature);
            //Console.WriteLine(string.Join(",", Temperature));
            //string[] Gradovi = new string[3];
            //Gradovi[0] = "Osijek";
            //Gradovi[1] = "Zagreb";
            //Gradovi[2] = "Donji Miholjac";
            //Console.WriteLine(string.Join(" ", Gradovi));
            //int[] brojevi = { 2, 3, 3, 4, 7, 5, 5, 4 };
            //Console.WriteLine(brojevi[4]);
            //Console.WriteLine(brojevi[brojevi.Length-1]);
            //int[,] tablica =
            //{
            //    {1,2,3},
            //    {4,5,6},
            //    {7,8,9},
            //};
            //Console.WriteLine(tablica[1,2]);
            //int[,,] kocka = new int[10,10,10];
            //int[,,,,,] zvjezdaneStaze;
            //ispiši samo j iz imena grada
            //string grad = "osijek";
            //Console.WriteLine(grad[3]);
            ////ispiši niz da brojevi budu jedan ispod drugog
            //int[] niz = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < niz.Length; i++)
            //{
            //    Console.WriteLine(niz[i]);
            //}
            //Console.WriteLine("unesi prvi broj: ");
            //int redova = int.Parse(Console.ReadLine());
            //Console.WriteLine("unesi drugi broj: ");
            //int stupova = int.Parse(Console.ReadLine());
            //int[,] tab = new int[redova, stupova];
            //int broj =redova*stupova;
            //int red = redova-1;
            //int stup = stupova-1;
            //string smjer = "lijevo";
            //for (int i = 1; i <= broj; i++)
            //{
            //    if (smjer == "desno" && (stup > stupova - 1 || tab[red, stup] != 0))
            //    {
            //        smjer = "dolje";
            //        stup--;
            //        red++;
            //    }
            //    if (smjer == "dolje" && (red > redova - 1 || tab[red, stup] != 0))
            //    {
            //        smjer = "lijevo";
            //        red--;
            //        stup--;
            //    }
            //    if (smjer == "lijevo" && (stup < 0 || tab[red, stup] != 0))
            //    {
            //        smjer = "gore";
            //        stup++;
            //        red--;
            //    }
            //    if (smjer == "gore" && (red < 0 || tab[red, stup] != 0))
            //    {
            //        smjer = "desno";
            //        red++;
            //        stup++;


            //    }
            //    tab[red, stup] = i;
            //    if (smjer == "desno")
            //    {
            //        stup++;
            //    }
            //    if (smjer == "dolje")
            //    {
            //        red++;
            //    }
            //    if (smjer == "lijevo")
            //    {
            //        stup--;
            //    }
            //    if (smjer == "gore")
            //    {
            //        red--;
            //    }

            //}

            //    for (int j = 0; j < redova; j++)
            //    {
            //        for (int k = 0; k < stupova; k++)
            //        {
            //            Console.Write("{0,4}", tab[j, k]);
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.ReadLine();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("\a");
            //    Thread.Sleep(1000);
            //}
            //int[] broj = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Unesi cijeli broj");
                
            //    broj[i] = int.Parse(Console.ReadLine());
            //}
            //foreach(var item in broj)
            //{
            //    Console.Write("{0,4}",item);
            //}


        }

    }
}
