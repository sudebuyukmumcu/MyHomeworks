using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService//edevletin mernisini sumle ediyorum
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear== 1985 && gamer.FirstName=="Engin" && gamer.LastName=="Demirog"
                && gamer.IdentityNumber==12345)
                //bunu true veya false olarak döndürmek istiyorum. bu yüzden
                //IUserValidationService ı void i bool olarak değiştiriyorum
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
