﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        public double WithDraw { get; set; }
        public double Deposit { get; set; }
        public string AcctType { get; set; }

        public Account()
        {

        }

        public double Withdraw(double value)
        {
            return value;
        }

        public double DePosit(double value)
        {
            return value;
        }

        
    }
}
