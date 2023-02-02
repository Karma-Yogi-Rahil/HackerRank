namespace Plus_Minus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>(5) { 1, 1, 0, -1, -1 };
            plusMinus(arr);
        }

        public static void plusMinus(List<int> arr)
        {
            int totalCount = arr.Count;
            float positiveNumber = 0;
            float negativeNumber = 0;
            float zeroCount = 0;

            foreach(int i in arr)
            {
                if(i > 0)
                {
                    positiveNumber++;
                }
                else if(i < 0)
                {
                    negativeNumber++;
                }
                else
                {
                    zeroCount++;
                }
            }

            Console.WriteLine(string.Format("{0:N6}",positiveNumber / totalCount));
            Console.WriteLine(string.Format("{0:N6}", negativeNumber / totalCount));
            Console.WriteLine(string.Format("{0:N6}", zeroCount / totalCount));


        }
    }
}