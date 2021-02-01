using System;

namespace PRN292_Lab2M_3_4_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountList list = new AccountList();
            while (true)
            {
                Console.WriteLine("\n======== ACCOUNT MANAGER ========");
                Console.WriteLine("\t1.Add account");
                Console.WriteLine("\t2.Show account");
                Console.WriteLine("\t3.Sort [IComparable]");
                Console.WriteLine("\t4.Remove account:");
                Console.WriteLine("\t5.Load file:");
                Console.WriteLine("\t6.Save file:");
                Console.WriteLine("\t7.Clear Console");
                Console.WriteLine("\t8.EXIT");
                Console.WriteLine("------------------------------");
                int choice = Validate.InputInt("Select your choice: ", 1, 8);
                switch (choice)
                {
                    case 1:
                        list.NewAccount();
                        break;
                    case 2:
                        list.Report();
                        break;
                    case 3:
                        list.SortList();
                        break;
                    case 4:
                        list.Remove();
                        break;
                    case 5:
                        list.LoadFile();
                        break;
                    case 6:
                        list.SaveFile();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Press any key to continue!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 8: return;
                }
            }
        }
    }
}
