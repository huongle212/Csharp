using System;
using System.Collections;
using System.IO;

namespace PRN292_Lab2M_3_4_Account
{
    class AccountList
    {
        ArrayList list = new ArrayList();

        public void NewAccount()
        {
            Account acc = new Account();
            acc.FillInfo();
            while (checkAccountIdExist(acc.accountId) != -1)
            {
                Console.WriteLine("Sorry, this accound id already exists. Press 0 to try again!");
                if (Console.ReadLine().Trim().Equals("0"))
                {
                    acc.FillInfo();
                }
                else return;
            }
            list.Add(acc);
        }

        public void Report()
        {
            if (list.Count > 0)
            {
                Console.WriteLine("------------ List Account ------------");
            }
            else
            {
                Console.WriteLine("Empty List!");
            }
            foreach (Account acc in list)
                acc.Query();
        }

        public void SaveFile()
        {
            string filename = Validate.InputString("Input file name to save: ");
            //read file
            try
            {
                FileStream output = new FileStream(filename, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(output);
                foreach(Account acc in list)
                {
                    writer.WriteLine($"{acc.accountId},{acc.firstName},{acc.lastName},{acc.balance}");
                }
                writer.Close();
                output.Close();
                Console.WriteLine("Done!");
            }
            catch(IOException e){
                Console.WriteLine(e.Message);
            }
        }

        public void LoadFile()
        {
            string filename = Validate.InputString("Input file name to load: ");
            //clear list
            list.Clear();
            try
            {
                FileStream input = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);
                string str;
                while ((str=reader.ReadLine())!=null)
                {
                    string[] attribute = str.Split(',');
                    Account acc = new Account(attribute[0], attribute[1],attribute[2],double.Parse(attribute[3]));
                    list.Add(acc);
                }
                reader.Close();
                input.Close();
                Console.WriteLine("Done!");
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Remove()
        {
            Account acc = new Account();
            string accountId = Validate.InputString("Enter account id to remove: ");
            int index = checkAccountIdExist(accountId);
            if (index < 0 || index >= list.Count) Console.WriteLine("Not exist this account id.");
            else
            {
                list.RemoveAt(index);
                Console.WriteLine("Removed success");
            }
        }

        public void SortList()
        {
            list.Sort();
            Console.WriteLine("\nAfter sort:\n");
            Report();
        }

        public int checkAccountIdExist(string accountId)
        {
            int index = -1;
            accountId = accountId.ToLower();
            foreach(Account acc in list)
            {
                if ((acc.accountId.ToLower()).Equals(accountId)) return list.IndexOf(acc);
            }
            return index;
        }
    }
}
