namespace Homework4;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("H4 Q1 Answer");

        Console.WriteLine("Input First Number:");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Input Second Number:");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("a = " + num1 + "; b = " + num2);

        int big = Large(num1, num2);
        Console.WriteLine("The largest number is: " + big);

        Console.WriteLine("H4 Q2 Answer");

        Console.WriteLine("Input a number: ");
        int N = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Left or Right: ");
        string direction = Console.ReadLine().ToLower();

        Console.WriteLine("N is: " + N + "; shape is " + direction);

        PrintTriangle(N, direction);

    }

    static int Large(int a, int b) {
        if (a > b) {
            return a;
        } else {
            return b;
        }
    }

    static void PrintTriangle(int N, string direction)
    {
        if (direction == "left")
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else if (direction == "right")
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = N - i; j > 0; j--){
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

}
