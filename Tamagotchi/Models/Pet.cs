using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
    public class Pet
    {
        // Properties of a Pewt object
        public string PetName { get; set; }
        public int AmountOfFood { get; set; }
        public int Attention { get; set; }
        public int Rest { get; set; }
        public int Id { get; }
        
        

        private static List<Pet> _petInstances = new List<Pet>(){};
        
        public Pet(string myPetName, int petAmountOfFood, int petAttention, int petRest)
        {
            PetName = myPetName;
            AmountOfFood = petAmountOfFood;
            Attention = petAttention;
            Rest = petRest;
            _petInstances.Add(this);
            // After its been added to the list, thats when we count and get our id value
            Id = _petInstances.Count;
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

        // Find() Method
        public static Pet Find(int petId)
        {
            return _petInstances[petId - 1];
        }

        // Remove(); For removing a single Pet from list
        public static void RemovePet(int petId)
        {
            Pet findPet = Pet.Find(petId);

            _petInstances.Remove(findPet);
        }

        // Methods to Feed, Play, and Put tamagotchi to sleep.
        public void Feed()
        {
            if (AmountOfFood > 0)
            {
                AmountOfFood += 5;
            }
        }
        
        public void Play()
        {
            if (AmountOfFood > 0 && Rest > 0 && Attention > 0)
            {
                AmountOfFood -= 5;
                Rest -= 5;
                Attention += 5;
            }
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

        public bool IsAlive()
        {
            if (AmountOfFood > 0 && Rest > 0 && Attention > 0)
            {
                return true;
            }
            else if (AmountOfFood <= 0 || Rest <= 0 || Attention <= 0)
            {
                return false;
            }
            return false;
        }



    }
}