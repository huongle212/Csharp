using System;
using System.Collections;

namespace MyBookLibrary
{
    class Book : IBook, IComparable
    {
        public string id;
        public string title;
        public string publisher;
        public double price;
        public ArrayList Chapter = new ArrayList();

        string IBook.id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBook.title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBook.publisher { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double IBook.price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Book() { }

        public Book(string id, string title, string publisher, double price, ArrayList chapter)
        {
            this.id = id;
            this.title = title;
            this.publisher = publisher;
            this.price = price;
            this.Chapter = chapter;
        }

        public string this[int index] //chuong sach
        {
            get
            {
                if (index >= 0 && index < Chapter.Count)
                    return (string)Chapter[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < Chapter.Count)
                    Chapter[index] = value;
                else if (index == Chapter.Count)
                    Chapter.Add(value);
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public void Show()
        {
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine($"Book {id} [Name = {title}, Publisher = {publisher}, Price = {price}]");
            Console.WriteLine("Content: ");
            for (int i = 0; i < Chapter.Count; i++)
            {
                Console.WriteLine($"   Chapter {(i + 1)}: {Chapter[i]}");
            }
            Console.WriteLine("________________________________________________________________________________");
        }

        public void Input()
        {
            id = Inputer.InputString("Enter book id: ");
            title = Inputer.InputString("Enter title: ");
            publisher = Inputer.InputString("Enter publisher: ");
            price = Inputer.InputDouble("Enter price: ", 0);
            Console.WriteLine("Input content (finish with empty string)");
            string str;
            int i = 1;
            do
            {
                Console.Write($"Chapter {(i)}: ");
                str = Console.ReadLine();
                if (str.Length > 0)
                {
                    Chapter.Add(str);
                    i++;
                }
            } while (str.Length > 0);
            Console.WriteLine("________________________________________");
        }

        public void UpdateInfor()
        {
            title = Inputer.InputString("Enter new title: ");
            publisher = Inputer.InputString("Enter new publisher: ");
            price = Inputer.InputDouble("Enter new price: ", 0);
            Chapter = new ArrayList();
            Console.WriteLine("Input content (finish with empty string)");
            string str;
            int i = 1;
            do
            {
                Console.Write($"Chapter {(i)}: ");
                str = Console.ReadLine();
                if (str.Length > 0)
                {
                    Chapter.Add(str);
                    i++;
                }
            } while (str.Length > 0);
            Console.WriteLine("________________________________________");
        }

        public int CompareTo(Object other)
        {
            if (other == null) throw new NotImplementedException();
            Book b = (Book)other;
            return id.CompareTo(b.id);
        }
    }
}
