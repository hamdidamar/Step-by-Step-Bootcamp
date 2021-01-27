using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    interface IEStateService : ILoggerService
    {
        void CheckInformation(Customer customer);
    }
}
