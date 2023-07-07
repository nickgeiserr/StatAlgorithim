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
        
        
        
        public Player(string name, int receptions, int passingTouchdowns, int recievingTouchdowns,
            int rushingTouchdowns, int interceptionsThrown, int interceptionsCaught, int sacks, int safetiesConverted,
            int tackles)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _receptions = receptions;
            _passing_touchdowns = passingTouchdowns;
            _recieving_touchdowns = recievingTouchdowns;
            _rushing_touchdowns = rushingTouchdowns;
            _interceptions_thrown = interceptionsThrown;
            _interceptions_caught = interceptionsCaught;
            _sacks = sacks;
            _safeties_converted = safetiesConverted;
            _tackles = tackles;
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