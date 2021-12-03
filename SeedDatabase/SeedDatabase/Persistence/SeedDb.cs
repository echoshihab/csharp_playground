using SeedDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SeedDatabase.Persistence
{
    public static class SeedDb
    {

        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Books.Any())
            {
                //have to fix this
                var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var path = baseDirectory + "/SeedData";

                List<Book> test = JsonSerializer.Deserialize<List<Book>>("Authors.json");
            }
            if(!context.Authors.Any())
            {
                //code here
            }
        }
    }
}
