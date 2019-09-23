using System;
namespace Fibonacci
{
    class Prac4_3
    {
        public static double F(int a, int b, int counter, int n)
        {   
            Console.Write(a+"\t");
            if (counter<n)
                F(b, a+b, counter+1, n);
            return 0;    
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("how many nos. of fibonacci series you want to print?\t");
            n=int.Parse(Console.ReadLine());
            F(0, 1, 1, n);
            Console.ReadKey();
        }
    }
}