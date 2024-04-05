using System;
class Program{
    public static void Main(string[] args)
    {
        string valid;
        do{
            Console.Write("Enter the number :");
            int number=int.Parse(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine("Even");
            }
            else{
                Console.WriteLine("Odd");
            }
            Console.WriteLine("Do you repeat the process :Yes or No ");
            valid=Console.ReadLine();
            if(!(valid=="yes" || valid=="no")){
                Console.WriteLine("Invalid input,enter the valid answer :yes /no");
                valid=Console.ReadLine();

            }
        }while(valid=="yes");
    }
}
