using System.Collections.Generic;

namespace PRN292_Lab2M_1_2_Book
{
    class SortByAuthor : Comparer<Book>
    {
        public override int Compare( Book x, Book y)
        {
            return x.author.CompareTo(y.author);
        }
    }
    class SortByYear : Comparer<Book>
    {
        public override int Compare(Book x, Book y)
        {
            return x.year.CompareTo(y.year);
        }
    }
}
