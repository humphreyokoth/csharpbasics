using System;

namespace whileLoop
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
                while (i < times)
                {
                    Console.WriteLine("Hello");
                    i++;
                }
            }
        }
    }
}