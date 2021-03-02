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
            StockPrice problem = new StockPrice();

            int[] prices = new int[] { 1, 2, 3, 2, 3 };

            foreach (int i in problem.solution(prices))
                Console.Write(i.ToString() + " ");
            
            Console.WriteLine();
        }
    }
}
