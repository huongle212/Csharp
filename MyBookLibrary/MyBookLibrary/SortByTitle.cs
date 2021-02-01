using System.Collections.Generic;

namespace MyBookLibrary
{
    class SortByTitle : Comparer<Book>
    {
        public override int Compare(Book x, Book y)
        {
            return x.title.CompareTo(y.title);
        }
    }   
}