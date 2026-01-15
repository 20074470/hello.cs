//Console.WriteLine("Hello World Again!");
using system;

class SumProgram
{
    static in Sum(int a, int b, int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (i% a == 0 || i% b == 0)
            {
                total[] += i;
            }
            return total;
        }
    }


    static void Main()
    {
        int a = 3;
        int b = 5;
        int n = 10;

        int sumTotal = Sum(int a, int b, int n);
        Console.WriteLine("The natural numbers below {0} that are multiples of {1} or {2}, if we add these, the sum of these multiples is {3}.", n, a, b, sumTotal);
    }

        



}