using System;

namespace TimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x; i++)
            {
                Console.WriteLine(i + " " + "Abracadabra");
            }

            // we also came up with a solution using while loop
            // setting int orderCounter = 1 & while
            // x > orderCounter using the console.Writeline
            // and adding an orderCounter ++ clause
            // to count up to the X by incrementing OrderCounter


        }
    }
}
