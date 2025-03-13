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
                Hata.HataMesajiGoster(0);
                hataVerdi = true;
            }

            return secim;
        }
         
        }
    }
