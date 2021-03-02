using Solution.Level2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class Test
    {
        public static void Main(string[] args)
        {
            LargestNumber problem = new LargestNumber();

            int[] numbers = new int[] { 6, 10, 2 };

            Console.WriteLine(problem.solution(numbers));
        }
    }
}
