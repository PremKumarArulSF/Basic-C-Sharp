using System;
using System.Data;
class Program{
    public static void Main(string[] args)
    {
        // string s="hello world";
        // string str="world";
        // int n=s.IndexOf(str);
        // string newstr=s.Insert(n,"Prem");
        // int n2=newstr.IndexOf(str);
        // Console.WriteLine(n2);
        // string newstr1=newstr.Insert(n2," ");
        // Console.Write(newstr1);
        // DateTime userdate =DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy",null);
        // Console.Write(userdate.DayOfWeek);
    //     
    // int n=int.Parse(Console.ReadLine());
    // int da=(n*10)/100;
    // int hra=(n*10)/100;
    // int final=n+da+hra;
    // //int tax=(final*5)/100;
    // int annual=final*12;
    // Console.WriteLine("the annual {0}",annual);
    // int tax=(annual*5)/100;
    // Console.WriteLine(annual-tax);
    //Console.WriteLine(annual);
    
    //Console.WriteLine(da);
    //Math.Round
    // double n1=12.333;
    // Console.Write(Math.Round(n1,2));
                // int n=int.Parse(Console.ReadLine());
                // if(n<=10000)
                // {
                //     int hra=(n*20)/100;
                //     int da=(n*80)/100;
                //     int final=n+hra+da;
                //     int annual=final*12;
                //     int tax=(annual*6)/100;
                //     int lic=(annual*1)/100;
                //     int sum=annual-tax-lic;
                //     Console.WriteLine("Annual Gross Salary: {0}",annual);
                //     Console.WriteLine("Annual Take-Home Salary: {0}",sum);
                // }
                // else if(n<=2000)
                // {
                //     int hra=(n*20)/100;
                //     int da=(n*80)/100;
                //     int final=n+hra+da;
                //     int annual=final*12;
                //     int tax=(annual*6)/100;
                //     int lic=(annual*1)/100;
                //     int sum=annual-tax-lic;
                //     Console.WriteLine("Annual Gross Salary: {0}"annual);
                //     Console.WriteLine("Annual Take-Home Salary: {0}",sum);
                // }
                // else if(n>20000)
                // {
                //     int hra=(n*30)/100;
                //     int da=(n*95)/100;
                //     int final=n+hra+da;
                //     int annual=final*12;
                //     int tax=(annual*6)/100;
                //     int lic=(annual*1)/100;
                //     int sum=annual-tax-lic;
                //     Console.WriteLine("Annual Gross Salary: {0}"annual);
                //     Console.WriteLine("Annual Take-Home Salary: {0}",sum);
                // }
                

        public class Program
        {
            public static void Main(string[] args)
            {
                //Console.WriteLine("Hello World");
                // Write your logic here
                int n=int.Parse(Console.ReadLine());
                 for(int i=1;i<=n;i++)
                {
                    int sum=1,count=0,a=i,final=0;
                    while(a!=0)
                        {
                          count++;
                          a/=10;
                        }
                    int b=i;
                    while(b!=0)
                    {
                        int rem=b%10;
                        for(int j=0;j<count;j++)
                        {
                            sum=sum*rem;
                        }
                        final=final+sum;
                        sum=1;
                        b/=10;
                    }
                    if(final==i)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        //    DateTime userdate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        //    int n=int.Parse(Console.ReadLine());
        //     DateTime[] date=new DateTime[n];
        //      for(int i=0;i<n;i++)
        //    {
        //      date[i]=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        //     } 
        //    string s=userdate.DayOfWeek.ToString();
        //    if(s=="Sunday" || s=="Saturday")
        //    {
        //     Console.Write("Holiday");
        //    }
        //    Console.WriteLine(userdate.DayOfWeek);
        //    Console.WriteLine(date[0].ToString("dd/MM/yyyy")==userdate.ToString("dd/MM/yyyy"));
        //    int flag=1;
        //     for(int i=0;i<n;i++)
        //     {
        //         if(date[i].ToString("dd/MM/yyyy")==userdate.ToString("dd/MM/yyyy")
        //         {
        //             flag=0;
        //             break;
        //         }
        //     }
        //     if(flag==0)
        //     {
        //         Console.Write("Holiday:-)");
        //     }
        //     else{
        //        Console.Write("Not an Holiday:-(");
        //     }
            
           
    }
}