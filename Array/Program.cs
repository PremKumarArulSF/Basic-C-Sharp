using System;
using System.Configuration.Assemblies;
using System.Security.AccessControl;
class Program
{
    public static void Main(string[] args)
    {

        string[] str = new string[5] { "Prem", "Prem", "Vicky", "Tharun", "Suresh" };
        int flag = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(str[i]);
        }
        Console.Write("Enter the name to search:");
        string s = Console.ReadLine();
        for (int i = 0; i < 5; i++)
        {
            if (str[i] == s)
            {
                Console.WriteLine("Preset in array in index {0}", i);
                flag = 1; 
            }
        }
        if (flag == 0)
        {
            Console.WriteLine("Not Present in array");

        }
        flag = 1;
        foreach (string i in str)
        {
            if (i == s)
            {
                flag = 0;
                break;
            }
        }
        if (flag == 0)
        {
            Console.WriteLine("Present in array");
        }
        else
        {
            Console.WriteLine("Not Present in array");
        }


    }
}
