using System;
namespace Reverse
{
    class Prac5
    {
        static void Main(string[] args)
        {
            int n, count=0;
            Console.WriteLine("Enter the number");
            n=int.Parse(Console.ReadLine());
            while(n!=0)
            {
                n/=10;                                // n = n/10
                ++count;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }   
        /* static void Reverse()
        {
            Console.WriteLine("Enter the number");
        }
        static void Table()
        {
            Console.WriteLine("Enter the number");
        }
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("Select the operation you want to perform:-\n 1 Sum of digits of a number\n 2 Reverse a number\n 3 Multiplication table of a number\n 4 Exit");
                Console.ReadKey();

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
                }
            }while(x>0 && x<4);
        } */
    }
}