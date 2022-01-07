using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day5Demo.BaseClassConstructor.Demo2
{
    /// <summary>
    /// 1. CurrentAccount: CompanyName, GSTNo, Minimum balance: 25000
    /// 2. SavingAccount: PANNo, Maintain Minimum balance: 1000. Max deposit not > 50000
    /// </summary>

    class Account
    {
        private string _accountNumber;
        private string _name;
        private double _balance;

        public Account(string accountNumber, string Name, double balance)
        {
            _accountNumber = accountNumber;
            _name = Name;
            _balance = balance;
        }

        // Getter => Simple function returns your private data.
        // Why? This provides a readonly view of your private data
        public string GetAccountNumber()
        {
            return _accountNumber;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (_balance - amount >= 0)
            {
                _balance -= amount;
                return true;
            }

            return false;
        }

        public string GetData()
        {
            return $"AccountNumber: {_accountNumber}, Name: {_name}, Balance: {_balance}";
        }
    }

    class BankBranch
    {
        List<Account> _accounts;

        public BankBranch()
        {
            _accounts = new List<Account>();
        }

        public void AddNewAccount()
        {
            Console.Write("Enter Account No: ");
            string accountNoText = Console.ReadLine();

            Console.Write("Enter Name: ");
            string nameText = Console.ReadLine();

            Console.Write("Enter Opening Balance: ");
            string openingBalanceText = Console.ReadLine();

            //Account account = new Account(accountNoText, nameText, int.Parse(openingBalanceText));
            Account account = new CurrentAccount(accountNoText, nameText, int.Parse(openingBalanceText), "aaa", "bbb");

            _accounts.Add(account);
        }

        public void DisplayAllAccounts()
        {
            foreach (Account account in _accounts)
                Console.WriteLine(account.GetData());
        }

        internal void Withdraw()
        {
            Console.Write("Enter account number: ");
            string accountNoText = Console.ReadLine();

            foreach (var account in _accounts)
            {
                if (account.GetAccountNumber() == accountNoText)
                {
                    Console.Write("Enter amount to Withdraw: ");
                    string amountText = Console.ReadLine();

                    account.Withdraw(int.Parse(amountText));
                    break;
                }
            }
        }

        internal void Deposit()
        {
            Console.Write("Enter account number: ");
            string accountNoText = Console.ReadLine();

            foreach (var account in _accounts)
            {
                if (account.GetAccountNumber() == accountNoText)
                {
                    Console.Write("Enter amount to Deposit: ");
                    string amountText = Console.ReadLine();

                    account.Deposit(int.Parse(amountText));
                    break;
                }
            }
        }
    }

    internal class BaseClassConstructorDemo2
    {
        public static void Test()
        {
            BankBranch bankBranch = new BankBranch();

            bankBranch.AddNewAccount();
            bankBranch.AddNewAccount();

            bankBranch.DisplayAllAccounts();

            bankBranch.Withdraw();
            bankBranch.Deposit();

            bankBranch.DisplayAllAccounts();
        }
    }
}
