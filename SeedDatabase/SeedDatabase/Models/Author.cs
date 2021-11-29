using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeedDatabase.Models
{
    public class Author
    {
        public Guid Id { get; set; }
        [Display(Name = "Author")]
        public string Name { get; set; }
        public List<Book> Books { get; set; }

    }
}
