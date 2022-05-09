using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6PracticeProb
{
    internal class Reversenumber
    {
        public static void reversenumber()
        {
			//Program to reverse the number

			Random sc = new Random();
                        int number = sc.Next();
			

			Console.WriteLine("Enter the number: ");
			

			int remainder;
			int reverse = 0;

			while (number != 0)
			{
				remainder = number % 10;
				reverse = reverse * 10 + remainder;
				number = number / 10;

			}
			Console.WriteLine("Reverse of given number is: " + reverse);

			//Program to reverse the characters
			string name = "MILAN";
			int length = name.Length;
			string rev = "";

			for (int i = length - 1; i >= 0; i--)
			{
				rev = rev + name[i];
			}
			Console.WriteLine("Reverse of the given name 'MILAN' is: " + rev);

		}

	}
}
}
