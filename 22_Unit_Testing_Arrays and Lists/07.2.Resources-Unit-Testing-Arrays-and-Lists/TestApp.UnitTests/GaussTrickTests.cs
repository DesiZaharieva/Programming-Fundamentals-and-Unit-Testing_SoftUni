using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> singleElementList = new() {33};

        // Act
        List<int> result = GaussTrick.SumPairs(singleElementList);

        // Assert
        //CollectionAssert.AreEqual(list, result);
        CollectionAssert.AreEqual(singleElementList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> evenLIst = new() { 3, 5, 2, 3 };


        // Act
        List<int> result = GaussTrick.SumPairs(evenLIst);
        //List<int> result = GaussTrick.SumPairs(list);

        // Assert
        List<int> assertEven = new() {6, 7};
        CollectionAssert.AreEqual(result, assertEven);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // TODO: finish the test
        //Arrange
        List<int> listOdd = new() {4, 6, 3, 4, 8};

        //Act
        List<int> result = GaussTrick.SumPairs(listOdd);

        // Assert
        List<int> assertOdd = new() {12, 10, 3};
        CollectionAssert.AreEqual(result, assertOdd);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // TODO: finish the test
        //Arrange
        List<int> listEven = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //Act
        List<int> result = GaussTrick.SumPairs(listEven);

        // Assert
        List<int> assertEven = new() {11, 11, 11, 11, 11};
        CollectionAssert.AreEqual(result, assertEven);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // TODO: finish the test
        //Arrange
        List<int> listOdd = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

        //Act
        List<int> result = GaussTrick.SumPairs(listOdd);

        // Assert
        List<int> assertOdd = new() { 12, 12, 12, 12, 12, 6};
        CollectionAssert.AreEqual(result, assertOdd);

    }
}
