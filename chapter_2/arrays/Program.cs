using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names;
            
            names = new string[4];

            names[0] = "Kate";
            names[1] = "Barry";
            names[2] = "Steve";
            names[3] = "Skye";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
