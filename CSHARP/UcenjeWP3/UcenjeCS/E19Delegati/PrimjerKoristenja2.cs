﻿namespace UcenjeCS.E19Delegati
{
    internal class PrimjerKoristenja2
    {

        public PrimjerKoristenja2()
        {
            var os = new ObradaSmjer();
            os.IspisSmjer(NijeBitno);
        }

        private void NijeBitno(Smjer s)
        {
            Console.WriteLine("2 " + s.Naziv);
        }

    }
}
