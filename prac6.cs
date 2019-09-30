using System;
namespace Factorial
{
    class Prac6
    {
        static void F()
        {
            int fact=1;
            Console.WriteLine("enter a number");
            int n=int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
                fact=fact*i;
            Console.WriteLine("\nfact of given number is " + fact + "\n");
        }
        static double F_recr(int n)
        {   
            if(n==0)
                return 1;
            else 
                return n*F_recr(n-1);
        }
        static void Main(string[] args)
        {
            int x;
            do{
                Console.WriteLine("Select the process for factorial:-\n 1 Simple\n 2 Recursive\n 3 Exit\n");
                int opt=int.Parse(Console.ReadLine());
                x=opt;
                switch(opt)
                {
                    case 1:
                        F();
                        break;
                    case 2:
                        Console.WriteLine("enter a number");
                        int n=int.Parse(Console.ReadLine());
                        double fact=F_recr(n);
                        Console.WriteLine("\nfact of given number is " + fact + "\n");
                        break;
                }
            }while(x>0 && x<3);
        }
    }
}