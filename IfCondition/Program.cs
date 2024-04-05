using System;
namespace IfCondition;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the mark: ");
        int mark = int.Parse(Console.ReadLine());
        if (mark > -1)
        {
            if (mark > 80 && mark <= 100)
            {
                Console.WriteLine("Grade A");
            }
            else if (mark >= 61 && mark <= 80)
            {
                Console.WriteLine("Grade b");
            }
            else if (mark >= 36 && mark <= 60)
            {
                Console.WriteLine("Grade c");
            }
            else if (mark < 36)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        else
        {
            Console.Write("Invalid");
        }
    }
}
