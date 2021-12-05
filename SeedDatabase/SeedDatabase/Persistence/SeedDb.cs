using SeedDatabase.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;

namespace SeedDatabase.Persistence
{
    public static class SeedDb
    {

        public static void Seed(ApplicationDbContext context)
        {
            var currentDirectory = Environment.CurrentDirectory;
            string seedDataFolder = Path.Combine(currentDirectory, "Persistence", "SeedData");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            if (!context.Authors.Any())
            {

                List<Author> authors = JsonSerializer.Deserialize<List<Author>>(File.ReadAllText(
                    seedDataFolder+ "\\Authors.json"), options);

                context.Authors.AddRange(authors);
            }

            if (!context.Books.Any())
            {
                List<Book> books = JsonSerializer.Deserialize<List<Book>>(File.ReadAllText(
                   seedDataFolder + "\\Books.json"), options);
                context.Books.AddRange(books);
            }

            context.SaveChanges();
        }
    }
}
