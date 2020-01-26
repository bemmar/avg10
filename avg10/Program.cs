using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avg10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfValues = 2;

            var array = new string[numberOfValues];
            // 0, 1, -> 9

            //for loop
            //1. initialize looping variable
            //2. condition to continue looping
            //3. code to run at end of each iteration
            for(int i = 0; i < numberOfValues; i++) //i = i + 1
            {
                string input = Console.ReadLine();
                array[i] = input;
            }

            // sum = total / number of entries

            int total = 0;

            for (int i = 0; i < array.Length; i++)
            {
                total = total + Convert.ToInt32(array[i]);
            }

            int sum = total / array.Length;

            Console.WriteLine();
            Console.WriteLine(sum);

            if (sum >= 90)
            {
                Console.WriteLine("A");
            }
            else if (sum >= 80)
            {
                Console.WriteLine("B");
            }
            else if (sum >= 70)
            {
                Console.WriteLine("C");
            }
            else if (sum >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }

            Console.ReadLine();
        }
    }
}
