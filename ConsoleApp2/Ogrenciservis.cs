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
        List<int> intListesi = new List<int>();

        public Ogrenciservis()
        {
            for (int i = 0; i < 10; i++)
            {
                intListesi.Add(i);
            }
        }

        public void OgrenciEkle()
        {
            Console.Clear();
            Menu menu = new Menu();
            Ogrenci yeniOgrenci = new Ogrenci();

        ogrenciAd:
            Console.WriteLine("Ogrencinin adini giriniz:");
            Console.WriteLine("----------------------------------");
            yeniOgrenci.Ad = Console.ReadLine();
            Console.Clear();

            foreach (int sayi in intListesi)
            {
                if (yeniOgrenci.Ad.Contains(sayi.ToString()))
                {

                    menu.HataMesajiGoster(2);
                    goto ogrenciAd;
                }
            }
            Console.Clear();

        ogrenciSoyad:
            Console.WriteLine("Ogrencinin soyadini giriniz:");
            Console.WriteLine("----------------------------------");
            yeniOgrenci.Soyad = Console.ReadLine();
            Console.Clear();

            foreach (int sayi in intListesi)
            {
                if (yeniOgrenci.Soyad.Contains(sayi.ToString()))
                {

                    menu.HataMesajiGoster(2);
                    goto ogrenciSoyad;
                }
            }
        ogrenciNumarasi:
            Console.WriteLine("Ogrencinin numarasini giriniz:");
            Console.WriteLine("----------------------------------");

            try
            {
                yeniOgrenci.OgrenciNo = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
                menu.HataMesajiGoster(0);
                goto ogrenciNumarasi;
            }


            ogrenciListesi.Add(yeniOgrenci);
            Console.Clear();


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
