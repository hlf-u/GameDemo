using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.FirstName=="Halef" && user.LastName=="Uludağ" && user.BirthYear==1997 && user.NationaltyId==00001 )
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
