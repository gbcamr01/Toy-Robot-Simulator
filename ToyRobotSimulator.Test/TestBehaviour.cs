using NUnit.Framework;
using ToySimulator.ConsoleChecker;
using ToySimulator.ConsoleChecker.Interface;
using ToySimulator.Toy;
using ToySimulator.Toy.Interface;
using ToySimulator.ToyBoard.Interface;
using ToySimulator.ToyBoard;

namespace ToySimulator.Test
{
    [TestFixture]
    public class TestBehaviour
    {
        /// <summary>
        /// Ensures toy can be placed on the board. 
        /// </summary>
        [Test]
        public void Test_Valid_Bhvr_PLACE()
        {

            ItoyBoard squareBoard = new ToyBoard.ToyBoard(5, 5);
            IInputParser inputParser = new InputParser();
            IToyRobot robot = new ToyRobot();

            var simulator = new Behaviours.Behaviour(robot, squareBoard, inputParser);
            simulator.ProcessCommand("PLACE 1,4,EAST".Split(' '));

            Assert.AreEqual(1, robot.Position.X);
            Assert.AreEqual(4, robot.Position.Y);
            Assert.AreEqual(Direction.East, robot.Direction);
        }

        /// <summary>
        /// Try to place robot outside of the square board.
        /// </summary>
        [Test]
        public void Test_Invalid_Bhvr_PLACE()
        {
            ItoyBoard squareBoard = new ToyBoard.ToyBoard(5, 5);
            IInputParser inputParser = new InputParser();
            IToyRobot robot = new ToyRobot();

            var simulator = new Behaviours.Behaviour(robot, squareBoard, inputParser);
            simulator.ProcessCommand("PLACE 9,7,EAST".Split(' '));

            Assert.IsNull(robot.Position);
        }

        /// <summary>
        /// Ensure toy robot can move to next step.
        /// </summary>
        [Test]
        public void Test_Valid_Bhvr_MOVE()
        {
            ItoyBoard squareBoard = new ToyBoard.ToyBoard(5, 5);
            IInputParser inputParser = new InputParser();
            IToyRobot robot = new ToyRobot();

            var simulator = new Behaviours.Behaviour(robot, squareBoard, inputParser);
            simulator.ProcessCommand("PLACE 3,2,SOUTH".Split(' '));
            simulator.ProcessCommand("MOVE".Split(' '));

            Assert.AreEqual("Output: 3,1,SOUTH", simulator.GetReport());
        }

        /// <summary>
        /// Try sending the toy off the board.
        /// </summary>
        [Test]
        public void Test_Invalid_Bhvr_MOVE()
        {
            ItoyBoard squareBoard = new ToyBoard.ToyBoard(5, 5);
            IInputParser inputParser = new InputParser();
            IToyRobot robot = new ToyRobot();

            var simulator = new Behaviours.Behaviour(robot, squareBoard, inputParser);
            simulator.ProcessCommand("PLACE 2,2,NORTH".Split(' '));
            simulator.ProcessCommand("MOVE".Split(' '));
            simulator.ProcessCommand("MOVE".Split(' '));

            // if the robot goes out of the board it ignores the command
            simulator.ProcessCommand("MOVE".Split(' '));

            Assert.AreEqual("Output: 2,4,NORTH", simulator.GetReport());

        }
        
        [Test]
        public void Test_Valid_Bhvr_REPORT()
        {
            ItoyBoard squareBoard = new ToyBoard.ToyBoard(5, 5);
            IInputParser inputParser = new InputParser();
            IToyRobot robot = new ToyRobot();

            var simulator = new Behaviours.Behaviour(robot, squareBoard, inputParser);
            simulator.ProcessCommand("PLACE 3,3,WEST".Split(' '));
            simulator.ProcessCommand("MOVE".Split(' '));
            simulator.ProcessCommand("MOVE".Split(' '));
            simulator.ProcessCommand("LEFT".Split(' '));
            simulator.ProcessCommand("MOVE".Split(' '));
            var output = simulator.ProcessCommand("REPORT".Split(' '));

            Assert.AreEqual("Output: 1,2,SOUTH", output);
        }
    }
}
