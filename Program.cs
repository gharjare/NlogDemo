using Microsoft.Extensions.Logging;
using NLog;

namespace NLogDemo1
{
    class program
    { 
        static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main()
        {
            Console.WriteLine("Enter number");
            int number1 = int.Parse(Console.ReadLine());
            logger.Trace($"User entered first value{number1}");
            Console.WriteLine("Enter number");
            int number2 = int.Parse(Console.ReadLine());
            logger.Trace($"User entered second value{number2}");
            NLogDemo1.Math m = new NLogDemo1.Math();
            int result = m.Add(number1, number2);
            Console.WriteLine($"Result is{result}");
            int result2 = m.Divide(number2, number1);
            Console.WriteLine($"Result is{result2}");

        }
    }
}
