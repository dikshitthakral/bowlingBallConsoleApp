using System;
using System.Collections.Generic;

namespace bowlingBall
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // your code goes here
            int totalScore = 0;
            // input for game
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
            for (int i = 0; i < balls.Length;i++){
                FrameScore fm = new FrameScore(balls, totalScore, i);
                totalScore = fm.FrameTotalScore();
                Console.WriteLine("Score for frame {0} is {1}", i, totalScore);
            }
        }
    }
}
