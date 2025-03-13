using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class DersServis
    {
        List<Ders> dersListesi = new List<Ders>();
        public void DersEkle()
        {
            Console.Clear();

            Ders yeniDers = new Ders();

            //ders iceriklerini alma islemleri buraya yazilacaktir.

            Console.Clear();

        }
        public List<Ders> DersListesi()
        {
            return dersListesi;
        }
    }
}

