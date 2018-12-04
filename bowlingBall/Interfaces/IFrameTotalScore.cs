using System;
namespace bowlingBall.Interfaces
{
    public interface IFrameTotalScore
    {
        int[][] _balls { get; set; } 
        int _totalScore { get; set; }
        int _index { get; set; }

        int FrameTotalScore();
    }
}
