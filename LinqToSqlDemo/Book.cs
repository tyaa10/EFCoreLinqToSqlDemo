using System;
using System.Collections.Generic;

#nullable disable

namespace LinqToSqlDemo
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? AuthorId { get; set; }

        public virtual Author Author { get; set; }
    }
}
