using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Cencrete
{
     class CampainManager : ICampainService
    {
        public void CampainDelete()
        {
            Console.WriteLine("Kampanya Silindi");
        }
        public void CampainUpdate()
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
        public void NewCampain()
        {
            Console.WriteLine("Yeni Kampanya Oluşturuldu");
        }

    }
}
