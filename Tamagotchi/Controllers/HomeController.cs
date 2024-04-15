using Microsoft.AspNetCore.Mvc;
using System;
using Tamagotchi.Models;

namespace TamagotchiController
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }        
    }
}