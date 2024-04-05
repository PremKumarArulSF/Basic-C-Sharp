using System;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Name: ");
        string str=Console.ReadLine();
        Console.Write("Enter the Short name: ");
        string shortstr=Console.ReadLine();
        string[] final=str.Split(shortstr);
        // foreach(string i in final){
        //     Console.WriteLine(i);
        // }
        foreach(string i in final){
            Console.Write(i+" ");
        }
        Console.WriteLine(final.Length-1);
    }
}
