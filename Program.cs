using System;

namespace hellome
{
    class Program
    {
        public static void Main(string[] args)
        {
         Console.WriteLine("Hello World!");
         {
         int n,i, m=0, flag=0;
         Console.Write("Enter the Number to check prime number:");  
         n = int.Parse(Console.ReadLine());
         m=n/2;
         for(i = 17; i<=m;i++)
         {
            if(n % i == 0)
            {
         Console.Write("Number is not prime.");
         flag = 1;
         break;
            }
         }
         if (flag==0)
         Console.Write("Number is prime"); }
         }
    }}
         
         


    

