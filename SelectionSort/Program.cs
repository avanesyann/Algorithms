using System.Diagnostics.CodeAnalysis;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[] { 15, 82, 25, 42, 19, 91, 54, 31 };

            PrintArray(numbers);
            SelectionSort(numbers);
            PrintArray(numbers);
        }

        static void SelectionSort(double[] numbers)
        {
            double temp;
            int smallest;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                smallest = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[smallest] > numbers[j])
                    {
                        smallest = j;
                    }
                }

                if (smallest != i)
                {
                    temp = numbers[i];
                    numbers[i] = numbers[smallest];
                    numbers[smallest] = temp;
                }
            }
        }
        static void PrintArray(double[] numbers)
        {
            foreach (var num in numbers)
            {
                Console.Write($"{num:F2} ");
            }

            Console.WriteLine();
        }
    }
}
