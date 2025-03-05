using System;

namespace fizzbuz
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            // int number = Convert.ToInt32(Console.ReadLine());

            // for (int i = 0; i < 15; i++)
            // {
            //     if(i % 3 == 0 && i % 5 ==0){
            //         Console.WriteLine("FizzBuzz");
            //     }else if( i % 3 == 0){
            //         Console.WriteLine("Fizz");
            //     }else if(i % 5 == 0){
            //         Console.WriteLine("Buzz");
            //     }else{
            //         Console.WriteLine(i);
            //     }
            // }
            bool divThree = false;
            bool divFive = false;
            for (int i = 0; i < 15; i++)
            {
                divThree = i % 3 == 0;
                divFive = i % 5 == 0;
                if (divThree && divFive)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (divThree)
                {
                    Console.WriteLine("Fizz");
                }
                else if (divFive)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}