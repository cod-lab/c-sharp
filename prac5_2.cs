using System;
namespace Fibonacci               // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144
{
    class Prac5_2
    {
        static void Main(string[] args)
        {
            int a=0,b=1,n,i,c;
            Console.Write("how many nos. of fibonacci series you want to print?\t");
            n=int.Parse(Console.ReadLine());
            for(i=1;i<=n;++i)
            {
                Console.Write(a+"\t");
                c=a+b;
                a=b;
                b=c;
            }
            Console.ReadKey();
        }
    }
}