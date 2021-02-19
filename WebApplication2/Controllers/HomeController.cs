using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {

            int temp = 10;

            List<User> users = new List<User>();

            users.Add(new User
            {
                Id = 1,
                Name = "Vova",
                SurName = "Vovanovich",
                Balance = 100,
                Created = DateTime.Now,
            });

            users.Add(new User
            {
                Id = 2,
                Name = "Ivan",
                SurName = "Ivanovich",
                Balance = 10000,
                Created = DateTime.Now,
            });

            users.Add(new User
            {
                Id = 3,
                Name = "Seva",
                SurName = "Sevovich",
                Balance = 777,
                Created = DateTime.Now,
            });

            User testUser = new User();

            testUser.Id = 4;
            testUser.Name = "Vasa";
            testUser.SurName = "Vasovich";
            testUser.Balance = 1234;
            testUser.Created = DateTime.Now;

            users.Add(testUser);


            return View(users);
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