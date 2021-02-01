namespace PRN292_Lab2M_3_4_Account
{
    interface IAccount
    {
        string accountId { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        double balance { get; set; }
        void FillInfo();
        void Query();
    }
}
