﻿using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        // TODO: Write your test here...

        // Arrange
        int input = 0;

        // Act
        int result = Factorial.CalculateFactorial(input);

        // Assert
        Assert.AreEqual(1, result);
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // TODO: Write your test here...

        // Arrange
        int input = 3;

        // Act
        int result = Factorial.CalculateFactorial(input);

        // Assert
        Assert.AreEqual(6, result);
    }

    [Test]
    public void Test_CalculateFactorial_InputNegativeNumber_ThrowsException()
    {
        // TODO: Write your test here...
        // Arrange
        int input = -1;

        // Act + Assert
        //int result = Factorial.CalculateFactorial(input);

        // Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => Factorial.CalculateFactorial(input));
    }
}
