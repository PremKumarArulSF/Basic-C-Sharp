using System;
class Program{
    public static void Main(string[] args)
    {
        int i=0;
        while(i<=25)
        {
            if(i%2==0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
        Console.Write("Enter the number");
        int a;
        bool Check=int.TryParse(Console.ReadLine(),out a);
        while(true)
        {
            if(Check)
            {
               Console.Write(a);
               break;
            }
            else{
               Console.WriteLine("Invalid number"); 
               Console.WriteLine("Enter the number");
               Check=int.TryParse(Console.ReadLine(),out a);
            }
        }
    }
}
