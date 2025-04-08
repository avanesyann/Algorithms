namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Countdown(10);
            //Console.WriteLine(Factorial(5));

            //Console.WriteLine(Staircase(5));

            int[] testArray = new int[] { 12, 24, 36 };

            Console.WriteLine(ArraySum(testArray, 0));
            Console.WriteLine(CountItems(testArray));
            Console.WriteLine(MaximumNumber(testArray));
        }


        static int MaximumNumber(int[] array)
        {
            int first = array[0];

            if (array.Length == 0) return 0;
            if (array.Length == 1) return first;
            if (array.Length == 2) return first > array[1] ? first : array[1];

            int[] rest = new int[array.Length - 1];
            Array.Copy(array, 1, rest, 0, rest.Length);

            int maxOfRest = MaximumNumber(rest);

            return first > maxOfRest ? first : maxOfRest;
        }
        static int CountItems(int[] array)
        {
            if (array.Length == 0) return 0;

            int[] rest = new int[array.Length - 1];
            Array.Copy(array, 1, rest, 0, rest.Length);

            return 1 + CountItems(rest);
        }
        static int ArraySum(int[] array, int index)
        {
            if (array.Length == index) return 0;                // base case

            return array[index] + ArraySum(array, index + 1);   // recursive case
        }
        static int Staircase(int n)
        {
            if (n < 0) return 0;        // base case
            if (n == 0) return 1;       // base case

            return Staircase(n - 1) + Staircase(n - 2) + Staircase(n - 3);      // recursive case
        }
        static int Factorial(int n)
        {
            if (n <= 1) return 1;           // base case

            return Factorial(n - 1) * n;    // recursive case
        }
        static void Countdown(int i)
        {
            if (i < 0) return;      // base case
            Console.WriteLine(i);

            Countdown(i - 1);       // recursive case
        }
    }
}
