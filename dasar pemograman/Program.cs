// hello word! program
using System;

namespace DasPro
{
    class Program
    {

        //Main Method
        /*
        */
        static void Main(string[] args)
        {
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

            //Inisialisasi Variabel
            kodeA= 4;
            kodeB= 8;
            kodeC= 16;

            jumlahkode = 3;

            //operasi aritmatika
            hasiltambah = kodeA+kodeB+kodeC;
            hasilkali = kodeA*kodeB*kodeC;
        

            //Intro
            Console.WriteLine("anda adalah agen rahasia yang bertugas mrndapatkan data");
            Console.WriteLine("akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("password terdiri dari "+kodeA+" angka");
            Console.WriteLine("Jika ditambahkan hasilnya"+kodeB);
            Console.WriteLine("Jika dikalikan hasilnya"+kodeC);

            //Input User
            Console.Write("Masukkan kode 1 :  ");
            tebakanA = Console.ReadLine();
            Console.Write("Masukkkan kode 2 : ");
            tebakanB = Console.ReadLine();
            Console.Write("Masukkan kode 3 :  ");
            tebakanC = Console.ReadLine();


             Console.WriteLine("Tebakan anda =  "+tebakanA+""+tebakanB+""+tebakanC+" ?");

             if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString())
             {
                Console.WriteLine("tebakan anda benar!");
             }else{
                Console.WriteLine(" tebakan anda salah!");
             }

        
        }
    }

}

