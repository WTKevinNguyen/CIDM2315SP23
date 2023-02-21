namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("H5 Q1 Answer");

        Console.WriteLine("Input Two Numbers:");
        int integer1 = getInteger();
        int integer2 = getInteger();
        Console.WriteLine($"a = {integer1} + ; b = + {integer2}");

        int big = Large(integer1, integer2);
        Console.WriteLine("The largest number is: " + big);

        Console.WriteLine("H5 Q2 Answer"); 

        Console.WriteLine("Input Four Numbers");
        int integer3 = getInteger();
        int integer4 = getInteger();
        int integer5 = getInteger();
        int integer6 = getInteger();
        Console.WriteLine($"a = {integer3}; b = {integer4}; c = {integer5}; d = {integer6} ");
        
        int max1 = Large(integer3, integer4);
        int max2 = Large(integer5, integer6);
        int bigger = Large(max1, max2);
        Console.WriteLine("The largest number is: " + bigger);

        Console.WriteLine("H5 Q3 Answer");
        createAccount();

    }
    
    static int getInteger(){
        string str_input = Console.ReadLine();
        int int_input = Convert.ToInt16(str_input);
        return int_input;
    }
    static int Large(int a, int b) {
        if (a > b) {
            return a;
        } else {
            return b;
        } 
    }    

    static bool checkAge(int birth_year){
        int age = 2022 - birth_year;
        if (age >= 18) {
            return true;
        } else {
            return false;
        }
    }

    static void createAccount(){
        Console.WriteLine("Enter Your Username:");
        string username = Console.ReadLine();
        
        Console.WriteLine("Enter Your Password:");
        string password1 = Console.ReadLine();
        
        Console.WriteLine("Enter Your Password Again:");
        string password2 = Console.ReadLine();
        
        Console.WriteLine("Enter Your Birth Year:");
        int birth_year = Convert.ToInt32(Console.ReadLine());
        
        if (checkAge(birth_year)) {
            if (password1 == password2) {
                Console.WriteLine("Account is created successfully");
            } else {
                Console.WriteLine("Wrong password");
            }
        } else {
            Console.WriteLine("Could not create an account");
        }
    }
}

    
