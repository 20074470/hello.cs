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
    }

        



}