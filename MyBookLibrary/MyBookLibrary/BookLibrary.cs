using System;
using System.Collections;

namespace MyBookLibrary
{
    public class BookLibrary
    {
        private ArrayList list = new ArrayList();

        public int checkBookIdExist(string id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if ((id.ToLower()).Equals((list[i] as Book).id.ToLower())) return i;
            }
            return -1;
        }

        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
        }

        public void ShowList()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Empty list!");
            }
            foreach (Book b in list)
                b.Show();
            Console.ReadLine();
        }

        public void InputList()
        {
            int n = Inputer.InputInt("Number of books in list: ");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Input book {i}");
                AddBook();
            }
            Console.WriteLine("Add book successful.");
        }

        public void UpdateBook()
        {
            string id = Inputer.InputString("Enter book's id you want to update: ");
            int index = checkBookIdExist(id);
            if (index == -1)
            {
                Console.WriteLine("This book's id doesn't exist.");
            }
            else
            {
                Book b = list[index] as Book;
                b.UpdateInfor();
                list[index] = b;
                Console.WriteLine("Update book successful.");
            }

        }

        public void DeleteBook()
        {
            string id = Inputer.InputString("Enter book's id you want to delete: ");
            int index = checkBookIdExist(id);
            if (index == -1)
            {
                Console.WriteLine("This book's id doesn't exist.");
            }
            else
            {
                list.RemoveAt(index);
                Console.WriteLine("Delete book successful.");
            }

        }

        public void SortBook()
        {
            int choice = Inputer.InputInt("Sort by (1-ID, 2-Title, 3-Publisher, Other-Price): ", 1, 4);
            switch (choice)
            {
                case 1:
                    list.Sort();
                    break;
                case 2:
                    list.Sort(new SortByTitle());
                    break;
                case 3:
                    list.Sort(new SortByPublisher());
                    break;
                default:
                    list.Sort(new SortByPrice());
                    break;
            }
        }

        public void GUI()
        {
            while (true)
            {
                Console.WriteLine("======== BOOK MANAGER ========");
                Console.WriteLine("1.Add book");
                Console.WriteLine("2.Update book");
                Console.WriteLine("3.Delete book");
                Console.WriteLine("4.List all book");
                Console.WriteLine("5.Sort");
                Console.WriteLine("6.Clear Console");
                Console.WriteLine("7.EXIT");
                Console.WriteLine("------------------------------");
                int choice = Inputer.InputInt("Select your choice: ", 1, 7);
                switch (choice)
                {
                    case 1:
                        InputList();
                        break;
                    case 2:
                        UpdateBook();
                        break;
                    case 3:
                        DeleteBook();
                        break;
                    case 4:
                        ShowList();
                        break;
                    case 5:
                        SortBook();
                        ShowList();
                        break;
                    case 6:
                        Console.Clear();
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
