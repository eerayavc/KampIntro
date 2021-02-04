using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class CampainManager : ICampainService
    {
        public void CampainDelete(Campain campain)
        {
            Console.WriteLine("Kampanya silindi!");
        }

        public void CampainUpdate(Campain campain)
        {
            Console.WriteLine("Kampanya güncellendi!");
        }

        public void CampainAdd(Campain campain)
        {
            Console.WriteLine("Yeni kampanya eklendi!");
        }
    }
}
