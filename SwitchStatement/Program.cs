using System;
namespace SwitchStatement;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the operator: ");
        char symbol=char.Parse(Console.ReadLine());
        Console.Write("Enter the value1: ");
        double value1=double.Parse(Console.ReadLine());
        Console.Write("Enter the value2: ");
        double value2=double.Parse(Console.ReadLine());
        switch(symbol){
            case '+':
            {
                Console.WriteLine(value1+value2);
                break;
            } 
            case '-':
            {
                Console.WriteLine(value1-value2);
                break;
            } 
            case '*':
            {
                Console.WriteLine(value1*value2);
                break;
            } 
            case '/':
            {
                Console.WriteLine(value1/value2);
                break;
            } 
            case '%':
            {
                Console.WriteLine(value1%value2);
                break;
            } 
            default:
            {
                Console.WriteLine("Invalid");
                break;
            }
        }
    }
}
