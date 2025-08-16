using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace LearningCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // byte, short,int, long => whole numbers
            int firstNumber = 42;
            byte age = 30;

            // float, double => decimal numbers
            double height = 5.9;

            // type casting / Conversion
            int x = (int)5.9; // output: 5

            // naming convension
            double lastSalaryOfJanuary2025 = 5000.50;


            // string => text
            string fulName = "Aurgha Aurpan Dash";
            char firstCharacter = 'A';

            // boolean => true or false
            bool isAlive = true;

            // Array => collection of data - [1, 5 , 8, 9, 10]
            string name = "Aurgha";
            string[] names = new string[3]; // [_ , _ , _ ]
            names[0] = "Aurgha";
            names[1] = "Aurpan";
            names[2] = "Dash";
            // names[3] = "Dash"; // this will cause an IndexOutOfRangeException


            int inputNumber = 11;
            // if-else statement
            int remainder = inputNumber % 2;

            if (remainder == 0)
            {
                int xp = 5;
                if (1 == 1)
                {
                    Console.WriteLine("Shotto!");
                }
                else
                {
                    Console.WriteLine("Boro!");
                }
                Console.WriteLine("The number is even.");
            }
            else if (remainder > 1)
            {
                Console.WriteLine("The number is greater than 1 and odd.");
            }
            else
            {
                int xp = 5;
                Console.WriteLine("The number is odd.");
            }


            // Loops => for, while, foreach, do-while
            //int[] numbers = new int[5];
            //numbers[0] = 1;
            //numbers[2] = 2;
            int[] numbers = { 1, 2, 3, 4, 5 };
            //int sum = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];
            
            // while loop
            int sum = 0;
            int index = 0;

            while (index < numbers.Count()) // condition check
            {
                sum = sum + numbers[index];
                index = index + 1; // increment
                //index++; // increment
            }

            // using for loop
            sum = 0; // reset sum
            for (int index1 = 0; index1 < numbers.Count(); index1++)
            {
                sum = sum + numbers[index1];
            }

            // using foreach loop
            sum = 0; // reset sum
            foreach (int number in numbers) 
            {
                sum = sum + number;
            }

            string input = Console.ReadLine();
            Console.WriteLine(input);
        }
    }
}
