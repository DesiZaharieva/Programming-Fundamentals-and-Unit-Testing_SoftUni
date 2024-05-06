using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // TODO: finish test
        // Arrange
        List<int> oneElementList = new() {45};

        // Act 
        int result = MaxNumber.FindMax(oneElementList);

        // Assert
        Assert.That(result, Is.EqualTo(45));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // TODO: finish test
        // Arrange
        List<int> positiveElementList = new() {5, 6, 99};

        // Act 
        int result = MaxNumber.FindMax(positiveElementList);

        // Assert
        Assert.That(result, Is.EqualTo(99));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // TODO: finish test
        // Arrange
        List<int> negativeElementList = new() { -5, -6, -99 };

        // Act 
        int result = MaxNumber.FindMax(negativeElementList);

        // Assert
        Assert.That(result, Is.EqualTo(-5));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // TODO: finish test
        // Arrange
        List<int> integerElementList = new() { -5, 8, -99, 89 };

        // Act 
        int result = MaxNumber.FindMax(integerElementList);

        // Assert
        Assert.That(result, Is.EqualTo(89));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // TODO: finish test
        // Arrange
        List<int> dublicateElementList = new() { -5, 33, -99, 33 };

        // Act 
        int result = MaxNumber.FindMax(dublicateElementList);

        // Assert
        Assert.That(result, Is.EqualTo(33));
    }
}
