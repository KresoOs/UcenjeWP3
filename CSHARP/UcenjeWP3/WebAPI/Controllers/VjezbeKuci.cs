using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("VjezbeKuci")]
    public class VjezbeKuci : ControllerBase
    {







        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad1")]
        public int Zad1()
        {
            // Ruta vraća najveći int broj
            return int.MaxValue;
        }

        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad2")]
        public float Zad2(int a, int b)
        {

            return a / (float)b + a * b;
        }

        //Ovdje završava ruta

        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad3")]
        public bool Zad3(int a, int b)
        {

            return a == b;
        }

        //Ovdje završava ruta

        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad4")]
        public string Zad4(string a, string b)
        {

            return a + " " + b;
        }

        //Ovdje završava ruta

        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad5")]
        public int Zad5(int a, int b)
        {
            int z = a + b;
            if (z % 2 == 0)
                return a * b;
            else return a + b;

        }

        //Ovdje završava ruta
        [HttpGet]
        [Route("zad6")]
        public string Zad6(int ocjena)
        {
            switch (ocjena)
            {
                case 1:
                    return "Nedovoljan";
                case 2:
                    return "Dovoljan";
                case 3:
                    return "Dobar";
                case 4:
                    return "Vrlo Dobar";
                case 5:
                    return "Odličan";
                default:
                    return "nije ocijena";

            }
        }

    }

}





