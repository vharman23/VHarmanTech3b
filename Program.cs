using System;
using System.Threading;

namespace VHarmanTech3b
{
    //Victoria Harman, Tech Project #3b, Arrays
    class Program
    {
        
        static void Main(string[] args)
        { 
            Console.WriteLine("Maually populated array");
            try
            {
                //Populate array with values from 1-25
                int[] array_values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14,
                15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                //run foreach loop to iterate through the array
                foreach (int i in array_values)
                {
                    //output each array value followed by a line break
                    Console.Write("Array Value = " + i + "\n");
                }

            }
            catch
            {
                Console.WriteLine("Press any key to exit...");
           
            }       
           


            
        }
    }
}
 