using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class RecourseManager
    {
        public void MakeRecourse(ILoanManager loanManager, List<ILoggerService> loggerServices)
        {
            loanManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }

        public void giveInformation(List<ILoanManager> loanManagers)
        {
            foreach (var loan in loanManagers)
            {
                loan.Calculate();
            }
        }
    }
}
