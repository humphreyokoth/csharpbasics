using System;

namespace  fizzbuz
{

    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                if(i > 0 && i % 3 == 0 && i % 5 ==0){
                    Console.WriteLine("FizzBuzz");
                }else if(i > 0 && i % 3 == 0){
                    Console.WriteLine("Fizz");
                }else if(i > 0 && i % 5 == 0){
                    Console.WriteLine("Buzz");
                }else{
                    Console.WriteLine(i);
                }
            }
        }
    }
}