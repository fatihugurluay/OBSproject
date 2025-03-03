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
        List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
        List<Ders> dersListesi = new List<Ders>();
        List<int> intListesi = new List<int>();
        public OBS()
        {

            for (int i = 0; i < 10; i++)
            intListesi.Add(i);

        }


        public void SecimIslemiYap(int secim)
        {
            switch (secim)
            {
                case 1:
                    OgrenciEkle();
                    break;
                case 2:
                    DersEkle();
                    break;
                case 3:
                    OgrencileriListele();
                    break;
                case 4:
                    DersleriListele();
                    break;


            }
        }
        public void DersEkle()
        {
            Console.Clear();
            Menu menu = new Menu();
            Ders yeniDers = new Ders();
            //ders iceriklerini alma islemleri buraya yazilacaktir.

            Console.Clear();
        }

        public void DersleriListele()
        {
            Console.Clear();

            foreach (Ders ders in dersListesi) //ders icerikleri listelenecek
            {

            }

            Console.ReadKey();
            Console.Clear();
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
        