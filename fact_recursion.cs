using System;
namespace Fibonacci
{
    class Prac4_recursion
    {
        public static double F(int n)
        {   
            double x;
            if(n==0)
                return 1;
            else
                x=n*F(n-1);
            return x;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("whose factorial you want to print?\t");
            n=int.Parse(Console.ReadLine());
            double Fact=F(n);
            Console.WriteLine("fact is " + Fact);
            Console.ReadKey();
        }        
    }
}