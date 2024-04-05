using System;
namespace TypeConversion;
class Program{
    public static void Main(string[] args)
    {
        //getting an input
        Console.Write("Enter your name: ");
        string name=Console.ReadLine();
        Console.Write("Enter age: ");
        int age=int.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject1: ");
        double subject1=double.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject2: ");
        double subject2=double.Parse(Console.ReadLine());
        Console.Write("Enter mark of subject3: ");
        double subject3=double.Parse(Console.ReadLine());
        Console.Write("Enter Grade: ");
        char Grade=char.Parse(Console.ReadLine());
        Console.Write("Enter Mobile number: ");
        long MobileNumber=long.Parse(Console.ReadLine());
        Console.Write("Enter Mail id: ");
        string mail=Console.ReadLine();
        double total=subject1+subject1+subject3;
        double avg=(total)/3;
        //printing an input
        Console.WriteLine("Trainee details are:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Subject1: {subject1}");
        Console.WriteLine($"Subject2: {subject2}");
        Console.WriteLine($"Subject3: {subject3}");
        Console.WriteLine($"Grade: {Grade}");
        Console.WriteLine($"MobileNumber: {MobileNumber}");
        Console.WriteLine($"Mail: {mail}");
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {avg}");
    }
}
