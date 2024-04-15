using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
    public class Pet
    {
        // Attention, AmountOfFood, Rest are all 100 i.e its maximum value is 100.
        public string PetName { get; set; }
        public int AmountOfFood { get; set; }
        public int Attention { get; set; }
        public int Rest { get; set; }

        private static List<Pet> _petInstances = new List<Pet>(){};
        
        public Pet(string myPetName, int petAmountOfFood, int petAttention, int petRest)
        {
            PetName = myPetName;
            AmountOfFood = petAmountOfFood;
            Attention = petAttention;
            Rest = petRest;
            _petInstances.Add(this);
        }

        // Method to get all pet objects
        public static List<Pet> GetAllPets()
        {
            return _petInstances;
        }


        // Since I am getting error of different number of elements, I now need to implement a ClearAllPets() method... Use IDisposable interface, and Dispose() method so it can run after every test
        public static void ClearAllPets()
        {
            _petInstances.Clear();
        }

        // Methods to Feed, Play, and Put tamagotchi to sleep.
        public void Feed()
        {
            AmountOfFood += 5;
        }
        
        public void Play()
        {
            AmountOfFood -= 5;
            Rest -= 5;
            Attention += 5;
        }

        public void Sleep()
        {
            AmountOfFood += 5;
            Rest += 5;
            Attention -= 5;
        }

        public void MakeTimePass()
        {
            AmountOfFood -= 5;
            Rest -= 5;
            Attention -= 5;
        }


    }
}