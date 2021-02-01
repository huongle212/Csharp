using System;
using System.Collections;

namespace PRN292_Lab2M_1_2_Book
{
    class Book : IBook, IComparable
    {
        public string title;
        public string author;
        public string publisher;
        public string ISBN;
        public int year;
        public ArrayList Chapter = new ArrayList();

        public Book() { }

        public Book(string title, string author, string publisher, string ISBN, int year, ArrayList chapter)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.ISBN = ISBN;
            this.year = year;
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

        string IBook.title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBook.author { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBook.publisher { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBook.ISBN { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IBook.year { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

       
        public void Show()
        {
            Console.WriteLine("________________________________________________________________________________");
            //Console.WriteLine("Title: " + title);
            //Console.WriteLine("Author: " + author);
            //Console.WriteLine("Publisher: " + publisher);
            //Console.WriteLine("Year: " + year);
            //Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine($"Book {ISBN} [Name = {title}, Author = {author}, Publisher = {publisher}, Year = {year}]");
            Console.WriteLine("Content: ");
            for(int i = 0; i < Chapter.Count; i++)
            {
                Console.WriteLine($"   Chapter {(i + 1)}: {Chapter[i]}");
            }
            Console.WriteLine("________________________________________________________________________________");
        }

        public void Input()
        {
            //Console.Write("Title: ");
            //Title = Console.ReadLine();
            //Console.Write("Author: ");
            //Author = Console.ReadLine();
            //Console.Write("Publisher: ");
            //Publisher = Console.ReadLine();
            //Console.Write("ISBN: ");
            //ISBN = Console.ReadLine();
            //Console.Write("Year: ");
            //Year = int.Parse(Console.ReadLine());
            title = Inputer.InputString("Title: ");
            author = Inputer.InputString("Author: ");
            publisher = Inputer.InputString("Publisher: ");
            ISBN = Inputer.InputString("ISBN: ");
            year = Inputer.InputIntInRange("Year: ", 0, DateTime.Now.Year);
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
            if (title.CompareTo(b.title) == 0)
            {
                if (author.CompareTo(b.author) == 0)
                {
                    if (publisher.CompareTo(b.publisher) == 0)
                    {
                        return year.CompareTo(b.year);
                    }
                    return publisher.CompareTo(b.publisher);
                }
                return author.CompareTo(b.author);
            }
            return title.CompareTo(((Book)other).title);
        }
    }
}
