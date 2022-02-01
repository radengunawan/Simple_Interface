using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Interface
{
    class Elang : IMemangsa
    {
        public void Memburu()
        {
            Console.WriteLine("Elang suka berburu di hutan atau perairan");

        }
        public void Menerkam()
        {
            Console.WriteLine("Elang suka nerkam lawan pake kaki-nya");
        }
        public void Memakan()
        {
            Console.WriteLine("Elang memakan mangsa setelah mangsa dipastikan mati");
        }
    }
}
