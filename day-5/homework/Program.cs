using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Game game1 = new Game();
            Campaign campaign1 = new Campaign();
            OrderManager orderManager = new OrderManager();
            EStateManager eStateManager = new EStateManager();

            player1.Id = 1;
            player1.Name = "name1";
            player1.Surname = "surname1";
            player1.TurkishIdentityNumber = "12312312";
            player1.DateOfBirth = DateTime.Parse("01/01/1990");
            player1.PlayerId = 1;
            player1.Nickname = "nickname1";
            player1.Username = "username";
            player1.Password = "password";

            game1.Id = 1;
            game1.Name = "game 1";

            campaign1.Id = 1;
            campaign1.Name = "Summer";

            eStateManager.CheckInformation(player1);
            eStateManager.Log();

            orderManager.CreateOrder(player1, campaign1, game1);
            orderManager.Log();

            


        }
    }
}
