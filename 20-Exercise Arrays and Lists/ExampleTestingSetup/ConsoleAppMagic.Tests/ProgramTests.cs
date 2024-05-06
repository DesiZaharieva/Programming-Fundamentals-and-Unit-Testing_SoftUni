using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace ConsoleAppMagic.Tests
{
    public class ProgramTests
    {


        [Test]
        public void Test_WhenSumIsGivenTwoParams_ShouldRetrunCurrentSum()
        {
            var sum = Program.Sum(10, 20);
            Assert.AreEqual(30, sum);
        }
    }
}