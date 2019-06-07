using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefsDishes.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using DishesNChefs.Models;
namespace DishesNChefs.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _DbContext;
        public HomeController(MyContext context)
        {
            _DbContext=context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            List<Chef> All=_DbContext.Chefs.ToList();
            return View(All);
        }
        [Route("dishes")]
        [HttpGet]
        public IActionResult Dishes()
        {
            List<Dish> DishesChefs=_DbContext.Dishes.Include(m=>m.Creator).ToList();
            return View(DishesChefs);
        }
        [Route("Add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [Route("create")]
        [HttpPost]
        public IActionResult Create(AddChef chef)
        {
            Chef newChef=new Chef();
            newChef.Name=chef.FirstName+"  "+chef.LastName;
            var today=DateTime.Today;
            newChef.Age=today.Year-chef.DOB.Year;
            _DbContext.Add(newChef);
            _DbContext.SaveChanges();
            return View("Add");
        }
        [Route("adddish")]
        [HttpGet]
        public IActionResult newdish()
        {
            List<Chef> y=_DbContext.Chefs.ToList();
            ViewBag.Chefs=y;
            return View();
        }

        [Route("process")]
        [HttpPost]
        public IActionResult Process(NewDish dish)
        {
            Dish d=new Dish();
            d.DishName=dish.DishName;
            d.Calories=dish.CaloriesNum;
            d.Tastiness=dish.Tasty;
            _DbContext.Add(d);
            _DbContext.SaveChanges();
            return RedirectToAction("newdish");
        }


    }
}
