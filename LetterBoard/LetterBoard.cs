using System.Collections.Generic;
using System.Linq;

namespace LetterBoard
{
    public static class LetterBoard
    {
        public static IEnumerable<Move> SolveLetterBoard(List<char> board, string word)
        {
            List<Move> moves = new List<Move>();

            foreach (char c in word)
            {
                int firstIndexOf = board.IndexOf(c); // This also gives us distance from beginning.
                int lastIndexOf = board.LastIndexOf(c); // This gives us index only, not distance from end.
                int distanceFromEnd = board.Count() - lastIndexOf - 1; // This gives us the distance from the end this index is.

                // If multiple instances of letter exist, figure out which one is closer to its end.
                if (firstIndexOf <= distanceFromEnd)
                {
                    // Move each letter prior to target to the end.
                    for (int i = 0; i < firstIndexOf; i++)
                    {
                        board.MoveToEnd(0);
                        moves.Add(new Move(Direction.Left));
                    }
                    
                    moves.Add(new Move(Direction.Left, c));
                    board.RemoveAt(0);
                }
                else
                {
                    // Move each letter prior to target to the beginning.
                    for (int i = lastIndexOf; i < board.Count() - 1; i++)
                    {
                        board.MoveToBeginning(board.Count() - 1);
                        moves.Add(new Move(Direction.Right));
                    }
                    
                    moves.Add(new Move(Direction.Right, c));
                    board.RemoveAt(board.Count() - 1);
                }
            }

            return moves;
        }
    }
}
