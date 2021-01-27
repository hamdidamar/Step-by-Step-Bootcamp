using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class OrderManager:ILoggerService
    {
        public void CreateOrder(Player player,Campaign campaign,Game game)
        {
            Console.WriteLine(player.Name + " buy " + game.Name);
        }

        public void Log()
        {
            Console.WriteLine("Order logged");
        }
    }
}
