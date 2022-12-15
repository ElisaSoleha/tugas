// Hello Word! Program

using System;

namespace DasPro
{
    class Program
    {  
         //Main Method
        static void Main(string[] args)
        { 
            int kesempatan = 3;
            //invote function method
            Intro();
            //bool bGameSelesai = PlayGame();
            while(kesempatan > 0){
                PlayGame();
                kesempatan = kesempatan - 1;
            }
        }
        static void Intro(){
            //intro
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapat kan data dari server");
            Console.WriteLine("Akses keserver membutuhkan password");
            Console.WriteLine("");

        }
        static void PlayGame(){

            //Deklarasi Variabel
            int kodeA;
            int kodeB;
            int kodeC;
            int jumlahkode;
            string tebakanA;
            string tebakanB;
            string tebakanC;

            int hasiltambah;
            int hasilkali;

            // Buat Random Number generator (RNG)
            Random rng = new Random();

            //Insialisasi Variabel
            kodeA = rng.Next(1,3);
            kodeB = rng.Next(1,3);
            kodeC = rng.Next(1,3);

            jumlahkode= 3;

            //operasi Arimatika
            hasiltambah = kodeA+kodeB+kodeC;
            hasilkali = kodeA*kodeB*kodeC;

            //Intro
            Console.WriteLine("Anda adalah agen rahasia yang bertugas untuk mendapatkan data");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("Password terdiri dari "+jumlahkode+" angka");
            Console.WriteLine("Jika ditambahkan hasilnya "+kodeB);
            Console.WriteLine("Jika dikalikan hasilnya "+kodeC);

            //output User
            Console.Write("Masukkan kode 1 : ");
            tebakanA = Console.ReadLine();
            Console.Write("Masukkkan kode 2 : ");
            tebakanB = Console.ReadLine();
            Console.Write("Masukkan kode 3 : ");
            tebakanC = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Tebakan Anda = "+tebakanA+""+tebakanB+""+tebakanC+" ? (ya/tidak)");

            //Konfirmasi
            String konfirmasi = Console.ReadLine();
            if(konfirmasi == "ya"){
                //logic
                if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString())
                {
                    Console.WriteLine("Selamat, tebakan anda benar");
                    //Return true;
                }else{
                    Console.WriteLine(" Sayang Sekali, Tebakan anda salah");
                    Console.WriteLine("kode yang benar adalah "+kodeA+""+kodeB+" "+kodeC+" .");
                    //return false;
                }
                    //PlayGame
                
            }
            //
            if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString())
            {
                Console.WriteLine("Selamat ,Tebakan Anda Benar!");
            } else {
                Console.WriteLine("Sayang Sekali, Tebakan Anda Salah!");
                Console.WriteLine("Kode yang benar adalah "+kodeA+" "+kodeB+" "+kodeC+" ." );
            }
       }

    }
}
