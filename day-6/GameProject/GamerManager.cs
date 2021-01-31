using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidation _userValidation;
        public GamerManager(IUserValidation userValidation)
        {
            _userValidation = userValidation;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidation.Validate(gamer))
            {
                Console.WriteLine("Eklendi!");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt Yapılamadı!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Silindi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Güncellendi!");
        }
    }
}
