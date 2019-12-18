using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramChecker.Models;
using System.Collections.Generic;

namespace AnagramChecker.Tests
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void Checker_DeterminesAnagram_True()
        {
            Assert.AreEqual(true, Anagram.Checker("bread", "beard"));
        }

        // [TestMethod]
        // public void GetAnagrams_UserInputMatchesTheList_Bread()
        // {
        //     // Arrange
        //     List<string> expected = new List<string>() {"bread", "orange", "tomato", "bared", "banana"};
        //     string wordToCompare = "beard";

        //     // Act
        //     List<string> result = Anagram.GetAnagrams(wordToCompare, expected);

        //     // Assert
        //     Assert.AreEqual("bared", result[1]);
        // }
    }
}