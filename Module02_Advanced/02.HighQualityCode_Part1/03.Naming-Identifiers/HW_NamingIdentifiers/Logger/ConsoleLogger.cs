using System;

namespace Logger
{
    public class ConsoleLogger
    {
        public void ConsoleLogBoolVariable(bool variable)
        {
            string stringVariable = variable.ToString();
            Console.WriteLine(stringVariable);
        }
    }
}