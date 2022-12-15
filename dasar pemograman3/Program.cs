// Game Dadu
using System;

namespace DaduGame
{
    class program
    {
        static void Main(String[] args)
        {
            //invote function method
            Intro();
            PlayGame();
        }

        static void Intro(){
            // Intro 
            Console.WriteLine("....");
            Console.WriteLine("Jadi kita akan memulai permainan Dadu.");
            Console.WriteLine("Semoga kamu menang dalam permainan ini.");
            Console.WriteLine("Jika kamu kalah maka itu bukan akhir dari permainan,");
            Console.WriteLine("Coba lagi dan Semangat!!!");
            Console.WriteLine("");
            
        }
        static void PlayGame(){
            
            int PemainRandom;
            int KomputerRandom;

            int PoinKamu = 0;
            int KomputerPoin = 0;

            Random random = new Random();
            

            for (int i = 0; i < 10; i++)
    
            
            {
                //Game dimulai

                Console.WriteLine("Tekan tombol apa saja untuk mengulirkan dadu.");

                Console.ReadKey();


                 PemainRandom = random.Next(1, 7);
                 Console.WriteLine("Kamu Bergulir "+PemainRandom);

                 Console.WriteLine("...");
                 System.Threading.Thread.Sleep(1000);
                

                 KomputerRandom = random.Next(1, 7);
                 Console.WriteLine("Komputer Bergulir "+KomputerRandom);

                 if (PemainRandom > KomputerRandom)
                 {
                    PoinKamu++;
                    Console.WriteLine("Kamu Menang di Ronde ini!!");
                 }
                 else if ( PemainRandom < KomputerRandom)
                 {
                    KomputerPoin++;
                    Console.WriteLine("Komputer Menang di Ronde ini!!!");
                 }
                 else 
                 {
                    Console.WriteLine("Seri!!");
                 }

                 Console.WriteLine("skor saat ini");
                 Console.WriteLine("Kamu : "+PoinKamu+". Komputer : "+KomputerPoin+". ");
                 Console.WriteLine();

            }

            if (PoinKamu > KomputerPoin)
            {
                Console.WriteLine("Selamat Kamu Menang!!!");
                Console.WriteLine("Ayo Main Lagi!!!");
                Console.WriteLine();
            }
            else if (PoinKamu < KomputerPoin)
            {
                Console.WriteLine("Sayang Sekali Kamu Kalah!!!");
                Console.WriteLine("Nice Try, Semangat!!!");
                Console.WriteLine();
            }
            else
            {
               Console.WriteLine("Ini Seri!!"); 
               Console.WriteLine("Ayo Main Lagi!!!");
               Console.WriteLine ("");
            }
            do{
                Console.WriteLine("Tekan Enter Untuk Melanjutkan Permaina");
            }while{
                
            }
            Console.ReadKey();
    


        } 

    }
}


 
