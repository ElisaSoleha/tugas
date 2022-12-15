//GAME TANK
using System;

namespace battletank
{
    class Program
    {
        static void Main(string[] args)
        {
            //inisailisai variabel yang dibutuhkan
            int panjangarea = 5;
            char rumput = '~';
            char tank = 't';
            char hit = 'X';
            char miss = 'O';
            int jumlahtank = 3;

            char[,] playarea = buatruang(panjangarea, rumput, tank, jumlahtank);

            printarea(playarea, rumput, tank);
            int jumlahtanktersembunyi = jumlahtank;

            //Gameplay
            while(jumlahtanktersembunyi>0){
                int[] tebakankoordinat = getkoordinattebakan(panjangarea);
                char updatetampilanarea = verifikasitebakan(tebakankoordinat,playarea , tank, rumput, hit, miss);
                if(updatetampilanarea == hit){
                    jumlahtanktersembunyi--;
                }
                playarea = updatearea(playarea, tebakankoordinat, updatetampilanarea);
                printarea(playarea,rumput,tank);
            }
            Console.WriteLine("GAMEOVER");
            Console.ReadLine();
        }

        //membuat area permainan
        static char[,] buatruang(int panjangarea, char rumput, char tank, int jumlahtank){
            char[,] ruangan = new char[panjangarea,panjangarea];

            for(int baris = 0; baris < panjangarea; baris++){
                for(int kolom = 0; kolom < panjangarea; kolom++){
                    ruangan[baris,kolom] = rumput;
                }
            }
            return letakkantank(ruangan,jumlahtank, rumput,tank);
        }
        // meletakkan tank dalam area
        static char[,] letakkantank(char[,] ruangan, int jumlahtank, char rumput, char tank){
            int letaktank = 0;
            int panjangarea = 5;

            while(letaktank<jumlahtank){
                int[] lokasitank = tentukankoordinattank(panjangarea);
                char posisi = ruangan[lokasitank[0],lokasitank[1]];

                if(posisi == rumput){
                    ruangan[lokasitank[0], lokasitank[1]] = tank;
                    letaktank++;
                }
            }
                return ruangan;
        }
        // menentukan posisi koordinat tank (y,x) secara acak
         static int[] tentukankoordinattank(int panjangarea){
            Random rng = new Random();
            int[] koordinat = new int [2];
            for(int i = 0; i < koordinat.Length; i++)
            {
                koordinat[i] = rng.Next(panjangarea);// x = random(0,4); y = random(0,4)
            }
            return koordinat;
         }
            // menampilkan area permainan ke console
            static void printarea(char[,] playarea, char rumput, char tank){

                Console.Write(" ");
                for(int i = 0; i < 5; i++)
                {
                    Console.Write(i + 1 +" ");//12345
                }
                Console.WriteLine();

                for(int baris = 0; baris < 5; baris++)
                {
                    Console.Write(baris + 1 + " ");
                    for(int kolom = 0; kolom < 5; kolom++)
                    {
                        char posisi = playarea[baris,kolom];

                        if(posisi == tank){
                            Console.Write(rumput + " ");
                        }else{
                            Console.Write(posisi + " ");
                        }

                    }
                    Console.WriteLine();
                }
            }
            // Tebakan koordinat pemain
            static int[] getkoordinattebakan(int panjangarea){
                int baris;
                int kolom;

                do{
                    Console.Write("Pilih Baris : ");
                    baris = Convert.ToInt32(Console.ReadLine());
                
                }while(baris<0 || baris>panjangarea + 1);

                do{
                    Console.Write("Pilih Kolom : ");
                    kolom = Convert.ToInt32(Console.ReadLine());
                }while(kolom<0 || kolom>panjangarea +1);

                return new[] {baris-1,kolom-1};
            }
            //verifikasi tebakan pemain
            static char verifikasitebakan(int[] tebakan, char[,] playarea, char tank, char rumput,
             char hit, char miss){

                string pesan;
                int baris = tebakan[0];
                int kolom = tebakan[1];
                char target = playarea[baris,kolom];

                if(target == tank){
                    pesan="GOOD!!! TEPAT SASARAN!!";
                    target=hit;

                }else if(target == rumput){
                    pesan="SAYANG SEKALI!!! MELESET!!!, Ayo Tebak Lagi!!";
                    target=miss;
                }else{
                    pesan="Area ini Aman";
                }
                Console.WriteLine(pesan);
                Console.WriteLine("");
                return target;
                }
                static char[,]updatearea(char[,] playarea, int[] tebakankoordinat, char updatetampilanarea){
                    int baris = tebakankoordinat[0];
                    int kolom = tebakankoordinat[1];
                    playarea[baris,kolom] = updatetampilanarea;
                    return playarea;
                }
            }

        
    }


