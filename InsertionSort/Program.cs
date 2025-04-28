namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = new List<int>() { 14, 8, 10, 9, 12, 19, 16, 6 };
            List<int> numbers2 = new List<int>() { 5, 2, 4, 9, 8, 7, 6, 1 };
            List<int> sorted1 = InsertionSort(numbers1);
            List<int> sorted2 = InsertionSort(numbers2);

            Console.WriteLine(string.Join(" ", sorted1));
            Console.WriteLine(string.Join(" ", sorted2));
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
