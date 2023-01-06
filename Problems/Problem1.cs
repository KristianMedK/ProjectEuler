using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{

    //Sum of FizzBuzz numbers
    public static class Problem1
    {
        public static void Solve()
        {
            var max = 1000;
            var sum = 0;
            for(int i =0; i< max; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Problem 1 answer: {sum}");
        }
    }
}
