using System;
namespace loops
{
    class Prac4
    {
        static void Sumofdigits()
        {
            int sum=0;
            Console.WriteLine("Enter the number");
            int n=int.Parse(Console.ReadLine());
            if(n<=9)
                Console.WriteLine("sum of digits of given number is 1");
            else
            {
                while(n>0)
                {
                    sum+=n%10;
                    n/=10;
                }
                Console.WriteLine("sum of digits of given number is " + sum);
            }
        }
        static void Reverse()
        {
            int rev=0;
            Console.WriteLine("Enter the number");
            int n=int.Parse(Console.ReadLine());
            while(n>0)
            {
                rev=(rev*10)+(n%10);
                //Console.WriteLine("rev is " + rev);
                n/=10;
                //Console.WriteLine("n is " + n); 
            }
            Console.WriteLine("reverse of given number is " + rev);
        }
        static void Table()
        {
            Console.WriteLine("Enter the number");
            int n=int.Parse(Console.ReadLine());
            Console.Write("table of given number is \n");
            for(int i=1;i<=10;i++)
                Console.WriteLine(n + " * " + i + " = " + n*i);
        }
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("Select the operation you want to perform:-\n 1 Sum of digits of a number\n 2 Reverse a number\n 3 Multiplication table of a number\n 4 Exit\n");
                int opt=int.Parse(Console.ReadLine());
                x=opt;
                switch(opt)
                {   
                    case 1:
                        Sumofdigits();
                        break;
                    case 2:
                        Reverse();
                        break;
                    case 3:
                        Table();
                        break;
                }Console.WriteLine();
            }while(x>0 && x<4);
        }
    }
}