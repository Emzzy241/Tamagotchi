using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tamagotchi.Models;

namespace TamagotchiTests.Models
{
    
    [TestClass]
    public class PetTests
    {
        // Test 1. Test for Constructor
        [TestMethod]
        public void PetConstructor_CreatesInstanceOfPet_Pet()
        {
            // Arrange
            Pet myPet = new Pet("Shield", 10, 20, 5);

            // Assert
            Assert.AreEqual(typeof(Pet), myPet.GetType());

        }

        // Test 2. Test to get PetName property of Pet class
        [TestMethod]
        public void GetPetName_ReturnsNameOfPet_String()
        {
            // Arrange
            Pet myPet = new Pet("Dyna", 10, 20, 5);
            string expectedPetName = "Dyna";

            // Act
            string actualPetName = myPet.PetName;

            // Assert
            Assert.AreEqual(expectedPetName, actualPetName);
        }

        // Test 3. Test to set PetName property of Pet class
        [TestMethod]
        public void SetName_SetsValueOfPetName_Void()
        {
            // Arrange
            Pet myPet = new Pet("Shield", 10, 20, 5);
            string newPetName = "Alexa";

            // Act
            myPet.PetName = newPetName;

            // Assert
            Assert.AreEqual(newPetName, myPet.PetName);
        }

        // Test 4. Test to get AmountOfFood property of Pet Class
        [TestMethod]
        public void GetAmountOfFood_ReturnsAmountOfFoodProperty_Int()
        {
            // Arrange
            Pet myPet = new Pet("Shield", 10, 20, 5);
            int expectedAmountOfFood = 10;

            // Act
            int actualAmountOfFood = myPet.AmountOfFood;

            // Assert
            Assert.AreEqual(expectedAmountOfFood, actualAmountOfFood);
        }

        // Test 5. Test to set AmountOfFood property of Pet Class
        public void SetAmountOfFood_SetsValueOfAMountOfFoodProperty_Void()
        {
            // Arrange
            Pet myPet = new Pet("Alexa", 10, 20, 5);
            int newAmountOfFood = 15;

            // Act
            myPet.AmountOfFood = newAmountOfFood;

            // Assert
            Assert.AreEqual(newAmountOfFood, myPet.AmountOfFood);
        }

        // Test 6. Test to Get the Attention property the Pet currently has
        [TestMethod]
        public void GetAttention_ReturnsAttentionOfPet_Int()
        {
            // Arrange
            Pet myPet = new Pet("Alexa", 15, 10, 5);
            int expectedAttention = 10;

            // Act
            int actualAttention = myPet.Attention;

            // Assert
            Assert.AreEqual(expectedAttention, actualAttention);
        }

        // Test 7. Test to set the Attentioin value of Pet
        [TestMethod]
        public void SetAttention_SetsAttentionValueOfPet_Void()
        {
            // Arrange
            Pet myPet = new Pet("Shield", 15, 20, 5);
            int newAttentionValue = 15;

            // Act
            myPet.Attention = newAttentionValue;

            // Assert
            Assert.AreEqual(newAttentionValue, myPet.Attention);
        }

        // Test 8. Test to get the Rest property of our pet
        [TestMethod]
        public void GetRest_ReturnsRestValueOfPet_Int()
        {
            // Arrange
            Pet myPet = new Pet("Alexa", 5, 10, 15);
            int expectedRestValue = 15;

            // Act
            int actualRestValue = myPet.Rest;

            // Assert
            Assert.AreEqual(expectedRestValue, actualRestValue);
        }

        // Test 9. Test to set the Rest property of our Pet 
        [TestMethod]
        public void SetRest_SetsValueOfRestProperty_Void()
        {
            // Arrange
            Pet myPet = new Pet("Alexa", 5, 10, 15);
            int newRestValue = 35;

            // Act
            myPet.Rest = newRestValue;

            // Assert
            Assert.AreEqual(newRestValue, myPet.Rest);
        }

        // Test 10. Testing if more than one Pet objects can be gotten from List
        [TestMethod]
        public void GetAllPets_ReturnsAllInstancesOfPets_Pet()
        {
            // Arrange
            Pet myPet = new Pet("Alexa", 5, 10, 15);
            Pet myPet2 = new Pet("Theresa", 15, 5, 10);
            Pet myPet3 = new Pet("Rebecca", 40, 20, 30);
            List<Pet> expectedListOfPets = new List<Pet>(){ myPet, myPet2, myPet3 };
            
            // Act
            List<Pet> actualListOfPets = Pet.GetAllPets();

            // Assert
            Assert.AreEqual(expectedListOfPets, actualListOfPets);
        }

        // Test 12. Testing Feed() method of Tamagotchi
        // [TestMethod]
        // public void FeedMethod_MethodToFeedPet_Int()
        // {
        //     // Arrange
        //     Pet myPet = new Pet("Alexa", 5, 10, 15);
        //     int newPetAmountOfFood = 15;

        //     // Act
        //     int 
        // } 




    }
}