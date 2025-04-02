namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 4, 6, 8, 10, 12, 14, 16, 18 };

            Console.WriteLine(BinarySearch(list, 16));
            Console.WriteLine(BinarySearch(list, 8));
            Console.WriteLine(BinarySearch(list, 2));
        }

        static int BinarySearch(int[] list, int target)
        {
            int left = 0;
            int right = list.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (target == list[mid])
                    return mid;
                else if (target > list[mid])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
