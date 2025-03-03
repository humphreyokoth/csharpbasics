using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int age = 25;
            //bool value = true;


            //double negative = -1.0D;

            //Console.WriteLine(age);
            //Console.WriteLine(negative);
            //Console.ReadLine();

            //const int vat = 20;
            //const double percentVAT = vat / 100D;

            //int balance = 1000;
            //string number = "0705188046";
            //int age = 25;
            int num1 = 10;
            int num2 = 2;

            int reminder = num1 % num2;
            //Console.WriteLine("Hello my name is Humphrey");
            Console.WriteLine("Enter your name: ");


            string name = Console.ReadLine();
            Console.Write(name);
            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine(); 
            
         


            Console.WriteLine("Your name is:"+ name  +"and your age is "+ age);
            Console.ReadLine();

        }
    }
}