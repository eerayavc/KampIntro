using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //diğer öğrencilerden yardım alarak çözdüm bazı yerleri yapamadım tekrar kaydı izleyeceğim


            Musteri musteri1 = new Musteri();
            musteri1.Id = 555;
            musteri1.Ad = "Eray";
            musteri1.Soyad = "Avcı";
            musteri1.Adres = "Ankara";
            musteri1.KrediPuani = 95;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 444;
            musteri2.Ad = "Emir";
            musteri2.Soyad = "Koca";
            musteri2.Adres = "Mersin";
            musteri2.KrediPuani = 90;
            
            Musteri musteri3 = new Musteri();
            musteri3.Id = 333;
            musteri3.Ad = "Yiğit";
            musteri3.Soyad = "Ay";
            musteri3.Adres = "İzmir";
            musteri3.KrediPuani = 93;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("**-*-** In order to start the app press 'Enter' **-*-**");
            Console.WriteLine("**-*-** Keep pressing 'Enter' after each action takes place. **-*-**");
            Console.ReadKey();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Liste(musteriler);
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);


        }
    }
}
