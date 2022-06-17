﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            string password = "P2ssw0rd#";
            int a = 5;
            // act
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);
            // assert
            Assert.AreEqual(a, actual);
        }
        [TestMethod]
        public void GetPasswordStrength_UpperCase_3Points()
        {
            string password = "Password";
            int expected = 3; // верхний регистр 1, за длину строки 1, за нижний регистр 1
                              // Act
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetPasswordStrength_ConteinsNumber_0_4Points()
        {
            // Arrange
            string password = "Passw0rd";
            // верхний регистр 1, за длину строки 1, за нижний регистр 1
            // число 1
            int expected = 4;
            // Act
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetPasswordStrength_ConteinsNumber_1_4Points()
        {
            // Arrange
            string password = "Passw1rd";
            // верхний регистр 1, за длину строки 1, за нижний регистр 1
            // число 1
            int expected = 4;
            // Act
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_at_5Points()
        {
            // Arrange
            string password = "Passw0rd@";
            // верхний регистр 1, за длину строки 1, за нижний регистр 1
            // число 1, специальный символ 1
            int expected = 5;
            // Act
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_Hash_5Points()
        {
            // Arrange
            string password = "Passw0rd#";
            // верхний регистр 1, за длину строки 1, за нижний регистр 1
            // число 1, специальный символ 1
            int expected = 5;
            // Act
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_Excl_5Points()
        {
            // Arrange
            string password = "Passw0rd!";
            // верхний регистр 1, за длину строки 1, за нижний регистр 1
            // число 1, специальный символ 1
            int expected = 5;
            // Act
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_Doll_5Points()
        {
            // Arrange
            string password = "Passw0rd$";
            // верхний регистр 1, за длину строки 1, за нижний регистр 1
            // число 1, специальный символ 1
            int expected = 5;
            // Act
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
