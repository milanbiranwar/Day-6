using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6PracticeProb
{
    internal class FibonacciSeries
    {
		public static void fibonacciseries()
		{
			//To start the series with 0 and 1
			int a = 0, b = 1;
			int c;
			Console.WriteLine("The Value of a & b are: " + a + " & " + b);

			for (int i = 1; i <= 10; i++)
			{
				c = a + b;
				Console.Write(" " + c);
				a = b;
				b = c;

			}
    }	}
}
