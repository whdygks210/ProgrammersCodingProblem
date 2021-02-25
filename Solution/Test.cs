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
            FunctionDevelopment functionDevelopment = new FunctionDevelopment();

            int[] progresses = new int[] { 93, 30, 55 };
            int[] speeds = new int[] { 1, 30, 5 };

            foreach (int i in functionDevelopment.solution(progresses, speeds))
                Console.Write(i.ToString() + " ");
            
            Console.WriteLine();
        }
    }
}
