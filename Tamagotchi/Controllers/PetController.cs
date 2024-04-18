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

        [HttpGet("/pets/{objId}")]
        public ActionResult Show(int objId)
        {
            Pet foundObj = Pet.Find(objId);
            return View(foundObj);
        }

        // For calling Feed Method based on user actions(i.e when user clicks)
        // The 'Feed' method takes an objId to figure out which Pet to feed
        // Since it happens on the same page(Show.cshtml page), there is no need for a route Path
        [HttpPost]
        public IActionResult Feed(int objId)
        {
             // Retrieve the pet object based on the ID
             Pet myPet = Pet.Find(objId);
            if (myPet != null)
            {
                myPet.Feed();
                return Json(new { message = myPet.PetName + " has been fed!"});
            }
            else
            {
                return Json(new { message = "Pet not found!" });
            }
        }

        // For Attention; It is very similar to Feed()
        [HttpPost]
        public IActionResult Play(int objId)
        {
            Pet myPet = Pet.Find(objId);
            if (myPet != null)
            {
                myPet.Play();
                return Json(new {message = "You have played with " + myPet.PetName});

            }
            else
            {
                return Json(new { message = "Pet not found!"});
            }
        }

        [HttpPost]
        public IActionResult Sleep(int objId)
        {
            Pet myPet = Pet.Find(objId);
            if (myPet != null)
            {
                myPet.Sleep();
                return Json(new {message = myPet.PetName + " has slept"});

            }
            else
            {
                return Json(new { message = "Pet not found!"});
            }
        }

        [HttpPost]
        public IActionResult MakeTimePass(int objId)
        {
            Pet myPet = Pet.Find(objId);
            if (myPet != null)
            {
                myPet.MakeTimePass();
                return Json(new {message = "The make time pass button has been clicked"});

            }
            else
            {
                return Json(new { message = "Pet not found!"});
            }
        }

        [HttpPost]
        public IActionResult IsAlive(int objId)
        {
            Pet myPet = Pet.Find(objId);
            if (myPet != null)
            {
                myPet.IsAlive();
                return Json(new {message = "Is "  + myPet.PetName +" alive? " + myPet.IsAlive()});

            }
            else
            {
                return Json(new { message = "Pet not found!"});
            }
        }

        [HttpGet("/pets/delete")]
        public ActionResult Delete()
        {
            return View();
        }

        // Using HttpPost to implement HttpDelete() that is not available in hTML5
        [HttpPost("pets/deleteall")]
        public ActionResult DeleteAll()
        {
            Pet.ClearAllPets();
            return RedirectToAction("Index");
        }


        [HttpGet("/pets/{myPetId}/deletepet")]
        public ActionResult DeletePet(int myPetId)
        {
            return View();
        }

        // Using HttpPost to implement HttpDelete() that is not available in hTML5
        [HttpPost("/pets/{myPetId}/deletemypet")]
        public ActionResult DeleteMyPet(int myPetId)
        {
            Pet.RemovePet(myPetId);
            return RedirectToAction("Index");
        }

    }
}