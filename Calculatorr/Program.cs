using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== My Simple Calculator ===\n");

            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("[a] Add");
            Console.WriteLine("[s] Subtract");
            Console.WriteLine("[m] Multiply");
            Console.WriteLine("[d] Divide");

            Console.Write("\nEnter your choice: ");
            string op = Console.ReadLine();

            int result = 0;
            bool valid = true;

            if (op == "a")
            {
                result = num1 + num2;
            }
            else if (op == "s")
            {
                result = num1 - num2;
            }
            else if (op == "m")
            {
                result = num1 * num2;
            }
            else if (op == "d")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero!");
                    valid = false;
                }
            }
            else
            {
                Console.WriteLine("Invalid operation.");
                valid = false;
            }

            if (valid)
            {
                Console.WriteLine($"\nResult: {result}");
            }

            Console.WriteLine("\nThanks for using my calculator!");
            //thank
        }
    }
}
