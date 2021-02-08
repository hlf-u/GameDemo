using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class UserManager : IUserService
    {
        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName+" "+user.LastName+": "+"Kayıt Silindi.");
        }

        public void SignUp(User user)
        {
            if (_userValidationService.Validate(user))
            {
                Console.WriteLine(user.FirstName + " " + user.LastName + ": "+"Kayıt Başarılı.");
            }
            else
            {
                Console.WriteLine(user.FirstName + " " + user.LastName + ": "+"Kayıt Başarısız.");
            }
        }

        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + ": " + "Kayıt Güncellendi.");
        }
    }
}
