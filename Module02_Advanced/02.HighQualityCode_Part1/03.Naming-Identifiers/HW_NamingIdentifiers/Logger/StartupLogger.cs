namespace Logger
{
    public class StartupLogger
    {
        private const int MAX_COUNT = 6;

        public static void Main()
        {
            var logger = new ConsoleLogger();
            logger.ConsoleLogBoolVariable(true);
        }
    }
}
