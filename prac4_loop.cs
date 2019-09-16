using System;
namespace fibonacci               // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144
{
    class prac4
    {
        static void Main(string[] args)
        {
            int a=0,b=1,n,i,c;
            Console.Write("how many nos. of fibonacci series you want to print?\t");
            n=int.Parse(Console.ReadLine());
            Console.Write(a+"\t"+b+"\t");
            for(i=1;i<=n;++i)
            {
                c=a+b;
                Console.Write(c+"\t");
                a=b;
                b=c;
                
                /*c=a+b;
                b=b+c;
                a=a+b
                Console.Write(a+"\t");
                b=b+a;
                Console.Write(b+"\t");*/
            }
            Console.ReadKey();
        }
    }
}