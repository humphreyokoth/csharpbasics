using System;


namespace printAnumber
{
    class Program{
        static void Main (string[]args){

            Console.WriteLine("Enter anumber");
            int number = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("{0}*{1}={2}",i, number, i*number);
            }

        }
    }
}