using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SeedDatabase.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SeedDatabase.Controllers
{
    public class BookController : Controller
    {


        public BookController()
        {

        }

        public IActionResult Index()
        {

            return View();
        }


        public IActionResult Details(Guid id)
        {
            return View();
        }

    }
}
