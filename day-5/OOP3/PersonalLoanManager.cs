﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal Loan Calculated!");
        }
    }
}
