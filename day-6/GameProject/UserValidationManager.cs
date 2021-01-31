using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="gamer1")
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
