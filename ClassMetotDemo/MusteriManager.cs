using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + "isimli" + " - " + musteri.Id + " " + " - " + "IDLİ MÜŞTERİ EKLENDİ"); 
        }
         
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + "iSİMLİ" + " - " + musteri.Id + " " + " IDLİ MÜŞTERİ ÇIKARILDI" );
                
        }

        public void Liste(Musteri[] musteri)
        {
            foreach (var Liste in musteri )
            {
                Console.WriteLine("AD SOYAD : " + Liste.Ad);
                Console.WriteLine("Id : " + Liste.Id);
                
            }

        }
        
    }
}
