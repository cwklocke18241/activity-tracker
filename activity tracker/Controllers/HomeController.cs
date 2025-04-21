using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using activity_tracker.Models;
using Websitetime2.Models;

namespace activity_tracker.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //_logger = logger;
        //}
        private readonly ApplicationDBContext _db;
        public HomeController(ApplicationDBContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            var activities = _db.Activities.ToList();
            return View(activities);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Intro()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult add(int Id, [Bind("Id, Name, Date")] Activities i)
        {
            _db.Add(i);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
