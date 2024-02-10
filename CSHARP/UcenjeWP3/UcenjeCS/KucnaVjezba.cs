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
            Console.WriteLine("Unesi ime grada");
            string grad = Console.ReadLine();
            switch (grad)
            {
                case "Osijek":
                case "Vukovar":
                    Console.WriteLine("Slavonija");
                    break;
                case "Split":
                case "Zadar":
                    Console.WriteLine("Dalmacija");
                    break;

            }
        }

    }
}
