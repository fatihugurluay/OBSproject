using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Hata
    {
        public static void HataMesajiGoster(int hataKodu)
        {
            switch (hataKodu)
            {
                case 0: //sayi yerine harf girme hatasi
                    Console.Clear();
                    Console.WriteLine("Bir sayi girmeniz gerekmektedir, uygun olmayan bir giris yaptiniz. Lutfen tekrar deneyiniz.");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 1: //var olmayan bir secenek secme hatasi
                    Console.Clear();
                    Console.WriteLine("Var olmayan bir secenegi sectiniz. Lutfen tekrar deneyiniz.");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 2: //Ad veya soyadin rakam icerme hatasi
                    Console.Clear();
                    Console.WriteLine("Ad veya soyad rakam iceremez. Lutfen tekrar deneyiniz.");
                    Console.ReadKey();
                    Console.Clear();
                    break;

            }
        }
    }
}
