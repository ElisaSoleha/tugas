// Elisa Soleha
using System;
using System.Collections.Generic;

namespace Tebakkata
{
    class Program
    {
        static string KataRahasia = "Tokyo Revengers";
        static int Kesempatan = 5;
        static List<string> TebakanPemain = new List<string>{};

        static void Main(string[] args)
        {
            Intro();
            PlayGame();
            EndGame();
            

        }static void Intro()
        {

        Console.WriteLine(" Selamat Datang, Hari ini kita akan bermain Tebak Kata");
        Console.WriteLine($"Kamu punya {Kesempatan} untuk menebak kata misteri hari ini");
        Console.WriteLine("Petunjuk Dalam game ini adalah Judul Animasi");
        Console.WriteLine($"kata tersebut terdiri dari {KataRahasia.Length}");
        Console.WriteLine("Film apakah yang dimaksud?");

        Console.ReadKey();
        Console.WriteLine();

        }
        //Proses 
        static void PlayGame()
        {
            while(Kesempatan > 0)  
            {
                 Console.WriteLine("");
                 Console.Write("Apa Karakter Tebakanmu? (a-z) : ");
                 string input = Console.ReadLine();
                 TebakanPemain.Add(input);

                if(cekjawaban(KataRahasia,TebakanPemain))
                {
                    Console.WriteLine(".....");
                    Console.WriteLine("Selamat, Tebakan anda benar!!!");
                    Console.WriteLine($"Kata Rahasia hari ini : {KataRahasia} ");
                    break;
                }else if(KataRahasia.Contains(input))
                {
                    Console.WriteLine("Huruf itu ada didalam kata ini");
                    Console.WriteLine("Silahkan Tebak huruf lainnya");
                    Console.WriteLine(cekhuruf(KataRahasia,TebakanPemain));

                }else {
                    Console.WriteLine(".....");
                    Console.WriteLine("Huruf tidak ada...");
                    Kesempatan--;
                    Console.WriteLine($"Kesempatan Anda Tinggal {Kesempatan} ");
                }if(Kesempatan == 0){
                    Console.WriteLine("Mohon maaf Kesempatan Anda Habis");
                    Console.WriteLine($"Kata Rahasia Yang dimaksud adalah {KataRahasia}. ");
                    Console.WriteLine("Terima Kasih sudah Bermain");
                    break;
                }
                static bool cekjawaban(string KataRahasia, List<string> List){
                    bool status = false;
                    for(int i = 0; i < KataRahasia.Length; i++)
                    {

                        string c = Convert.ToString(KataRahasia[i]);
                        if(List.Contains(c))
                        {
                            status = true;
                        }else{
                            return status = false;
                        }
                    }
                    return status;
                }
                    static string cekhuruf(string KataRahasia,List<string>TebakanPemain){
                        string x = "";
                        for(int i = 0; i < KataRahasia.Length; i++)
                        {
                            string c = Convert.ToString(KataRahasia[i]);
                            if(TebakanPemain.Contains(c))
                            {
                                x = x + c;
                            }else{
                                x = x + ".";
                             }
                        }
                        return x;
                    }
                         
                }

            }
             //kata-kata akhir
            static void EndGame(){ 
            Console.WriteLine("");
            Console.WriteLine($"Jawaban dari Kata rahasia Adalah {KataRahasia} ");
            Console.WriteLine("");
        }

    }
}
