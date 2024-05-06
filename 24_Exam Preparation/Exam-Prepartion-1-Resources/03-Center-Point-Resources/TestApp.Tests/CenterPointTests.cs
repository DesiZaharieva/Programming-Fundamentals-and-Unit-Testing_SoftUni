using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        // Arrange
        double firstPointX = 1;
        double firstPointY = 1;
        double secondtPointX = 2;
        double secondtPointY = 2;
        // Act
        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondtPointX, secondtPointY);

        // Assert
        Assert.AreEqual("(1, 1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        // Arrange
        double firstPointX = 2;
        double firstPointY = 2;
        double secondtPointX = 1.3;
        double secondtPointY = 1.3;
        // Act
        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondtPointX, secondtPointY);


        // Assert
        Assert.AreEqual("(1.3, 1.3)", result);

    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        // Arrange
        double firstPointX = 1;
        double firstPointY = 1;
        double secondtPointX = 1;
        double secondtPointY = 1;
        // Act
        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondtPointX, secondtPointY);

        // Assert
        Assert.AreEqual("(1, 1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        // Arrange
        double firstPointX = -1;
        double firstPointY = -1;
        double secondtPointX = 1;
        double secondtPointY = 1;
        // Act
        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondtPointX, secondtPointY);

        // Assert
        Assert.AreEqual("(-1, -1)", result);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        // Arrange
        double firstPointX = 1;
        double firstPointY = 1;
        double secondtPointX = -1;
        double secondtPointY = -1;
        // Act
        string result = CenterPoint.GetClosest(firstPointX, firstPointY, secondtPointX, secondtPointY);

        // Assert
        Assert.AreEqual("(-1, -1)", result);
    }

}