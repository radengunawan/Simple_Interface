using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Interface
{
    class Kelinci : IKabur
    {
        public void MendengarLawan()
        {
            Console.WriteLine("Kelinci dengar suara aneh");
        }

        public void MelihatLawan()
        {
            Console.WriteLine("Kelinci melihat sekeliling");
        }

        public void Menghindar()
        {
            Console.WriteLine("Kelinci mulai langkahkan kaki ke arah yg kosong");
        }

        public void MengecohLawan()
        {
            Console.WriteLine("Kelinci membuat suara gemuruh");
        }

        public void MemilihJalan()
        {
            Console.WriteLine("Kelinci memilih jalan2 sempit");
        }

        public void Melawan()
        {
            Console.WriteLine("Kelinci mengigit lawan");
        }



    }//END class
} //END namespace
