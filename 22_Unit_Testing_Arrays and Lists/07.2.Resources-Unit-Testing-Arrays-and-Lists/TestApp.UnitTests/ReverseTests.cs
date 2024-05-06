using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] inputHasOneElemen = new int[1] { 42 };

        // Act
        string result = Reverse.ReverseArray(inputHasOneElemen);

        // Assert
        Assert.That(result, Is.EqualTo("42"));
        //Assert.That(result, Is.EqualTo("42"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        // TODO: finish the test
        // Arrange
        int[] multipleElementss = new int[5] { 1, 2, 3, 4, 5 };

        // Act
        string result = Reverse.ReverseArray(multipleElementss);

        // Assert 
        Assert.That(result, Is.EqualTo("5 4 3 2 1"));
        
    }
}
