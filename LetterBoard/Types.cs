namespace LetterBoard
{
    public enum Direction
    {
        Left,
        Right
    }
    
    public struct Move
    {
        private const char EmptyLetter = (char)0;

        public Direction Direction { get; private set; }
        public char Letter { get; private set; }
        
        public Move(Direction direction, char letter)
        {
            Direction = direction;
            Letter = letter;
        }
        
        public Move(Direction direction)
            : this(direction, EmptyLetter)
        {
        }

        public override string ToString()
        {
            return $"{Direction}:{Letter}";
        }
    }
}
