using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Cencrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FırstName == "ENGİN" && gamer.LastName == "DEMİROĞ" && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else { return false; }
        }
    }
}
