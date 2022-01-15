namespace State
{
    public class NumberGuesserState
    {
        public int CurrentGuess { get; set; }
        public int TurnCounter { get; set; }
        public int Floor { get; set; }
        public int Ceiling { get; set; }

        public NumberGuesserState()
        {
            CurrentGuess = 50;
            TurnCounter = 1;
            Floor = 0;
            Ceiling = 101;
        }

        public NumberGuesserState(int _currentGuess, int _turnCounter, int _floor, int _ceiling)
        {
            CurrentGuess = _currentGuess;
            TurnCounter = _turnCounter;
            Floor = _floor;
            Ceiling = _ceiling;
        }
    }
}