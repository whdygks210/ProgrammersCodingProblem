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
            TriangleSnail problem = new TriangleSnail();

            foreach (int i in problem.solution(4))
                Console.Write(i.ToString() + " ");
            
            Console.WriteLine();
        }
    }
}
