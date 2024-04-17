using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tamagotchi.Models;

namespace TamagotchiTests.Models
{
    
    [TestClass]
    public class PetTests : IDisposable
    {

        // Implementing Dispose() method thats mandaory wheneever we inherit the IDisposable interface
        public void Dispose()
        {
            Pet.ClearAllPets();
            // Clearing all Pet objects from list after every test
        }
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

        // Test 10. Testing the GetAllPets() method
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
            CollectionAssert.AreEqual(expectedListOfPets, actualListOfPets);
        }

        // Test 11. Testing the ClearAllPets() method
        [TestMethod]
        public void ClearAllPets_RemovesAllInstancesOfPets_Void()
        {
            // Arrange
             Pet myPet = new Pet("Alexa", 5, 10, 15);
            Pet myPet2 = new Pet("Theresa", 15, 5, 10);
            Pet myPet3 = new Pet("Rebecca", 40, 20, 30);
            List<Pet> expectedListOfPets = new List<Pet>(){};
            
            // Act
            Pet.ClearAllPets();
            List<Pet> actualListOfPets = Pet.GetAllPets();

            // Assert
            CollectionAssert.AreEqual(expectedListOfPets, actualListOfPets);
        }

        // Test 12. Testing Feed() method on Tamagotchi Pet
        [TestMethod]
        public void Feed_MethodToFeedPet_Void()
        {
            // Arrange
            Pet myPet = new Pet("Alexa", 5, 10, 15);
            int expectedAmountOfFood = 10;

            // Act
            myPet.Feed();
            int actualAmountOfFood = myPet.AmountOfFood;

            // Assert
            Assert.AreEqual(expectedAmountOfFood, actualAmountOfFood);
        } 
        
        // Test 13. Testing Play() method on Tamagotchi Pet
        [TestMethod]
        public void Play_MethodToPlayWithPet_Void()
        {
            // Arrange
            Pet myPet = new Pet("Shield", 10, 10, 10);
            int expectedAmountOfFood = 5;
            int expectedRestValue = 5;
            int expectedAttention = 15;

            // Act
            myPet.Play();
            int actualAmountOfFood = myPet.AmountOfFood;
            int actualRestValue = myPet.Rest;
            int actualAttention = myPet.Attention;

            // Assert
            Assert.AreEqual(expectedAmountOfFood, actualAmountOfFood);
            Assert.AreEqual(expectedRestValue, actualRestValue);
            Assert.AreEqual(expectedAttention, actualAttention);
        }

        // Test 14. Testing Sleep() method on Tamagotchi Pet
        [TestMethod]
        public void Sleep_MethodToMakePetSleep_Void()
        {
            // Arrange
            // When Pet gets food, food increases when it gets rest food also increases since digestion takes place and its known that humans digestive systems works twice as fast when we sleep
            Pet myPet = new Pet("Shield", 30, 30, 30);
            int expectedAmountOfFood = 35;
            int expectedRestValue = 35;
            int expectedAttention = 25;

            // Act
            myPet.Sleep();
            int actualAmountOfFood = myPet.AmountOfFood;
            int actualRestValue = myPet.Rest;
            int actualAttention = myPet.Attention;

            // Assert
           Assert.AreEqual(expectedAmountOfFood, actualAmountOfFood);
            Assert.AreEqual(expectedRestValue, actualRestValue);
            Assert.AreEqual(expectedAttention, actualAttention);
        }

        // Test 15. Testing the MakeTimePass() method on Tamagotchi Pet
        [TestMethod]
        public void MakeTimePass_MethodToMakeTimePass_Void()
        {
            // Arrange
            // The MakeTimePass() method reduces all properties of Pet
            Pet myPet = new Pet("Shield", 30, 30, 30);
            int expectedAmountOfFood = 25;
            int expectedRestValue = 25;
            int expectedAttention = 25;

            // Act
            myPet.MakeTimePass();
            int actualAmountOfFood = myPet.AmountOfFood;
            int actualRestValue = myPet.Rest;
            int actualAttention = myPet.Attention;
            
            // Assert
            Assert.AreEqual(expectedAmountOfFood, actualAmountOfFood);
            Assert.AreEqual(expectedRestValue, actualRestValue);
            Assert.AreEqual(expectedAttention, actualAttention);
        }

        // Test 15. Testing the IsAlive() method on Tamagotchi Pet
        [TestMethod]
        public void IsAlive_DeterminesWhetherPetIsAlive_Bool()
        {
            // Arrange
            Pet myPet = new Pet("Dyna", 50, 50, 5);
            bool expectedStatus = true;

            // Act
            myPet.MakeTimePass(); // MakeTimePass() reduces all property and since attention <= 0. It is true that Pet object is dead
            bool actualStatus = myPet.IsAlive();

            // Assert
            Assert.AreEqual(expectedStatus, actualStatus);
        }

        // Test 16. Testing the Id property on Tamagotchi object
        [TestMethod]
        public void Id_ReturnsIdOfPetObjects_Int()
        {
            // Arrange
            Pet myPet = new Pet("Dyna", 40, 40, 40);
            Pet myPet2 = new Pet("Alexa", 30, 30, 30);
            Pet myPet3 = new Pet("Shield", 0, 60, 30);
            int expectedObjectId = 1;

            // Act
            int actualObjectId = myPet.Id;

            // Assert
            Assert.AreEqual(expectedObjectId, actualObjectId);
        }

        // Test 17. Testing the Find() method on Tamagotchi object
        [TestMethod]
        public void Find_FindsPetObj_Pet()
        {
            // Arrange
            Pet myPet = new Pet("Dyna", 40, 40, 40);
            Pet myPet2 = new Pet("Alexa", 30, 30, 30);
            Pet myPet3 = new Pet("Shield", 0, 60, 30);
            Pet expectedPet = myPet;

            // Act
            Pet actualPet = Pet.Find(1);

            // Assert
            Assert.AreEqual(expectedPet, actualPet);
        }

       

    }
}