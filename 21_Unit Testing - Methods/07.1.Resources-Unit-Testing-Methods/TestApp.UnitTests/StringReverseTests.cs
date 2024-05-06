using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
        //StringReverse.Reverse(input);

        string result = StringReverse.Reverse(input);

        // Assert
        //Assert.AreEqual();

        Assert.AreEqual(input, result);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // TODO: Write your test here...
        // Arrange
        string input = "X";

        // Act
        //StringReverse.Reverse(input);

        string result = StringReverse.Reverse(input);

        // Assert
        //Assert.AreEqual();

        Assert.AreEqual("X", result);

    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // TODO: Write your test here...

        // Arrange
        string input = "xyz";

        // Act
        //StringReverse.Reverse(input);

        string result = StringReverse.Reverse(input);

        // Assert
        //Assert.AreEqual();

        Assert.AreEqual(input.Length, result.Length);
    }
}
