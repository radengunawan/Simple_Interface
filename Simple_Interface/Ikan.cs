using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Interface
{
    class Ikan : IMemangsa
    {
        public void caraMakan()
        {
            Console.WriteLine("Ikan bisa digoreng ato dibakar");

        }

         public void Memakan()
        {
            Console.WriteLine("Ikan suka memakan alga, atau ikan2 kecil");
        }

        public void Memburu() {
            Console.WriteLine("Ikan suka berburu alga, atau ikan2 kecil");
        }

        public void Menerkam()
        {
            Console.WriteLine("Ikan tidak bisa menerkam");
        }

    } //END class
}
