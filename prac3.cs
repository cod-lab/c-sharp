using System;
namespace ArithmeticOperations
{
    class Prac3
    {
        static void readno(ref int n1,ref int n2)
        {
            n1=int.Parse(Console.ReadLine());
            n2=int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int n1=0,n2=0,x;
            do
            {
                Console.WriteLine("Select the operation you want to perform:-\n 1 Addition (+)\n 2 Subtraciton (-)\n 3 Multiplication (*)\n 4 Division (/)\n 5 Modulus (%)\n 6 Increment (++)\n 7 Decrement (--)\n 8 EXIT\n");
                
                int opt=int.Parse(Console.ReadLine());
                x=opt;
                switch(opt)
                {
                    case 1:
                        Console.WriteLine("Enter two nos. to add");
                        readno(ref n1,ref n2);
                        Console.WriteLine("addition of two nos. is " + (n1 + n2) + "\n");
                        break;
                    case 2:
                        Console.WriteLine("Enter two nos. to subtract");
                        readno(ref n1,ref n2);
                        Console.WriteLine("subtraction of two nos. is " + (n1 - n2) + "\n");
                        break;
                    case 3:
                        Console.WriteLine("Enter two nos. to multiply");
                        readno(ref n1,ref n2);
                        Console.WriteLine("multiplication of two nos. is " + (n1 * n2) + "\n");
                        break;
                    case 4:
                        Console.WriteLine("Enter two nos. to divide");
                        readno(ref n1,ref n2);
                        Console.WriteLine("division of two nos. is " + (n1 / n2) + "\n");
                        break;                                    
                    case 5:
                        Console.WriteLine("Enter two nos. to get modulas");
                        readno(ref n1,ref n2);
                        Console.WriteLine("modulas of two nos. is " + (n1 % n2) + "\n");
                        break;
                    case 6:
                        Console.WriteLine("Enter a no. to increment");
                        n1=int.Parse(Console.ReadLine());
                        Console.WriteLine("after incrementation " + (n1+1) + "\n");
                        break;
                    case 7:
                        Console.WriteLine("Enter two no. to decrement");
                        n1=int.Parse(Console.ReadLine());
                        Console.WriteLine("after decrementation " + (n1-1) + "\n");
                        break;
                    /** default:
                        System.Environment.Exit(0);
                        break; **/
                }
            }while(x>0 && x<8);
            
        }
    }
}