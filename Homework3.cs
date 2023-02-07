namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("H3 Q1 Answer");

        Console.WriteLine("Input an integer:");
        string user_int = Console.ReadLine();
        int n1 = Convert.ToInt16(user_int);
        bool isPrime = true;
        // Check if less than or equal to 1
        if (n1 <= 1){
            isPrime = false;
        } else{
            // Looping through all the numbers from 2 to N
            for (int i = 2; i < n1; i++){ 
                // Checking if N is divisible by any of the numbers from 2 to N
                if (n1 % i == 0){
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime){
            Console.WriteLine("N is prime");
        } else{
            Console.WriteLine("N is non-prime");
        }

        Console.WriteLine("H3 Q2 Answer");

        Console.WriteLine("Assign an int value to N:");
        string user_ans2 = Console.ReadLine();
        int n2 = Convert.ToInt16(user_ans2);
        // Loops for the rows
        for (int i = 0; i < n2; i++) {
            // Loops through the columns
            for (int j = 0; j < n2; j++) {
                // Prints the "#"
                Console.Write("#");
            }
            // Moves to the next line after a row
            Console.WriteLine();
        }

        Console.WriteLine("H3 Q3 Answer");

        Console.WriteLine("Assign an int value to N:");
        string user_ans3 = Console.ReadLine();
        int n3 = Convert.ToInt16(user_ans3);
        // Loops for the rows
        for (int i = 0; i < n3; i++){
            // Loops through the columns but the "<= i" makes it so it prints in a triangle pattern
            for (int j = 0; j <= i; j++) {
                // Prints the asterisks
                Console.Write("*");
            }
            // Moves to the next line after a row
            Console.WriteLine();
        }

        Console.WriteLine("H3 Bonus Answer");

        Console.WriteLine("Assign an int value to N");
        string user_ans4 = Console.ReadLine();
        int n4 = Convert.ToInt16(user_ans4);
        // Loop through the rows
        for (int i = 1; i <= n4; i++){
            // Loop to calculate the spaces infront of the number
            for (int j = n4 - i; j > 0; j--){
                Console.Write(" ");
            }
            // Loop to print the numbers 
            for (int j = 1; j <= i; j++){
                Console.Write(i);
            }
            Console.WriteLine();

            }
    }
}
