using System;
using System.Collections;

namespace PRN292_Lab2M_1_2_Book
{
    class BookList
    {
        private ArrayList list = new ArrayList();

        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
        }

        public void ShowList()
        {
            foreach (Book b in list)
                b.Show();
            Console.ReadLine();
        }

        public void InputList()
        {
            int n = Inputer.InputInt("Number of books in list: ");
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Input book {i}");
                AddBook();
            }
        }

        public void GUI()
        {
            while (true)
            {
                Console.WriteLine("======== BOOK MANAGER ========");
                Console.WriteLine("1.Add book");
                Console.WriteLine("2.Show book");
                Console.WriteLine("3.Sort book by Title [IComparable]");
                Console.WriteLine("4.Sort book by Author [Comparer]");
                Console.WriteLine("5.Sort book by Year [Comparer]");
                Console.WriteLine("6.Clear Console");
                Console.WriteLine("7.EXIT");
                Console.WriteLine("------------------------------");
                int choice = Inputer.InputIntInRange("Select your choice: ",1,7);
                switch (choice)
                {
                    case 1: InputList(); 
                            break;
                    case 2: ShowList();
                            break;
                    case 3:
                        list.Sort();
                        ShowList();
                        break;
                    case 4:
                        list.Sort(new SortByAuthor());
                        ShowList();
                        break;
                    case 5:
                        list.Sort(new SortByYear());
                        ShowList();
                        break;
                    case 6: Console.Clear();
                            Console.WriteLine("Press any key to continue!");
                            Console.ReadLine();
                            Console.Clear();
                        break;
                    case 7: return;
                }
            }
        }
    }
}
