using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IUserService
    {
        void SignUp(User user);
        void Update(User user);
        void Delete(User user);
       
    }
}
