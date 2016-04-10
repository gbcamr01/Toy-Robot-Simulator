using System;

namespace ToySimulator.ConsoleChecker.Interface
{
    public interface ICommandParameterChecker
    {
        ///This interface give access to the 
        /// ParseParameter method used to check the toy 
        /// direction and position.
        ICommandParameter ParseParameters(string[] input);
    }
}
