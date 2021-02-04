using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
