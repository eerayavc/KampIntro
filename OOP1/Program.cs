using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id=2,CategoryId=5,UnitsInStock=5,ProductName="Kalem",UnitPrice=35};

            //PascalCase    //camelCase
            //case sensitive
            //eşitliğin sol tarafı stack,sağ tarafı heap
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            //kamera

            //productManager.Topla(3, 6);

            ////bana topla değerini verip programın akışında kullanmam için int kullanmam lazm ama voidde sadece topla diye emir verir

            //int toplamaSonucu = productManager.Topla(3, 6);

            //Console.WriteLine(toplamaSonucu*2);   //ÜZERİNDE TEKRAR ÇALIŞMAK İÇN RETURN'LERİ KULLANIRIZ.EŞİTLİĞİN SAĞ TARAFI İNT'İN KENDİSİ


            //int,double,bool... değer tiplerdir
            //diziler,class,abstract class,interface...referans tiplerdir
            //sen sayıyı 100 diyer verdikten sonra artıkm o 100 ile eşleşir yani "int sayi" yi değiştirsen de bi ifade etmez.
            //Ama referans tiplerde bu söz konusu değildir .ona atadığın şeyi değiştirebilirsin.Atamalar bellekteki adresiyle yapılır
            //ref out keywords
        }
    }
}
