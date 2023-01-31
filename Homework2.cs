namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("H2 Q1 Answer");

        Console.WriteLine("Please input a point grade: ");
        string point = Console.ReadLine();
        if(point == "A"){
            Console.WriteLine("GPA Point: 4");
        }
        else if (point == "B"){
            Console.WriteLine("GPA Point: 3");
        }
        else if (point == "C"){
            Console.WriteLine("GPA Point: 2");
        }
        else if (point == "D"){
            Console.WriteLine("GPA Point: 1");
        }
        else if (point == "F"){
            Console.WriteLine("GPA Point: 0");
        }
        else{
            Console.WriteLine("Wrong Letter Grade! ");
        }

        Console.WriteLine("H2 Q2 Answer");
        
        Console.WriteLine("Please input the first num: ");
        string user_ans = Console.ReadLine();
        int n1 = Convert.ToInt16(user_ans);
        Console.WriteLine("Please input the second num: ");
        string user_ans2 = Console.ReadLine();
        int n2 = Convert.ToInt16(user_ans2);
        Console.WriteLine("Please input the third num: ");
        string user_ans3 = Console.ReadLine();
        int n3 = Convert.ToInt16(user_ans3);
        if (n1<n2){
            if (n1<n3){
                Console.WriteLine($"The smallest value: {n1}");
            }
            else{
                Console.WriteLine($"The smallest value: {n3}");
            }
        }
        else{
            if(n2<n3){
                Console.WriteLine($"The smallest value: {n2}");
            }
            else{
                Console.WriteLine($"The smallest value: {n3}");
            }
        }

        Console.WriteLine("H2 Bonus Answer");

        Console.WriteLine("Please input a year: ");
        string user_ans4 = Console.ReadLine();
        int year = Convert.ToInt16(user_ans4);
        if ((year%400)==0){
            Console.WriteLine($"{year} is a Leap Year");
        }
        else if((year%100)==0){
            Console.WriteLine($"{year} is not a Leap Year");
        }
        else if ((year%4)==0){
            Console.WriteLine($"{year} is a Leap Year");
        }
        else{
            Console.WriteLine($"{year} is not a Leap Year");
        }

    }
}
