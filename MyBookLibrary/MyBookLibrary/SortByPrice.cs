using System.Collections.Generic;

namespace MyBookLibrary
{
    class SortByPrice:Comparer<Book>
    {
        public override int Compare(Book x, Book y)
        {
            return x.price.CompareTo(y.price);
        }
    }
}
