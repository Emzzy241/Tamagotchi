using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Tamagotchi.Models;

namespace TamagotchiController
{
    public class PetController : Controller
    {
        [HttpGet("/pets")]
        public ActionResult Index()
        {
            List<Pet> listOfPetObjects = Pet.GetAllPets();
            return View(listOfPetObjects);
        }

        [HttpGet("/pets/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/pets")]
        public ActionResult Create(string myPetName, int petAmountOfFood, int petAttention, int petRest)
        {
            Pet myPet = new Pet(myPetName, petAmountOfFood, petAttention, petRest);
            List<Pet> listOfPetObjects = Pet.GetAllPets();
            return RedirectToAction("Index");
        }
    }
}