using System;

namespace doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times do i want to say hello? ");
            int times = Convert.ToInt32(Console.ReadLine());

            if (times <= 0)
            {
                Console.WriteLine("You must enter a number greater than 0");
            }
            else
            {
                int i = 0;
                do
                {
                    Console.WriteLine("Hello");
                    i++;
                } while (i < times);
            }

            Console.WriteLine("Enter a number: ");
            string numberAInput = Console.ReadLine();
            int numberA=  Convert.ToInt32(numberAInput);
            Console.WriteLine("Enter another number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB ;
            int actualAnswer = 0;
            Console.WriteLine("What is the value of "+ numberA +" * "+ numberB +"?");
            Console.WriteLine();

            do
            {
                Console.Write("Enter your answer: ");
                string actualAnswerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(actualAnswerInput);
                if (actualAnswer != answer)
                {
                    Console.WriteLine("Not correct try again");
                }
                Console.WriteLine("Well done ");
            } while (answer != actualAnswer);
        }
    }
}