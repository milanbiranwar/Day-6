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
			//for (int number = 0; number <= 100; number++)
            //{

                
                int number = 7;
                int count = 0;

                for (int i = 0; i < number; i++)
                {
                    
                
                
                if (number % i == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    //Console.WriteLine("number");
                    Console.WriteLine("It is Prime Number");
                }
               else
                {
                    Console.WriteLine("It is Not a Prime Number");
                }
            //}

		}
          }	
    }
}
