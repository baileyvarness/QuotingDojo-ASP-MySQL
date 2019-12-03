using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("quote")]
        public IActionResult Create(Quote newQuote)
        {
            if(ModelState.IsValid)
            {
                string query = $"INSERT INTO quotes (YourName, YourQuote, created_at) VALUES ('{newQuote.YourName}', '{newQuote.YourQuote}', NOW())";
                DbConnections.Execute(query);
                return RedirectToAction("Quotes");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("quotes")]
        public IActionResult Quotes()
        {
            List<Dictionary<string, object>> allQuotes = DbConnections.Query("SELECT * FROM quotes");
            return View(allQuotes);
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
