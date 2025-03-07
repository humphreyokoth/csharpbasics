using System;


namespace verbatim
{

    class Program
    {

        static void Main(string[] args)
        {

            string name =  "John";
            int age = 24;

            string path  = "C:\\Users\\John\\Documents\\Project";
            Console.WriteLine(path);
            // Console.WriteLine("");
            string hello = @"Hello
                World
                My
                Name
                Is
                John
                Cena" +
           "\n";
            Console.WriteLine(hello);
            string test = string.Concat($"you name is {name} and you are {age} years old");

            Console.WriteLine(test);

        }



    }

}

