using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Demo.BaseClassConstructor.Demo2
{
    /// <summary>
    /// 2. SavingAccount: PANNo, Maintain Minimum balance: 1000. Max deposit not > 50000
    /// </summary>
    internal class SavingsAccount : Account
    {
        public const int MinimumDepositBalance = 1000;
        public const int MaximumDepositBalance = 50000;

        private string _panNumber;

        public SavingsAccount(string accountNumber, string name, double balance, string panNumber)
            : base(accountNumber, name, balance)
        {
            _panNumber = panNumber;
        }        
    }
}
