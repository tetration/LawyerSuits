using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LawyerSuits.DAL;
using LawyerSuits.Web.Models;

namespace LawyerSuits.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private LawyerSuitsDbContext _db;

        public HomeController(ILogger<HomeController> logger, LawyerSuitsDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Lawsuits()
        {
            return View(_db.Lawsuits.AsEnumerable());
        }

        public IActionResult Lawyers()
        {
            return View(_db.Lawyers.AsEnumerable());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
