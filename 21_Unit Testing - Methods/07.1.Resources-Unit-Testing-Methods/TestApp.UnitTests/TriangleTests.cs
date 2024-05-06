using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        // TODO: Write your test here...
       
        // Arrange

        int input = 0;

        // Act

        string result = Triangle.PrintTriangle(input);

        // Assert 

        Assert.AreEqual("", result);

        }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        // TODO: Write your test here...

        // Arrange

        int input = 3;
        string expectedResult = "1" +
                               "" + Environment.NewLine +
                               "1 2" + Environment.NewLine +
                               "1 2 3" + Environment.NewLine +
                               "1 2" + Environment.NewLine +
                               "1";
                               



        // Act

        string result = Triangle.PrintTriangle(input);

        // Assert 

        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        // TODO: Write your test here...

        // Arrange

        int input = 5;
        string expectedResult = "1" +
                               "" + Environment.NewLine +
                               "1 2" + Environment.NewLine +
                               "1 2 3" + Environment.NewLine +
                               "1 2 3 4" + Environment.NewLine +
                               "1 2 3 4 5" + Environment.NewLine +
                               "1 2 3 4" + Environment.NewLine +
                               "1 2 3" + Environment.NewLine +
                               "1 2" + Environment.NewLine +
                               "1";




        // Act

        string result = Triangle.PrintTriangle(input);

        // Assert 

        Assert.AreEqual(expectedResult, result);

    }
}
