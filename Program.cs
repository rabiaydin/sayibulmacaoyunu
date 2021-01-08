using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayibulmacaoyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int uretilenSayi = rnd.Next(1, 100);
            bool sayiBulunduMu = false;
            Console.WriteLine("Sayı Tahmin Etme Oyununa Hoşgeldiniz....");
            

            while (true)
            {
                
                while (!sayiBulunduMu)
                {
                    Console.WriteLine("Tahmininizi girin:");
                    int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());

                    if (uretilenSayi < tahminEdilenSayi)
                    {
                        Console.WriteLine(" Aşağı");
                    }

                    else if (uretilenSayi > tahminEdilenSayi)
                    {
                        Console.WriteLine("Yukarı");
                    }

                    else
                    {
                        Console.WriteLine("Sayıyı buldunuz!!! :)");
                        sayiBulunduMu = true;
                    }  
                }
                

             
                 Console.WriteLine("Tekrar oynamak için E-e tuşuna çıkmak için H-h tuşuna basınız.");
                string evet = Console.ReadLine();

                if (evet=="E" || evet=="e")
                {
                    Console.Clear();
                    uretilenSayi = rnd.Next(100);
                    sayiBulunduMu = false;
                }
                else if(evet == "H" || evet == "h")
                {
                    Console.WriteLine("Oyundan çıktınız...");
                    break;
                }    
            }
            Console.ReadLine();
        }
    }
}
