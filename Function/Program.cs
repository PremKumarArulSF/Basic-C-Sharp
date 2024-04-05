// using System;
// using System.ComponentModel;
// using System.Security.Principal;
// class Program{
//     public static void Main(string[] args)
//     {
//         string valid;
//         do{
//             int a=int.Parse(Console.ReadLine());
//             int b=int.Parse(Console.ReadLine());
//             char symbol=char.Parse(Console.ReadLine());
            
//             switch(symbol)
//             {
//                     case '+':
//                     {
//                         Console.Write(Add(a,b));
//                         break;
//                     }case '-':
//                     {
//                         Console.Write(Sub(a,b));
//                         break;
//                     }
//                     case '*':
//                     {
//                         Console.Write(Mul(a,b));
//                         break;
//                     }
//                     case '/':
//                     {
//                         Console.Write(Div(a,b));
//                         break;
//                     }
//                     default:
//                     {
//                         Console.Write("Invalid");
//                         break;
//                     }
//             }
//             Console.WriteLine();
//             Console.Write("Do you want to continue yes or  no: ");
//             valid =Console.ReadLine();

//         }while(valid=="yes");
//     }

//     static int Add(int x,int y)
//     {
//         return x+y;
//     }
//     static int Sub(int x,int y)
//     {
//         return x-y;
//     }
//     static int Mul(int x,int y)
//     {
//         return x*y;
//     }
//     static int Div(int x,int y)
//     {
//         return x/y;
//     }
// }
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Security;
class Program{
    public static void Main(string[] args)
    {
                // int MonthSal=int.Parse(Console.ReadLine());
                // int Month=int.Parse(Console.ReadLine());
                // int year=int.Parse(Console.ReadLine());
                // int leave=int.Parse(Console.ReadLine());
                // int days=DateTime.DaysInMonth(year,Month);
                // Console.WriteLine("days in month {0}",days);

                // int total=days-leave;
                // Console.WriteLine("leave :{0}",total);
                // int noofdays=(MonthSal)/days;
                // Console.WriteLine("sal per day is {0}",noofdays);
                // // Console.WriteLine(total);
                // // double sal=total*MonthSal;
                //  Console.WriteLine(noofdays*total);
                //  Console.WriteLine(161*28);
                 
                // string s1=Console.ReadLine();
                // string s2=Console.ReadLine();
                 
                // char[] c1=s1.ToCharArray();
                // char[] c2=s2.ToCharArray();
                // Array.Sort(c1);
                // Array.Sort(c2);
                // string str1="";
                // string str2="";
                // for(int i=0;i<s1.Length;i++)
                // {
                //    str1+=c1[i];
                // }
                // for(int i=0;i<s2.Length;i++)
                // {
                //    str2+=c2[i];
                // }
                // if(str1.Equals(str2))
                // {
                //   Console.Write("correct");
                // }
                // else{
                //   Console.Write("not");
                // }

             
              // string s=Console.ReadLine();
              //  //string str="";
              //   char[] c=s.ToCharArray();
              //  for(int i=0;i<s.Length;i++)
              //  {
              //    for(int j=i+1;j<s.Length;j++)
              //    {
              //     if(c[i]!=c[j])
              //     {
              //       str+=c[i];
              //       //i++;
              //     }
              //    }    
              //  }
              //  Console.Write(str);
              
              // HashSet<string> st=new HashSet<string>();
              // st.Add(s);
              // Console.Write(st);
              

                // Console.Write("Take-Home Salary: {0}",sal);
                // DateTime username1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                //  DateTime username2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                //  TimeSpan t=username2 -username1;
                //  string str=username1.Year.ToString();
                //  string str2=username2.Year.ToString();
                // Console.WriteLine(str);
                //  int a=int.Parse(str);
                // int b=int.Parse(str2);
                // Console.WriteLine(a);

                // Console.WriteLine(b);
                // int c=b-a;
                // Console.WriteLine(c);
                 //string [] newstr=str.Split("/")
                 //Console.WriteLine(username1.DayOfWeek);
                 //Console.Write(2045-2010);
                 //Console.Write("hello"+t.TotalMinutes.To);
                 DateTime username1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
                 DateTime username2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mmm:ss",null);
                 TimeSpan t=username2 -username1;
                 string str=username1.Year.ToString();
                 string str2=username2.Year.ToString();
                 int a=int.Parse(str);
                 int b=int.Parse(str2);
                 int c=(b-a);
                 Console.WriteLine("Age : {0}",c);
                 Console.WriteLine("Day : "+username1.DayOfWeek);
                 string days=t.TotalDays.ToString();
                 int days1=Convert.ToInt32(days);
                 Console.WriteLine("Number of days : {0}",days1);
                 Console.WriteLine("Number of hours : "+t.TotalHours);
                 Console.WriteLine("Number of minutes : "+t.TotalMinutes);
                
                                      
      }
}