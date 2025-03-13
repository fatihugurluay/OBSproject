using ConsoleApp2.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Ogrenciservis
    {
        List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
        List<Ders> dersListesi = new List<Ders>();

        public void OgrenciEkle()
        {
            Console.Clear();
            Menu menu = new Menu();
            Ogrenci yeniOgrenci = new Ogrenci();

        ogrenciAd:
            Console.WriteLine("Ogrencinin adini giriniz:");
            Console.WriteLine("----------------------------------");
            yeniOgrenci.Ad = Console.ReadLine();

            if (!Yazi.YaziMi(yeniOgrenci.Ad))
            {
                Hata.HataMesajiGoster(2);
                goto ogrenciAd;
            }
            Console.Clear();

        ogrenciSoyad:
            Console.WriteLine("Ogrencinin soyadini giriniz:");
            Console.WriteLine("----------------------------------");
            yeniOgrenci.Soyad = Console.ReadLine();
            if (!Yazi.YaziMi(yeniOgrenci.Soyad))
            {
                Hata.HataMesajiGoster(2);
                goto ogrenciSoyad;
            }
                Console.Clear();

        ogrenciNumarasi:
            Console.WriteLine("Ogrencinin numarasini giriniz:");
            Console.WriteLine("----------------------------------");

            try
            {
                yeniOgrenci.OgrenciNo = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
                Hata.HataMesajiGoster(0);
                goto ogrenciNumarasi;
            }


            ogrenciListesi.Add(yeniOgrenci);
            Console.Clear();
        }

        public List<Ogrenci> OgrenciList()
        {
            return ogrenciListesi;
        }

        public void OgrencileriListele()
        {
            Console.Clear();

            foreach (Ogrenci ogrenci in ogrenciListesi)
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
