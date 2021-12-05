using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace SeedDatabase.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
        
    }
}