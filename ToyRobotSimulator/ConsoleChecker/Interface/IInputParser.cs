using System;
using ToySimulator.Toy;

namespace ToySimulator.ConsoleChecker.Interface
{
    public interface IInputParser
    {
        /// Interface to process the raw input from the 
        /// user.

        Command ParseCommand(string[] rawInput);

        /// This extracts the parameters from the user's input.        

        TParam ParseCommandParameter<TParam>(ICommandParameterChecker commandParameter, string[] input)
            where TParam : ICommandParameter;
    }
}
