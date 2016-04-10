using System;
using NUnit.Framework;
using ToySimulator.ConsoleChecker;
using ToySimulator.Toy;

namespace ToySimulator.Test
{
    [TestFixture]
    public class TestConsoleChecker
    {
        [Test]
        public void Test_Valid_PLACE_Command()
        {
            var inputParser = new InputParser();
            string[] rawInput = "PLACE".Split(' ');

            var command = inputParser.ParseCommand(rawInput);
            Assert.AreEqual(Command.Place, command);
        }

        [Test]
        public void Test_Invalid_PLACE_Command()
        {
            var inputParser = new InputParser();
            string[] rawInput = "PLACETOY".Split(' ');

            var exception = Assert.Throws<ArgumentException>(delegate { inputParser.ParseCommand(rawInput); });
            Assert.That(exception.Message, Is.EqualTo("Sorry, your command was not recognised. Please try again using the following format: PLACE X,Y,F|MOVE|LEFT|RIGHT|REPORT"));
        }

        [Test]
        public void Test_Valid_PLACE_CommandandParams()
        {
            var inputParser = new InputParser();
            string[] rawInput = "PLACE 4,3,WEST".Split(' ');

            var placeCommandParameter = inputParser.ParseCommandParameter<PlaceCommandParameter>(new PlaceCommandParameterParser(), rawInput);

            Assert.AreEqual(4, placeCommandParameter.Position.X);
            Assert.AreEqual(3, placeCommandParameter.Position.Y);
            Assert.AreEqual(Direction.West, placeCommandParameter.Direction);
        }

        [Test]
        public void Test_Invalid_PLACE_CommandandParams()
        {
            var inputParser = new InputParser();
            string[] rawInput = "PLACE 3,1".Split(' ');

            var exception = Assert.Throws<ArgumentException>(delegate
            {
                inputParser.ParseCommandParameter<PlaceCommandParameter>(new PlaceCommandParameterParser(), rawInput);

            });
            Assert.That(exception.Message, Is.EqualTo("Incomplete command. Please ensure that the PLACE command is using format: PLACE X,Y,F"));
        }

        [Test]
        public void Test_Invalid_PLACE_Direction()
        {
            var paramParser = new PlaceCommandParameterParser();
            string[] rawInput = "PLACE 2,4,OneDirection".Split(' ');

            var exception = Assert.Throws<ArgumentException>(delegate { paramParser.ParseParameters(rawInput); });
            Assert.That(exception.Message, Is.EqualTo("Invalid direction. Please select from one of the following directions: NORTH|EAST|SOUTH|WEST"));
        }

        [Test]
        public void Test_Invalid_PLACE_ParamsFormat()
        {
            var paramParser = new PlaceCommandParameterParser();
            string[] rawInput = "PLACE 3,3,SOUTH,2".Split(' ');

            var exception = Assert.Throws<ArgumentException>(delegate { paramParser.ParseParameters(rawInput); });
            Assert.That(exception.Message, Is.EqualTo("Incomplete command. Please ensure that the PLACE command is using format: PLACE X,Y,F"));
        }

    }
}
