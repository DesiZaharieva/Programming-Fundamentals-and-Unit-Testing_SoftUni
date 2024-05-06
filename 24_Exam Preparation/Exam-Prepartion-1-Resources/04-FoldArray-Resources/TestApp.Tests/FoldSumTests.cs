using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    [TestCase(new int[] { 1, 2, 3, 4 }, "3 7")]
    [TestCase(new int[] { 7, 7, 7, 7 }, "14 14")]
    [TestCase(new int[] { 2, 2, 2, 2  }, "4 4")]
    // [TestCase(new int[] { 3, 4, 8, 8  }, "7 16")]
    //[TestCase(new int[] { }, " ")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        //Arrange

        //Act
       string result = FoldSum.FoldArray(arr);

        //Accert
        Assert.AreEqual(expected, result);
    }
}
