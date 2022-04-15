using NUnit.Framework;
using System.Collections.Generic;

namespace LetterBoard.Tests
{
    public class Tests
    {
        static object[] WordMappings =
        {
            new object[]
            {
                "cat",
                new List<char>() { 'a', 'z', 'c', 't', 'v', 'a' },
                new List<Move>
                {
                    new Move(Direction.Left),
                    new Move(Direction.Left),
                    new Move(Direction.Left, 'c'),
                    new Move(Direction.Right),
                    new Move(Direction.Right, 'a'),
                    new Move(Direction.Left),
                    new Move(Direction.Left, 't'),
                }
            },
            new object[]
            {
                "tv",
                new List<char>() { 'a', 'z', 'c', 't', 'v', 'a' },
                new List<Move>
                {
                    new Move(Direction.Right),
                    new Move(Direction.Right),
                    new Move(Direction.Right, 't'),
                    new Move(Direction.Left, 'v')
                }
            }
        };

        [Test, TestCaseSource("WordMappings")]
        public void TestLetterBoard(string word, List<char> board, List<Move> expectedMoves)
        {
            var actualMoves = LetterBoard.SolveLetterBoard(board, word);
            
            Assert.AreEqual(expectedMoves, actualMoves);
        }
    }
}
