using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;
            object name = "Amir";

            Console.WriteLine($"{name} is {height} metres tall.");

            // int length1 = name.Length; // compile error
            int length2 = ((string)name).Length;

            Console.WriteLine($"{name} has {length2} characters.");

            // storing a string in a dynamic object
            dynamic anotherName = "Ahmed";

            // compiles but would throw an error if no Length property
            int length = anotherName.Length;

            Console.WriteLine($"{anotherName} has { length} characters.");

            // int population = 66_000_000;
            // double weight = 1.88;
            // decimal price = 4.99M;
            // string fruit = "Apples";
            // char letter = 'Z';
            // bool happy = true;

            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) is {default(bool)}");
            Console.WriteLine($"default(DateTime) is {default(DateTime)}");
            Console.WriteLine($"default(string) is {default(string)}");

            

        }
    }
}
