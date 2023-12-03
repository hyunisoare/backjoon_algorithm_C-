using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon_algorithm_C_._1D_Array
{
    public class _10813_changeBall
    {
        public static void Solution(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] arrs = new int[input[0]];

            // 1. putting numbers into each place.
            for (int i = 0; i < input[0]; i++)
            {
                arrs[i] = i+1;
            }

            // change number input[1] times.
            for (int i = 0; i < input[1]; i++)
            {
                int[] newInput = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int A = newInput[0]; 
                int B = newInput[1];

                int tmp = arrs[A - 1];
                arrs[A - 1] = arrs[B-1]; 
                arrs[B - 1] = tmp; 

            }

            for (int i = 0; i < arrs.Length; i++)
            {
                Console.Write(arrs[i] + " ");
            }
        }
    }
}

//Input
//5 4
//1 2
//3 4
//1 4
//2 2

//Output
//3 1 4 2 5