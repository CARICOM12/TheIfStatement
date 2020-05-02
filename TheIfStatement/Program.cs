using System;

namespace TheIfStatement
{
    class MainClass
    {
        public static bool InputNumber()
        {
            int num1;

            Console.WriteLine("Please enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 1)
            {
                Console.WriteLine("The number is one");
                return true;
            }
            else if (num1 == 2)
            {
                Console.WriteLine("The number is two");
                return true;
            }
            else if (num1 == 3)
            {
                Console.WriteLine("The number is three");
                return true;
            }
            else
            {
                Console.WriteLine("I don't know this number. I am a robot, " +
                	"I can count up to 3 only.");
                return false;
            }
        }
        public static void Main(string[] args)
        {
            var knownAnswer = true;
            while(knownAnswer)
            {
                knownAnswer = InputNumber();
            }
        }
    }
}
