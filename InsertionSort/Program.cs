namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 14, 8, 10, 9, 12, 19, 16, 6 };
            List<int> sorted = InsertionSort(numbers);

            Console.WriteLine(string.Join(" ", sorted));
        }

        static List<int> InsertionSort(List<int> nums)
        {
            for (int i = 1; i < nums.Count; i++)
            {
                int key = nums[i];
                int j = i - 1;

                while (j >= 0 && nums[j] > key)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }
                nums[j + 1] = key;
            }

            return nums;
        }
    }
}
