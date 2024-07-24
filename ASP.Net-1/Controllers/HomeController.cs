﻿using ASP.Net_1.Entities;
using ASP.Net_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_1.Controllers
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
            List<Drink> drinks = new List<Drink>
    {
        new Drink
        {
            Id = 1,
            Name = "Coca Cola",
            Price = 1.50
        },
        new Drink
        {
            Id = 2,
            Name = "Pepsi",
            Price = 1.75
        },
        new Drink
        {
            Id = 3,
            Name = "Sprite",
            Price = 1.60
        }
    };

            List<HotMeal> hotMeals = new List<HotMeal>
    {
        new HotMeal
        {
            Id = 1,
            Name = "Grilled Chicken",
            Price = 8.50
        },
        new HotMeal
        {
            Id = 2,
            Name = "Beef Stroganoff",
            Price = 9.75
        },
        new HotMeal
        {
            Id = 3,
            Name = "Vegetable Stir-fry",
            Price = 7.00
        }
    };

            List<FastFood> fastFoods = new List<FastFood>
    {
        new FastFood
        {
            Id = 1,
            Name = "Burger",
            Price = 5.99
        },
        new FastFood
        {
            Id = 2,
            Name = "Fries",
            Price = 2.99
        },
        new FastFood
        {
            Id = 3,
            Name = "Hot Dog",
            Price = 3.49
        }
    };



            var viewModel = new MealsViewModel()
            {
                Drinks = drinks,
                FastFoods = fastFoods,
                HotMeals = hotMeals

            };
            return View(viewModel);
        }

        public IActionResult Drinks()
        {
            List<Drink> drinks = new List<Drink>
            {
        new Drink
        {
            Id = 1,
            Name = "Coca Cola",
            Price = 1.50
        },
        new Drink
        {
            Id = 2,
            Name = "Pepsi",
            Price = 1.75
        },
        new Drink
        {
            Id = 3,
            Name = "Sprite",
            Price = 1.60
        }
             };
            return View(drinks);
        }

        public IActionResult HotMeals()
        {
            List<HotMeal> hotMeals = new List<HotMeal>
    {
        new HotMeal
        {
            Id = 1,
            Name = "Grilled Chicken",
            Price = 8.50
        },
        new HotMeal
        {
            Id = 2,
            Name = "Beef Stroganoff",
            Price = 9.75
        },
        new HotMeal
        {
            Id = 3,
            Name = "Vegetable Stir-fry",
            Price = 7.00
        }
    };

            return View(hotMeals);
        }

        public IActionResult FastFoods()
        {
            List<FastFood> fastFoods = new List<FastFood>
    {
        new FastFood
        {
            Id = 1,
            Name = "Burger",
            Price = 5.99
        },
        new FastFood
        {
            Id = 2,
            Name = "Fries",
            Price = 2.99
        },
        new FastFood
        {
            Id = 3,
            Name = "Hot Dog",
            Price = 3.49
        }
    };

            return View(fastFoods);
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