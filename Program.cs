using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextPrimeNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                int nextPrime = FindNextPrime(number);
                Console.WriteLine($"Next prime after {number}: {nextPrime}");
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        public static int FindNextPrime(int number)
        {
            int nextNumber = number + 1;
            while (!IsPrime(nextNumber))
            {
                nextNumber++;
            }
            return nextNumber;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;

            // This is checked so that we can skip middle five numbers in below loop
            if (number % 2 == 0 || number % 3 == 0) return false;

            int i = 5;
            while (i * i <= number)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
                i += 6;
            }
            return true;
        }
    }
}

