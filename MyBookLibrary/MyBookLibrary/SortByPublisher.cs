using System.Collections.Generic;

namespace MyBookLibrary
{
    class SortByPublisher:Comparer<Book>
    {
        public override int Compare(Book x, Book y)
        {
            return x.publisher.CompareTo(y.publisher);
        }
    }
}
