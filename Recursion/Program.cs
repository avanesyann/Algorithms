namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Countdown(10);
            //Console.WriteLine(Factorial(5));

            //Console.WriteLine(Staircase(5));

            Console.WriteLine(ArraySum(new int[] { 12, 24, 36 }, 0));
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
