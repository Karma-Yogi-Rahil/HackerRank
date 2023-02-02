using System.IO;

namespace LonelyInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>(7) { 1, 2, 3, 4, 3, 2, 1 };
            int result = lonelyinteger(a);

            Console.WriteLine(result);

        }

        public static int lonelyinteger(List<int> a)
        {
            int result = 0;

            // Using XOR operation.
            foreach(int i in a)
            {
                result ^= i;

            }

            return result;
        }
    }
}