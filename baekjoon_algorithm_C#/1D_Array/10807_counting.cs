using System;
using System.Collections.Generic;
namespace baekjoon_algorithm_C_._1D_Array
{
    public class _10807_counting
    {

       public static void Solution(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int v = int.Parse(Console.ReadLine());
            int cnt = 0;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] == v)
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);

        }

    }
}
