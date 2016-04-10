using NUnit.Framework;
using ToySimulator.Toy;

namespace ToySimulator.Test
{
    [TestFixture]
    public class TestToyRobot
    {

        [Test]
        public void Test_Valid_Toy_turnLEFT()
        {
            var robot = new ToyRobot { Direction = Direction.West, Position = new Position(2, 2) };            
            robot.RotateLeft();
            Assert.AreEqual(Direction.South,robot.Direction);
        }

        [Test]
        public void Test_Valid_Toy_turnRIGHT()
        {
            var robot = new ToyRobot { Direction = Direction.West, Position = new Position(2, 2) };
            robot.RotateRight();
            Assert.AreEqual(Direction.North, robot.Direction);
        }


        /// <summary>
        /// Test move
        /// </summary>
        [Test]
        public void Test_Valid_Toy_MOVE()
        {
            var robot = new ToyRobot { Direction = Direction.East, Position = new Position(2, 2) };
            var nextPosition = robot.GetNextPosition();

            Assert.AreEqual(3, nextPosition.X);
            Assert.AreEqual(2, nextPosition.Y);
        }


        [Test]
        public void Test_Valid_Toy_PositionandDirection()
        {
            var position = new Position(3, 3);
            var robot = new ToyRobot();

            robot.Place(position, Direction.North);

            Assert.AreEqual(3, robot.Position.X);
            Assert.AreEqual(3, robot.Position.Y);
            Assert.AreEqual(Direction.North, robot.Direction);
        }

    }
}
