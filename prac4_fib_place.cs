using System;
namespace Prac4
{
    class prac4_fib_place
    {
        public static int F(int n)
        {   
            if (n<=1)
                return n;
            else
                return F(n-1)+F(n-2);
        }
        public static void Main(string[] args)
        {
            Console.Write("number of which position of fibonacci series you want to print?\t");
            int n=int.Parse(Console.ReadLine());
            Console.Write("no. at " + n + "th postion is " + F(n) + "\t");
            Console.ReadKey();
        }
    }
}