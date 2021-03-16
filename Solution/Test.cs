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
            MakingBigNumber problem = new MakingBigNumber();

            Console.WriteLine(problem.solution("4177252841", 4));
        }
    }
}
