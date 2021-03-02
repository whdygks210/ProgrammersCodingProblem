using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Level2
{
    //문제 설명
    //정수 n이 매개변수로 주어집니다.다음 그림과 같이 밑변의 길이와 높이가 n인 삼각형에서 
    //맨 위 꼭짓점부터 반시계 방향으로 달팽이 채우기를 진행한 후, 첫 행부터 마지막 행까지 
    //모두 순서대로 합친 새로운 배열을 return 하도록 solution 함수를 완성해주세요.
    //
    //
    //      1
    //    2   9
    //  3  10   8
    //4   5   6   7
    //
    //    n = 4
    //
    //
    //
    //        1
    //      2   12
    //    3   13  11
    //  4   14  15  10
    //5   6   7   8   9
    //
    //      n = 5
    //

    public class TriangleSnail
    {
        public int[] solution(int n)
        {
            int[] array = new int[n * n];
            int totallCount = n * (n + 1) / 2;
            int value = 0, x = 0, y = 0;

            array[0] = ++value;

            while (value < totallCount)
            {
                while (x + 1 < n && array[(n * (x + 1)) + y] == 0)
                    array[(n * (++x)) + y] = ++value;

                while (y + 1 < n && array[(n * x) + y + 1] == 0)
                    array[(n * x) + (++y)] = ++value;

                while (x - 1 >= 0 && y - 1 >= 0 && array[(n * (x - 1)) + y - 1] == 0)
                    array[(n * (--x)) + (--y)] = ++value;
            }

            return array.Where(w => w != 0).ToArray();
        }
    }
}
