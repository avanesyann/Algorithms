namespace Quicksort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 14, 24, 10, 9, 21, 19, 8, 18 };
            int[] sortedArray = Quicksort(testArray);

            foreach (int i in sortedArray)
            {
                Console.Write(i + " ");
            }
        }

        static int[] Quicksort(int[] array)
        {
            if (array.Length < 2) return array;
            if (array.Length == 2)
                return array[0] > array[1] ? new int[] { array[1], array[0] } : new int[] { array[0], array[1] };

            int pivot = array[0];
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < pivot)
                    left.Add(array[i]);
                else right.Add(array[i]);
            }

            int[] sortedLeft = Quicksort(left.ToArray());
            int[] sortedRight = Quicksort(right.ToArray());

            return sortedLeft.Concat(new int[] { pivot }).Concat(sortedRight).ToArray();
        }
    }
}
