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
        DersListe dersListe = new DersListe();
        Ogrenciservis ogrenciServisi = new Ogrenciservis();
        List<Ders> dersListesi = new List<Ders>();
        public OBS()
        {

        }


        public void SecimIslemiYap(int secim)
        {
            switch (secim)
            {
                case 1:
                    ogrenciServisi.OgrenciEkle();
                    break;
                case 2:
                    dersListe.DersEkle();
                    break;
                case 3:
                    ogrenciServisi.OgrencileriListele();
                    break;
                case 4:
                    DersleriListele();
                    break;


            }
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
    }
}
        