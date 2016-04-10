using System;
using ToySimulator.ConsoleChecker.Interface;
using ToySimulator.Toy;

namespace ToySimulator.ConsoleChecker
{
    /// Extracts the commands and parameters from the raw user input.

    public class InputParser : IInputParser
    {

        public Command ParseCommand(string[] rawInput)
        {
            Command command;
            if (!Enum.TryParse(rawInput[0], true, out command))
                throw new ArgumentException("Sorry, your command was not recognised. Please try again using the following format: PLACE X,Y,F|MOVE|LEFT|RIGHT|REPORT");
            
            return command;
        }

        /// Extracts the parameters from the user input and returns it       

        public TParam ParseCommandParameter<TParam>(ICommandParameterChecker commandParameter, string[] input)
            where TParam : ICommandParameter
        {            
            return (TParam)commandParameter.ParseParameters(input);
        }     
    }



}
