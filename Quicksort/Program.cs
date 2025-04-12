namespace Quicksort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 14, 24, 10, 9, 21, 19, 8, 18 };
            int[] testArray2 = new int[] { 14, 24, 10 };
            int[] sortedArray = Quicksort(testArray);
            int[] sortedArray2 = Quicksort(testArray2);

            Console.WriteLine(string.Join(" ", sortedArray));
            Console.WriteLine(string.Join(" ", sortedArray2));
        }

        static int[] Quicksort(int[] array)
        {
            if (array.Length < 2) return array;
            if (array.Length == 2)
                return array[0] > array[1] ? new int[] { array[1], array[0] } : new int[] { array[0], array[1] };

            Random rand = new Random();
            int pivotIndex = rand.Next(array.Length);
            int pivot = array[pivotIndex];

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (i == pivotIndex) continue;

                if (array[i] < pivot)
                    left.Add(array[i]);
                else right.Add(array[i]);
            }

            List<int> sorted = new List<int>();
            sorted.AddRange(Quicksort(left.ToArray()));
            sorted.Add(pivot);
            sorted.AddRange(Quicksort(right.ToArray()));

            return sorted.ToArray();
        }
    }
}
