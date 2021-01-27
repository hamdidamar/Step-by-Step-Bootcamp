using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager personalLoanManager = new PersonalLoanManager();
            //personalLoanManager.Calculate();

            ILoanManager vehicleLoanManager = new VehicleLoanManager();
            //vehicleLoanManager.Calculate();

            ILoanManager mortgageLoanManager = new MortgageLoanManager();
            //mortgageLoanManager.Calculate();

            RecourseManager recourseManager = new RecourseManager();

            recourseManager.MakeRecourse(personalLoanManager,new List<ILoggerService> {new DatabaseLoggerService()});
            recourseManager.MakeRecourse(vehicleLoanManager, new List<ILoggerService> { new FileLoggerService() });
            recourseManager.MakeRecourse(new ArtisanLoanManager(), new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });
            //recourseManager.MakeRecourse(mortgageLoanManager);

            List<ILoanManager> loans = new List<ILoanManager> { personalLoanManager , vehicleLoanManager , mortgageLoanManager };
            //recourseManager.giveInformation(loans);
        }
    }
}
