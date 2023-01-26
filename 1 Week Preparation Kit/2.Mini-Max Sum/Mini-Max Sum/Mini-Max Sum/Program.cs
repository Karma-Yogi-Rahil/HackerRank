namespace Mini_Max_Sum
{
    public class Program
    {
        public static void Main()
        {

            List<int> arr =new List<int>();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);

            MiniMaxSum(arr);
        }

        public static void MiniMaxSum(List<int> arr)
        {
            int totalSum = 0;
            int maxSum = 0;
            int minSum = 0;

            foreach(int number in arr)
            {
                totalSum += number;
            }

            foreach(int number in arr)
            {
                int temptotal = totalSum - number;
                if (maxSum < temptotal)
                {
                    maxSum = temptotal;
                }

                if (minSum > temptotal)
                {
                    minSum = temptotal;
                }
            }

            Console.WriteLine(minSum + maxSum);

        }

    }
}