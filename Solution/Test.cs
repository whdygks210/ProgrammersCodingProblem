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
            TruckPassingBridge truckPassingBridge = new TruckPassingBridge();

            int bridge_length = 2;
            int weight = 10;
            int[] truck_weights = new int[] { 7, 4, 5, 6 };

            Console.WriteLine(truckPassingBridge.solution(bridge_length, weight, truck_weights));
        }
    }
}
