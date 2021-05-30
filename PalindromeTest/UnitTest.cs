using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Palindrome.Palindrome;

namespace PalindromeTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void IsPermutationPalindrome_Abceceba_ReturnedTrue()
        {
            //arrange
            string str = "Abceceba";
            bool expected = true;

            //act
            bool actual = IsPermutationPalindrome(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPermutationPalindrome_Abcecebaf_ReturnedTrue()
        {
            //arrange
            string str = "Abcecebaf";
            bool expected = true;

            //act
            bool actual = IsPermutationPalindrome(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPermutationPalindrome_Abcecebafr_ReturnedFalse()
        {
            //arrange
            string str = "Abcecebafr";
            bool expected = false;

            //act
            bool actual = IsPermutationPalindrome(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPermutationPalindrome_Ab_ce_ce_baf_ReturnedTrue()
        {
            //arrange
            string str = "Ab ce ce baf";
            bool expected = true;

            //act
            bool actual = IsPermutationPalindrome(str);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPermutationPalindrome_Null_ThrowArgumentNullException()
        {
            //arrange
            string str = null;

            //act + assert
            Assert.ThrowsException<ArgumentNullException>(() => IsPermutationPalindrome(str));
        }
    }
}