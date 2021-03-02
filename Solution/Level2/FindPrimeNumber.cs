using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Level2
{
    //문제 설명
    //한자리 숫자가 적힌 종이 조각이 흩어져있습니다. 흩어진 종이 조각을 붙여 소수를 몇 개 만들 수 있는지 알아내려 합니다.
    //
    //각 종이 조각에 적힌 숫자가 적힌 문자열 numbers가 주어졌을 때, 종이 조각으로 만들 수 있는 소수가 몇 개인지 return 하도록 solution 함수를 완성해주세요.
    //
    //제한사항
    //numbers는 길이 1 이상 7 이하인 문자열입니다.
    //numbers는 0~9까지 숫자만으로 이루어져 있습니다.
    //"013"은 0, 1, 3 숫자가 적힌 종이 조각이 흩어져있다는 의미입니다.
    //
    //예제 #1
    //[1, 7] 으로는 소수[7, 17, 71] 를 만들 수 있습니다.
    //
    // 예제 #2
    //[0, 1, 1] 으로는 소수[11, 101] 를 만들 수 있습니다.
    //
    //11과 011은 같은 숫자로 취급합니다.

    public class FindPrimeNumber
    {
        public int solution(string numbers)
        {
            var numVar = numbers.OrderByDescending(x => x);
            int max = Convert.ToInt32(String.Concat(numVar)), min = (max % 10 == 1.0) ? 2 : max % 10;

            int count = 0;
            string numString = String.Empty;
            char[] numArray = null;
            for (int i = min; i <= max; i++)
            {
                if (i <= 1) continue;

                numString = i.ToString();
                numArray = numVar.ToArray();

                for (int j = 0; j < numString.Length; j++)
                {
                    int index = Array.IndexOf(numArray, numString[j]);
                    if (index < 0)
                    {
                        numString = String.Empty;
                        break;
                    }
                    else
                    {
                        numArray[index] = 'x';
                    }
                }

                if (String.IsNullOrEmpty(numString) == false)
                {
                    bool isDiv = false;
                    for (int x = 2; x < i; x++)
                    {
                        if (i % x == 0)
                        {
                            isDiv = true;
                            break;
                        }
                    }

                    if (isDiv == false)
                        count++;
                }
            }

            return count;
        }
    }
}
