namespace Homework6;
class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.name = "Alice";
        p1.subject = "Java";
        p1.SetSalary(9000);
        Console.WriteLine(p1.PrintInfo());

        Professor p2 = new Professor();
        p2.name = "Bob";
        p2.subject = "Math";
        p2.SetSalary(8000);
        Console.WriteLine(p2.PrintInfo());

        Student s1 = new Student();
        s1.name = "Lisa";
        s1.subject = "Java";
        s1.SetGrade(90);
        Console.WriteLine(s1.PrintInfo());

        Student s2 = new Student();
        s2.name = "Tom";
        s2.subject = "Math";
        s2.SetGrade(80);
        Console.WriteLine(s2.PrintInfo());
    }   
}

class Professor
{
    public string name;
    public string subject;
    private double salary;
    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }
    public double GetSalary()
    {
        return salary;
    }
    public string PrintInfo(){
        return $"Professor {name} teaches {subject}, and the salary is; {salary}";
    }
}

class Student
{
    public string name;
    public string subject;
    private double grade;
    
    public void SetGrade(double grade_amount)
    {
        grade = grade_amount;
    }
    public double GetGrade()
    {
        return grade;
    }

    public string PrintInfo(){
        return $"Student {name} enrolls {subject}, and the grade is; {grade}";
    }
}
