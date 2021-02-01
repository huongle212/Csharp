using System.Collections.Generic;

namespace PRN292_Lab2M_3_4_Account
{
    class SortAccountId : Comparer<Account>
    {
        public override int Compare(Account x, Account y)
        {
            return x.accountId.CompareTo(y.accountId);
        }
    }
    class SortFirstName : Comparer<Account>
    {
        public override int Compare(Account x,Account y)
        {
            return x.firstName.CompareTo(y.firstName);
        }
    }
    class SortLastName : Comparer<Account>
    {
        public override int Compare(Account x, Account y)
        {
            return x.lastName.CompareTo(y.firstName);
        }
    }
    class SortBalance : Comparer<Account>
    {
        public override int Compare(Account x,Account y)
        {
            return x.balance.CompareTo(y.balance);
        }
    }
}
