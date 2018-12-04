using Microsoft.VisualStudio.TestTools.UnitTesting;
using bowlingBall;

namespace bowlingBall.Test
{
    [TestClass]
    public class FrameScoreTest
    {
        
        [TestMethod]
        public void Test_FrameTotalScoreWhenStrike()
        {
            // Arrange
            int expectedScore = 20;
            int[][] balls = {
            new int[] { 10 },
            new int[] { 9,1 },
            new int[] { 5, 5 },
            new int[] { 7, 2 },
            new int[] { 10 },
            new int[] { 10 },
            new int[] { 10 },
            new int[] { 9, 0 },
            new int[] { 8, 2 },
            new int[] { 9, 1, 10 }
            };
            int index = 0;
            int totalScore = 0;

            // Act
            FrameScore fmmScore = new FrameScore(balls, totalScore, index);
            int actualScore = fmmScore.FrameTotalScore();

            // Assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void Test_FrameTotalScoreWhenSpare()
        {
            // Arrange
            int expectedScore = 35;
            int[][] balls = {
            new int[] { 10 },
            new int[] { 9,1 },
            new int[] { 5, 5 },
            new int[] { 7, 2 },
            new int[] { 10 },
            new int[] { 10 },
            new int[] { 10 },
            new int[] { 9, 0 },
            new int[] { 8, 2 },
            new int[] { 9, 1, 10 }
            };
            int index = 1;
            int totalScore = 20;

            // Act
            FrameScore fmmScore = new FrameScore(balls, totalScore, index);
            int actualScore = fmmScore.FrameTotalScore();

            // Assert
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void Test_FrameTotalScoreNotStrikeOrSpare()
        {
            // Arrange
            int expectedScore = 19;
            int[][] balls = {
            new int[] { 10 },
            new int[] { 9,1 },
            new int[] { 5, 5 },
            new int[] { 7, 2 },
            new int[] { 10 },
            new int[] { 10 },
            new int[] { 10 },
            new int[] { 9, 0 },
            new int[] { 8, 2 },
            new int[] { 9, 1, 10 }
            };
            int index = 3;
            int totalScore = 10;

            // Act
            FrameScore fmmScore = new FrameScore(balls, totalScore, index);
            int actualScore = fmmScore.FrameTotalScore();

            // Assert
            Assert.AreEqual(expectedScore, actualScore);
        }
    }
}
