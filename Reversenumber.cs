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
			Console.WriteLine("Enter a number to reverse it");
            int num=Convert.ToInt32(Console.ReadLine());
            //int num = 5634;
            int result = 0;
            int rem;

            while (num!=0)
            {
                rem = num % 10;
                result = result*10 + rem;
                num = num/10;

            }
            Console.WriteLine(result);
		

	}
      }
}
