using System;
class Program{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2021,8,10,10,40,32);
        // Console.WriteLine("The date is "+date.Year);
        // Console.WriteLine("The Month is "+date.Month);
        // Console.WriteLine("The day is "+date.Day);
        // Console.WriteLine("The hour is "+date.Hour);
        // Console.WriteLine("The Minute is "+date.Minute);
        // Console.WriteLine("The Second is"+date.Second);
        string strDate=date.ToString();
        string []str=strDate.Split('/',' ',':');
        for(int i=str.Length-1;i>=0;i--){
            Console.Write(str[i]+" ");
        }
        Console.WriteLine(strDate);
        // Console.Write("Enter the date : yyyy/MM/dd hh:mm:ss :");
        // DateTime userDate=DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
        // Console.WriteLine("The Year is "+userDate.Year);
        // Console.WriteLine("The Month is "+userDate.Month);
        // Console.WriteLine("The Day is "+userDate.Day);
        //Console.WriteLine(userDate.ToLongDateString());
        DateTime userDate=DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
        userDate.Millisecond;
    }
}
