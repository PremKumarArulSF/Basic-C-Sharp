using System;
using System.Threading;
namespace ForLoop;
class Program{
    public static void Main(string[] args)
    {
        int Count=0;
        Console.Write("Enter the start value: ");
        int a=int.Parse(Console.ReadLine());
        Console.Write("Enter the end value: ");
        int b=int.Parse(Console.ReadLine());
        for(int i=a;i<=b;i++)
        {
            int sq=i*i;
            Count+=sq;
        }
        Console.WriteLine(Count);

    }
}
