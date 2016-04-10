using NUnit.Framework;
using ToySimulator.Toy;
using ToySimulator.ToyBoard;

namespace ToySimulator.Test
{
    [TestFixture]
    public class TestBoard
    {

        /// <summary>
        /// Try to put the toy outside of the board
        /// </summary>
        [Test]
        public void Test_Invalid_BoardPosition()
        {
            ToyBoard.ToyBoard squareBoard = new ToyBoard.ToyBoard(5, 5);            
            Position position = new Position(6, 6);
          
            var result = squareBoard.IsValidPosition(position);
            Assert.IsFalse(result);
        }
        
        /// <summary>
        /// Test valid positon 
        /// </summary>
        [Test]
        public void Test_Valid_BoardPosition()
        {
            ToyBoard.ToyBoard squareBoard = new ToyBoard.ToyBoard(5, 5);
            Position position = new Position(1, 4);

            var result = squareBoard.IsValidPosition(position);
            Assert.IsTrue(result);            
        }   

    }
}
