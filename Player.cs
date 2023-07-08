using System;

namespace GenPOTW
{
    public class Player
    {
        const int RECEPTIONS_POINTS = 2;
        const int PASSING_TOUCHDOWNS_POINTS = 5;
        const int RECIEVING_TOUCHDOWNS_POINTS = 5;
        const int RUSHING_TOUCHDOWNS_POINTS = 4;
        const int INTERCEPTIONS_THROWN_POINTS = -4;
        const int INTERCEPTIONS_CAUGHT_POINTS = 4;
        const int SACKS_POINTS = 2;
        const int SAFETIES_CONVERTED_POINTS = 2;
        const int TACKLES_POINTS = 1;
        
        
        
        public Player(string name, string receptions, string passingTouchdowns, string recievingTouchdowns,
            string rushingTouchdowns, string interceptionsThrown, string interceptionsCaught, string sacks, string safetiesConverted,
            string tackles)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _receptions = int.Parse(receptions);
            _passing_touchdowns = int.Parse(passingTouchdowns);
            _recieving_touchdowns = int.Parse(recievingTouchdowns);
            _rushing_touchdowns = int.Parse(rushingTouchdowns);
            _interceptions_thrown = int.Parse(interceptionsThrown);
            _interceptions_caught = int.Parse(interceptionsCaught);
            _sacks = int.Parse(sacks);
            _safeties_converted = int.Parse(safetiesConverted);
            _tackles = int.Parse(tackles);
        }

        private string _name;
        private int _receptions;
        private int _passing_touchdowns;
        private int _recieving_touchdowns;
        private int _rushing_touchdowns;
        private int _interceptions_thrown;
        private int _interceptions_caught;
        private int _sacks;
        private int _safeties_converted;
        private int _tackles;

        public int _potwscore;

        public string getName()
        {
            return _name;
        }
        public int getReceptions()
        {
            return _receptions;
        }
        public int getPassingTouchdowns()
        {
            return _passing_touchdowns;
        }
        public int getRecievingTouchdowns()
        {
            return _recieving_touchdowns;
        }
        public int getRushingTouchdowns()
        {
            return _rushing_touchdowns;
        }
        public int getInterceptionsThrown()
        {
            return _interceptions_thrown;
        }
        public int getInterceptionsCaught()
        {
            return _interceptions_caught;
        }
        public int getSacks()
        {
            return _sacks;
        }
        public int getSafetiesConverted()
        {
            return _safeties_converted;
        }

        public int getTackles()
        {
            return _tackles;
        }

        public void calculateScore()
        {
            _potwscore += _receptions * RECEPTIONS_POINTS;
            _potwscore += _passing_touchdowns * PASSING_TOUCHDOWNS_POINTS;
            _potwscore += _recieving_touchdowns * RECIEVING_TOUCHDOWNS_POINTS;
            _potwscore += _rushing_touchdowns * RUSHING_TOUCHDOWNS_POINTS;
            _potwscore += _interceptions_thrown * INTERCEPTIONS_THROWN_POINTS;
            _potwscore += _interceptions_caught * INTERCEPTIONS_CAUGHT_POINTS;
            _potwscore += _sacks * SACKS_POINTS;
            _potwscore += _safeties_converted * SAFETIES_CONVERTED_POINTS;
            _potwscore += _tackles * TACKLES_POINTS;
            // Console.WriteLine(_potwscore);
        }
    }
}