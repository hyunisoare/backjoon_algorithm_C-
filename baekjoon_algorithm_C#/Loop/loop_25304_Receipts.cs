namespace baekjoon_algorithm_C_.Loop
{
    internal class loop_25304_Receipts
    {
        public static void Solution(string[] args)
        {
            int total = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int price = 0;

            // loop like N times
            for (int i = 0; i<N; i++)
            {
                //string[] parts = Console.ReadLine().Split(" ");
                int[] parts = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                price += parts[0] * parts[1];
            }

            if (total == price) Console.WriteLine("Yes");
            else Console.WriteLine("No");
            
        }
        

    }
}


//입력
//첫째 줄에는 영수증에 적힌 총 금액 
//X가 주어진다.

//둘째 줄에는 영수증에 적힌 구매한 물건의 종류의 수 
//N이 주어진다.

//이후 
//N개의 줄에는 각 물건의 가격 
//a와 개수 b가 공백을 사이에 두고 주어진다.

//출력
//구매한 물건의 가격과 개수로 계산한 총 금액이 영수증에 적힌 총 금액과 일치하면 Yes를 출력한다. 일치하지 않는다면 No를 출력한다.

// 입력 
//260000
//4
//20000 5
//30000 2
//10000 6
//5000 8

// 출력
// Yes