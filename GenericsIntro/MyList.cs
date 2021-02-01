using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // Burada program.cs içinde string mylist oluşturduk.
        //bunu newlediğimiz zaman direk 13.satırda olan constructor çalışır.Constructer olduğunu classla aynı isim olmasından anlıyoruz.
    {
        T[] items;
        //constructor
        //bir arrrayın newlenme zorunluluğu vardır.
        public MyList() //paranetez içerisinde olduğundan bu da bir metod
        {
            items = new T[0];  //ilk etapta steack'da istems diye ilk kez sıfır elemanları new oluşturuyoruz,mylisti newliyoruz
        }
        public void Add(T item) //yeni bir eleman eklemek için bu yapıyı kurduk
        {
            T[] tempArray = items;
            //tempArray diye bir geçici dizi oluşturuyorum ki newlediğimde eski elemanlarım silinmesin.


            items = new T[items.Length + 1];//dizinin elemanlarını bir atttırarak devam ediyoruz


            for (int i = 0; i < tempArray.Length; i++)   //emaneten verdiğimiz elemanları geri almak için for döngüsü kuruyoruz.
                //tempArrayın bütün elamanlarını itemse geri atayacağız.
            {
                items[1] = tempArray[i]; //itemsimin birinci elemanı tempArraydan gelen birinci elemanım
            } 

            items[items.Length - 1] = item; //aslında eklenmek istenen elamanı şuanda ekliyorum
            //örneğin 6 elemanlıysa length eleman sayısını verir.Bir eksiği de 5.indeksi verir.
        }
    }
}
