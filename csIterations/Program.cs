using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csIterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 10; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for each basics:

            var name = "John Wick";

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.WriteLine("Using foreach:");
            foreach(var character in name)
            {
                Console.WriteLine(character);
            }

            // displaying number:

            var numbers = new int[] { 1, 2, 3, 4 };
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            //continious input from user:

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                Console.WriteLine("@Echo: "+input);
            }
        }

    }
}
