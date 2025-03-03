using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Menu  
    {
        public void MenuyuGoster()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1 - Ogrenci Ekle");
            Console.WriteLine("2 - Ders Ekle");
            Console.WriteLine("3 - Ogrencileri Listele");
            Console.WriteLine("4 - Dersleri Listele");
            Console.WriteLine("9 - Programi Sonlandir");
            Console.WriteLine("---------------------------");
            Console.Write("Bir Secim Yapiniz: ");
 
        }   

        public void ProgramiKapat()
        {
            Console.Clear();
            Console.WriteLine("Iyı Gunler...");
            Console.ReadKey();
        }


        public int SecimiAl(out bool hataVerdi)
        {
            hataVerdi = false;
            int secim = 0;
             
            try
            {
                secim = Convert.ToInt32(Console.ReadLine());
                ;
            }
            catch (Exception)
            {
                HataMesajiGoster(0);
                hataVerdi = true;
            }

            return secim;
        }
        
         public void HataMesajiGoster(int hataKodu)
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
