using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon_algorithm_C_._1D_Array
{
    public class _10810_puttingBall
    {
        public static void Solution(string[] args)
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] arrs = new int[(inputs[0])];

            for (int i = 0; i < inputs[1]; i++)
            {
                int[] newInputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int j = (newInputs[0]-1); j <= (newInputs[1]-1); j++)
                {
                    arrs[j] = newInputs[2];
                }
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
//1 2 3
//3 4 4
//1 4 1
//2 2 2

//Output 
//1 2 1 1 0