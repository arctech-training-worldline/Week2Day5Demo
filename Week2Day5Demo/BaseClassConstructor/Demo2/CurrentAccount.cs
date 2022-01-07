using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Demo.BaseClassConstructor.Demo2
{
    /// <summary>
    /// 1. CurrentAccount: CompanyName, GSTNo, Minimum balance: 25000
    /// </summary>
    internal class CurrentAccount : Account
    {
        public const int MinimumBalance = 25000;

        private string _companyName;
        private string _gstNo;

        public CurrentAccount(string accountNumber, string name, double balance, string companyName, string gstNo) : base(accountNumber, name, balance)
        {
            _companyName = companyName;
            _gstNo = gstNo;
        }
    }
}
