using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SeedDatabase.Models;
using SeedDatabase.Persistence;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SeedDatabase.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var books = _context.Books.Include(b => b.Author);
            return View(books);
        }


        public IActionResult Details(Guid id)
        {
            var book = _context.Books.FirstOrDefault(b => b.Id == id);
            return View(book);
        }

    }
}
