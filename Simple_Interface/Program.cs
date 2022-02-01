using System;

namespace Simple_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
           Ikan ikn = new Ikan();

            //ikn.caraMakan();

            //Elang eln = new Elang();

            //Console.WriteLine("Eagle strategies:");
            //eln.Memburu();
            //eln.Menerkam();
            //eln.Memakan();
            //Kelinci klc = new Kelinci();

            //Console.WriteLine("Rabbit strategies");
            //klc.MendengarLawan();
            //klc.MelihatLawan();
            //klc.Menghindar();
            //klc.MengecohLawan();
            //klc.MemilihJalan();
            ikn.Memakan();
            ikn.caraMakan();
            ikn.Menerkam();
            ikn.Memburu();

        }
    }
}
