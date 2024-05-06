using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] evenArray = new int[2] { 15, 5};

        // Act
        int result = EvenOddSubtraction.FindDifference(evenArray);

        // Assert
        //Assert.That(result, Is.EqualTo(20));
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // TODO: finish the test

        // Arrange
        int[] oddArray = new int[2] {6, 14};

        // Act
        int result = EvenOddSubtraction.FindDifference(oddArray);

        // Assert

        Assert.That(result, Is.EqualTo(20));


    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // TODO: finish the test

        // Arrange

        int[] differenceArray = new int[4] {2,5, 9,8};

        // Act 
        int result = EvenOddSubtraction.FindDifference(differenceArray);

        // Asssert
        Assert.That(result, Is.EqualTo(4));
    }
}
