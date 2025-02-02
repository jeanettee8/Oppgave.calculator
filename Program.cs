﻿namespace Oppgave.calculator;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            // gives user multiple choices
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine();
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            //what the user writes, is assigned to the name choice
            string choice = Console.ReadLine();

            if (choice == "5")
            {
                // running is false, and the while loop is "while running is true"
                // = the while loop isn't active now
                running = false;
                Console.WriteLine("Exiting the calculator. Goodbye!");
                continue;
            }

            Console.WriteLine("Enter the first number:");
            double num1;
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                //if it can't parse = if they didn't write a number
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }

            Console.WriteLine("Enter the second number:");
            double num2;
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                 //if it can't parse = if they didn't write a number
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }

            double result = 0;
            switch (choice)
            {
                case "1":
                    result = Add(num1, num2);
                    break;
                case "2":
                    result = Subtract(num1, num2);
                    break;
                case "3":
                    result = Multiply(num1, num2);
                    break;
                case "4":
                    result = Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            Console.WriteLine($"Result: {result}");
            Console.WriteLine("");
        
        }
    }

    //methods used in the switch case
    static double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    static double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return 0;
        }
        return num1 / num2;
    }
}