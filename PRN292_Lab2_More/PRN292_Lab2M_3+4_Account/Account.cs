using System;

namespace PRN292_Lab2M_3_4_Account
{
    class Account : IAccount, IComparable
    {
        public string accountId;
        public string firstName;
        public string lastName;
        public double balance;

        string IAccount.accountId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IAccount.firstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IAccount.lastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double IAccount.balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value < 0) balance = 0;
                else balance = value;
            }
        }

        public Account()
        {
            balance = 0;
        }

        public Account(string accountId, string firstName, string lastName, double balance)
        {
            this.accountId = accountId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public void FillInfo()
        {
            accountId = Validate.InputString("\tAccount Id: ");
            firstName = Validate.InputString("\tFirst name: ");
            lastName = Validate.InputString("\tLast name: ");
            balance = Validate.InputDouble("\tBalance: ", 0);
            Console.WriteLine("------------------------------");
        }

        public void Query()
        {
            Console.WriteLine($"{accountId}\t{firstName}\t{lastName}\t{balance}");
        }

        public int CompareTo(Object other)
        {
            if(other ==null)
                throw new NotImplementedException();
            Account acc = (Account)other;
            if (accountId.CompareTo(acc.accountId)==0)
            {
                if(firstName.CompareTo(acc.firstName) == 0)
                {
                    return balance.CompareTo(acc.balance);
                }
                return firstName.CompareTo(acc.firstName);
            }
            return accountId.CompareTo(acc.accountId);
        }
    }
}