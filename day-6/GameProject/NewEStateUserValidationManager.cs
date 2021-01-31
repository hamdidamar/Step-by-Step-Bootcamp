using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class NewEStateUserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
