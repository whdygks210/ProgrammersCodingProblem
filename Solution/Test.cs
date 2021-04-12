using Solution.Level2;
using Solution.Level3;
using System;

namespace Solution
{
    public class Test
    {
        public static void Main(string[] args)
        {
            BaseStationInstallation problem = new BaseStationInstallation();

            Console.WriteLine(problem.solution(16, new int[] { 9 }, 2));
        }
    }
}
