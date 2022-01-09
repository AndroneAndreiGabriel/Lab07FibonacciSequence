using System;
using System.Linq;

namespace Lab07AssignArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = PrintPrimeNumbers();

            PrintArray("Fibonacci sequence is", array);
        }

        static int ReadNumber(string label, int defaultValue)
        {
            Console.Write(label);
            string value = Console.ReadLine();
            if (int.TryParse(value, out int result))
            {
                return result;
            }

            return defaultValue;
        }

        static void PrintArray(string label, double[] array)
        {
            Console.WriteLine();
            string elementList = string.Join(", ", array);
            Console.WriteLine($"{label}: {elementList}");
        }

        static double[] PrintPrimeNumbers()
        {
            int maxOfArray = ReadNumber("Print prime numbers until: ", 0);
            double[] array = new double[maxOfArray+1];
            
            for (int i = 0; i <= maxOfArray; i++)
            {
                if (i < 2)
                {
                    array[i] = i;
                }
                else
                {
                    array[i] = array[i - 1] + array[i - 2];
                }
            }

            return array;
        }
    }
}