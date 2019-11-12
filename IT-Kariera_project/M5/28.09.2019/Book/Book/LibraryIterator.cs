using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int index;

        public LibraryIterator(List<Book> books)
        {
            this.books = books;
            Reset();
        }

        public Book Current => books[index];

        object IEnumerator.Current => this.Current;

        public void Dispose(){ }

        public bool MoveNext()
        {
            index++;
            return index < books.Count;
        }

        public void Reset()
        {
            this.index = -1;
        }
    }
}
