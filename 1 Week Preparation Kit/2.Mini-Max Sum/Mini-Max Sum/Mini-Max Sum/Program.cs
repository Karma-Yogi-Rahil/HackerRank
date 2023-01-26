namespace Mini_Max_Sum
{
    public class Program
    {
        public static void Main()
        {

            // [1+2+3+4+5] = 15 

            List<int> arr =new List<int>();
                
            arr.Add(396285104);
            arr.Add(573261094);
            arr.Add(759641832);
            arr.Add(819230764);
            arr.Add(364801279);

            MiniMaxSum(arr);
        }

        /// <summary>
        /// Finding the max min sum of the given list.
        /// </summary>
        /// <param name="arr">List of numbers.</param>
        public static void MiniMaxSum(List<int> arr)
        {
            long totalSum = 0;
            int maxNumber=arr[0];
            int minNumber=arr[0];

            // Calulated total sum of list and finding max and min value.
            foreach(int number in arr)
            {
                totalSum += number;

                if (maxNumber < number)
                {
                    maxNumber = number;
                }

                if (minNumber > number)
                {
                    minNumber = number;
                }
            }

            string maxMinSum = string.Format("{1} {0}",totalSum-minNumber,totalSum-maxNumber);

            // Expected answer 2093989309 2548418794
            Console.WriteLine(maxMinSum);
        }
    }
}