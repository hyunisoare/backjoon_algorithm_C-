using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon_algorithm_C_._1D_Array
{
    internal class _5597_missingNumber
    {
        public static void Solution(string[] args)
        {
            int[] arr = new int[30];

            for (int i = 0; i < 28; i++)
            {
                int input = int.Parse(Console.ReadLine());
                
                arr[input-1] = input;
            }

            int[] ans = new int[2];
            int ansCnt = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    ans[ansCnt] = i+1;
                    ansCnt++;
                    if (ansCnt >= 2)
                        break;
                }
            }

            Console.WriteLine(ans[0]);
            Console.WriteLine(ans[1]);


        }

        // finding missing number from 1 to 30.
    }
}
