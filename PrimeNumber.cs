using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6PracticeProb
{
    internal class PrimeNumber
    {
        public static void primenumber()
        {
			Random Scan = new Random();

			int temp = 0; //temporary variable to store the data

			Console.WriteLine("Enter any number to check: ");
			int number = Scan.Next();

			for (int i = 2; i <= number - 1; i++)
			{
				if (number % i == 0)
				{
					temp = temp + 1;
				}
				if (temp > 0)
				{
					Console.WriteLine("The Given number is not a Prime Number: " + number);
				}
				else
				{
					Console.WriteLine("The Given number is a Prime Number: " + number);
				}
			}

		}
	}
}
