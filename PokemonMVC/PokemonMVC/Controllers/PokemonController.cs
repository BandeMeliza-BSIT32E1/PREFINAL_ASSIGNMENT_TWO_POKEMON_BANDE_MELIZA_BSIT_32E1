﻿using Microsoft.AspNetCore.Mvc;

namespace PokemonMVC.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
