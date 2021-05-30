using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace LinqToSqlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryContext context = new LibraryContext();
            /* context.Authors.Where(a => a.Name.Contains("Two"))
                .Select(a => $"{a.Name} (id: {a.Id})")
                .ToList().ForEach(Console.WriteLine); */
            
            /* context.Authors
                .Select(a => $"{a.Name} (id: {a.Id})")
                .ToList().ForEach(Console.WriteLine); */
            
            /* context.Authors
                .Include(a => a.Books)
                .ToList().ForEach(a =>
                {
                    Console.WriteLine($"{a.Name} (id: {a.Id})");
                    a.Books.ToList().ForEach(b => Console.WriteLine($"\t{b.Title}"));
                }); */
                // .Select(a => $"{a.Name} (id: {a.Id})")
                // .ToList().ForEach(Console.WriteLine);
            Console.WriteLine(context.Authors.ToQueryString());
            Console.WriteLine("***");
            Console.WriteLine(context.Authors.Include(a => a.Books).ToQueryString());
        }
    }
}