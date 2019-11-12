using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Book
{
    class Library : IEnumerable<Book>
    {
        public List<Book> books { get; set; }

        public Library(params Book[] books)
        {
            this.books = books.ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
