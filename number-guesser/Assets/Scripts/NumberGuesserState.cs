namespace State
{
    public class NumberGuesserState
    {
        public int iCurrentGuess { get; }
        public int TurnCounter { get; }
        public int Floor { get; }
        public int Ceiling { get; }

        public float fNumber;

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