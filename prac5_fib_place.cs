using System;
namespace Fibonacci
{
    class Prac5_fib_place
    {
        static int F(int n)
        {   
            if (n<=1)
                return n;
            else
                return F(n-1)+F(n-2);
        }
        static void Main(string[] args)
        {
            Console.Write("number of which position of fibonacci series you want to print?\t");
            int n=int.Parse(Console.ReadLine());
            Console.Write("no. at " + n + "th postion is " + F(n-1) + "\t");
            Console.ReadKey();
        }
    }
}