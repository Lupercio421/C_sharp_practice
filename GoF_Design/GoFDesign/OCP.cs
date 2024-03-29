﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFDesign
{
    internal interface IAccount
    {
        //members and function declaration, properties
        decimal Balance { get; set; }
        decimal CalcInterest();
    }

    //regular savings account
    public class RegularSavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal CalcInterest() 
        {
            decimal Interest = (Balance * 4) / 100;
            if (Balance < 1000) Interest -= (Balance * 2) / 100;
            if (Balance < 50000) Interest += (Balance * 4) / 100;
            return Interest;
        }
    }

    //Salary savings account
    public class SalarySavingAccount : IAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 5) / 100;
            return Interest;
        }
    }

    //Corporate Account
    public class CorporateAccount : IAccount 
    { 
        public decimal Balance { get; set;} = 0; 
        public decimal CalcInterest()
        {
            decimal Interest=  (Balance * 3) / 100;
            return Interest;
        }
    }

    //This solves the problem of modification of class and by extending interface, we can extend functionality.
    //Above code is implementing both OCP and SRP principle, as each class has single is doing a single task and we are not modifying class and only doing an extension.
}
