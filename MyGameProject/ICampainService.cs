using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    interface ICampainService
    {
        void CampainAdd(Campain campain);
        void CampainDelete(Campain campain);
        void CampainUpdate(Campain campain);
    }
}
