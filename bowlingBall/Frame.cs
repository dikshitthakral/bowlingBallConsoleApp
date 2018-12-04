using bowlingBall.Interfaces;

namespace bowlingBall
{
    public class Frame : IStrikeSpare,ICurrentScore
    {
        public int[] _ball;
        private int score = 0;

        public Frame(int[] ball) 
        {
            _ball = ball;
        }

        public int CurrentScore()
        {
            for (int i = 0; i < _ball.Length; i++)
            {
                score = score + _ball[i];
            }
            return score;
        }

        public bool IsStrike()
        {
            if (_ball[0] == 10)
            {
                return true;
            }
            return false;
        }

        public bool IsSpare()
        {
            int s = 0;
            for (int i = 0; i < _ball.Length; i++)
            {
                s = s + _ball[i];
            }
            if(s >= 10) 
            {
                return true;    
            }
            return false;
        }
    }
}