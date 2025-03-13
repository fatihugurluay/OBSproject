using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class OBS
    {
        Ogrenciservis ogrenciServisi = new Ogrenciservis();
        DersServis dersservisi = new DersServis();

        public void SecimIslemiYap(int secim)
        {
            switch (secim)
            {
                case 1:
                    ogrenciServisi.OgrenciEkle();
                    break;
                case 2:
                    dersservisi.DersEkle();
                    break;
                case 3:
                    OgrencileriListele();
                    break;
                case 4:
                    DersleriListele();
                    break;


            }
        }

        public void DersleriListele()
        {
            Console.Clear();

            foreach (Ders ders in dersservisi.DersListesi())
            {

            }

            Console.ReadKey();
            Console.Clear();
        }
        public void OgrencileriListele()
        {
            Console.Clear();

            foreach (Ogrenci ogrenci in ogrenciServisi.OgrenciList())
            {
                Console.WriteLine("Ogrenci Adi: " + ogrenci.Ad);
                Console.WriteLine("Ogrenci Soyadi: " + ogrenci.Soyad);
                Console.WriteLine("Ogrenci Numarasi: " + ogrenci.OgrenciNo);
                Console.WriteLine("---------------------------------------------");

            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
        