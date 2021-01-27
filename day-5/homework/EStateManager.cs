using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class EStateManager : IEStateService
    {
        public void CheckInformation(Customer customer)
        {
            Console.WriteLine("Information checked : "+customer.Name);
        }

        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }
}
