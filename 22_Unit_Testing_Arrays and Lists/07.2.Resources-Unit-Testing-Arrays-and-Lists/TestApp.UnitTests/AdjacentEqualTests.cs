using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => AdjacentEqual.Sum(nullList), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.IsEmpty(result);
    }


    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
    // Arrange
    List<int> originalList = new() { 1, 2, 3};

    // Act
    string result = AdjacentEqual.Sum(originalList);

    // Assert
    //Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    Assert.That(result, Is.EqualTo("1 2 3"));
}

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // TODO: finish test
        // Arrange
        List<int> sumBeginList = new() { 1, 1, 3, 4 };

        // Act
        string result = AdjacentEqual.Sum(sumBeginList);

        // Assert
        //Assert.That(result, Is.EqualTo("1 2 3 4 5"));
        Assert.That(result, Is.EqualTo("2 3 4"));

    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // TODO: finish test
        // Arrange
        List<int> sumSingeList = new() { 1, 1, 2 };

        // Act
        string result = AdjacentEqual.Sum(sumSingeList);

        // Assert
        //Assert.That(result, Is.EqualTo("1 2 3 4 5"));
        Assert.That(result, Is.EqualTo("4"));
    }


    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()

    {
    // TODO: finish test
    // Arrange
    List<int> sumBeginList = new() { 1, 1, 3, 4 };

    // Act
    string result = AdjacentEqual.Sum(sumBeginList);

    // Assert
    //Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    Assert.That(result, Is.EqualTo("2 3 4"));
}

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // TODO: finish test
        // Arrange
        List<int> sumEndList = new() { 1, 2, 3, 4, 4 };

        // Act
        string result = AdjacentEqual.Sum(sumEndList);

        // Assert
        //Assert.That(result, Is.EqualTo("1 2 3 4 5"));
        Assert.That(result, Is.EqualTo("1 2 3 8"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // TODO: finish test
        // Arrange
        List<int> sumMiddleList = new() { 1, 2, 3, 3, 4, 7 };

        // Act
        string result = AdjacentEqual.Sum(sumMiddleList);

        // Assert
        //Assert.That(result, Is.EqualTo("1 2 3 4 5"));
        Assert.That(result, Is.EqualTo("1 2 6 4 7"));
    }
}
