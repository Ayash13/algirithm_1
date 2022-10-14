using System;
namespace algirithm_1
{
    class program
    {
        static void Main(string[] args)
        {
            //Memasukan angka ke dalamn array
            int[] ayash = { 5,7,1,2,9,3,11,10,12,4,6 };
            int tukar;
            //Passes 1 (n-1)
            for (int MA = 0; MA <= ayash.Length - 2; MA++)
            {
                //Membandingkan n-i pertama dengan yang selanjutnya
                for (int i = 0; i <= ayash.Length - 2; i++)
                {
                    //Jika angka di dalam array tidah urut
                    if (ayash[i] > ayash[i + 1])
                    {
                        //Maka tukar angka
                        tukar = ayash[i + 1];
                        ayash[i + 1] = ayash[i];
                        ayash[i] = tukar;

                    }
                }
            }
            //Print caption
            Console.WriteLine("Diurutkan : ");
            //Memanggil hasil perhitungan yang sudah urut
            foreach (int urutan in ayash)
            {
                Console.Write(urutan + " ");
            }  
            Console.Read();
        }
    }
}