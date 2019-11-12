using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Book
{
    class Book:IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors.ToList();
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public int CompareTo(Book other)
        {
            int result = this.Title.CompareTo(other.Title);
            if(result==0)
            {
                return other.Year.CompareTo(this.Year);
            }
            return result;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}"; 
        }
    }
}
