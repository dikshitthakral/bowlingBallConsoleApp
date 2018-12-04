using Microsoft.VisualStudio.TestTools.UnitTesting;
using bowlingBall;

namespace bowlingBall.Test
{
    [TestClass]
    public class FrameTest
    {
        [TestMethod]
        public void Test_CurrentScore()
        {
            // Arrange
            int expectedScore = 10;
            int[] ball = { 1, 9 };

            //Act
            Frame fmTest = new Frame(ball);
            int actualScore = fmTest.CurrentScore();

            //Assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void Test_IsStrike()
        {
            // Arrange
            bool expected = false;
            int[] ball = { 1, 9 };

            //Act
            Frame fmTest = new Frame(ball);
            bool actual = fmTest.IsStrike();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Test_IsSpare()
        {
            // Arrange
            bool expected = true;
            int[] ball = { 1, 9 };

            // Act
            Frame fmTest = new Frame(ball);
            bool actual = fmTest.IsSpare();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
