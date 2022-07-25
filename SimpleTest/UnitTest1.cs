using NUnit.Framework;
using SimpleConsoleApp;

namespace SimpleTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSum()
        {
            Assert.IsTrue(MathFunc.Sum(2, 3) == 5);
        }
    }
}