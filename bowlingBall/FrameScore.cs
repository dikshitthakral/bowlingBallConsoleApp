using System;
using bowlingBall.Interfaces;

namespace bowlingBall
{
    public class FrameScore: IFrameTotalScore
    {
        public int[][] _balls { get; set; }
        public int _totalScore { get; set; }
        public int _index { get; set; }

        public FrameScore(int[][] balls, int totalScore, int index)
        {
            this._balls = balls;
            this._totalScore = totalScore;
            this._index = index;
        }

        public int FrameTotalScore()
        {
            Frame currentFrame = new Frame(_balls[this._index]);
            if(currentFrame.IsStrike() && _index < _balls.Length -1) 
            {
                return _totalScore + StrikeTotalScore(_index) + currentFrame.CurrentScore();
            }
            else if(currentFrame.IsSpare() && _index < _balls.Length -1 )
            {
                return _totalScore + SpareTotalScore(_index) + currentFrame.CurrentScore();
            }

            return _totalScore + currentFrame.CurrentScore();
        }

        private int StrikeTotalScore(int index)
        {
            Frame frame = new Frame(_balls[index + 1]);
            if(frame.IsStrike() && index + 1 < _balls.Length - 1) 
            {
                return frame.CurrentScore() + _balls[index + 2][0];
            }
            return frame.CurrentScore();
        }

        private int SpareTotalScore(int index)
        {
            return _balls[index + 1][0];
        }

    }
}
