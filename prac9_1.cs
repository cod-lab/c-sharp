using System;
namespace Constructors
{
    class Prac9_1
    {
        int a;

        public
        Prac9_1()                                       //Default constructor      0args,1object
        {
            Console.WriteLine("1. This is Default constructor called\n");
        }
        Prac9_1(string s)                               //Pramaterized constructor      1arg,2objects
        {
            Console.WriteLine(s);
            Console.Write("\tEnter value of a\t");
            a=int.Parse(Console.ReadLine());
        }
        Prac9_1(string s,Prac9_1 obj1,Prac9_1 obj2)              //Copy constructor      3args,1object
        {
            Console.WriteLine("\n"+s);
            if(obj1.a>obj2.a)
                Console.WriteLine("\tobj1 has greater a: " + obj1.a + "\n");
            else if(obj2.a>obj1.a)
                Console.WriteLine("\tobj2 has greater a: " + obj2.a + "\n");
            else
                Console.WriteLine("\tboth are equal\n");
        }
        void func(string s,int x,int y)
        {
            Console.Write(s + "\n\tenter an integer\t");
            x=int.Parse(Console.ReadLine());
            Console.Write("\tenter an integer\t");
            y=int.Parse(Console.ReadLine());
            Console.WriteLine("\tsum of x & y is: " + (x+y) + "\n");
        }
       void func(string p,string q)
        {
            Console.Write("\tenter a string\t");
            p=Console.ReadLine();
            Console.Write("\tenter a string\t");
            q=Console.ReadLine();
            Console.WriteLine("\tthe string is: " + p + q);
        }
        static void Main(string[] args)
        {
            int x=0,y=0;
            string p="",q="";
            Prac9_1 obj0=new Prac9_1();
            Prac9_1 obj1=new Prac9_1("2. This is Parameterized constructor called");
            Prac9_1 obj2=new Prac9_1("\t----------------");
            Prac9_1 obj3=new Prac9_1("3. This is Copy constructor called",obj1,obj2);
            obj0.func("This is function overloading",x,y);
            obj0.func(p,q);
            Console.ReadKey();
        }
    }
}