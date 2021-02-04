using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    //MicroService--- gamermanager içerisinde başka bir servis kullanacağız
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService) //şuan gamermanagera bağlılığı var
        {
            _userValidationService = userValidationService;  //asla kimlik paylaşma servisi değil onun soyutu
            //sistem değiştiğinde herhangi biir problem olmaması için constructo yapısına alıyoruz.
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) ==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.Kayıt oluşturulamadı");
            }

           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
