using System;

namespace ABC
{
    class First
    {
        int i, x;
        string s;

        public 
        First()  //Default Constructor
        {
            Console.WriteLine("constructor is called");
            Console.WriteLine("x is " + x + "\n");
        }
        First(int i, string s)  //Parameterized Constructor
        {
            x = i;
            this.i = i;
            this.s = s;
            Console.WriteLine("i is " + i);
            Console.WriteLine("s is " + s + "\n");
        }
        First(First c3)  //Copy Constructor,    First(First any_name) can also be written
        {
            Console.Write("x is ");
            Console.WriteLine(x=c3.x);
            Console.Write("i is ");
            Console.WriteLine(i=c3.i);
            Console.Write("s is ");
            Console.WriteLine(s = c3.s + "\n");
        }
        static First()  //Static Constructor                           , explicitly defined using static keyword 
        {                                                            //, implicitly(automatically) defined only when class variables are declared static
            Console.WriteLine("static constructor is called");     //, implicitly(automatically) called (not like any other constructor)
            Console.WriteLine("x is x\n");                             //, executed first among all const or func
        }                                                            //, can't parameterized, no overloading
        void Func1(int i, string s)  //member funtion
        {
            Console.WriteLine("i is " + i);
            Console.WriteLine("s is " + s + "\n");
        }
        void Func2()
        {
            Console.WriteLine("x is " + x); 
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("code in main func is executed now :-\n");

            First c1 = new First();  // c1 doesn't already has any variable(no value of x or i like in other objects) so it displays 0 value of x
            First c2 = new First(1,"parameterized constructor");
            First c3 = new First(2,"parameterized constructor");
            First c4 = new First(c3); //Copy Constructor
            First c5 = new First();  // c5 doesn't already has any variable(no value of x or i like in other objects) so it displays 0 value of x

            c1.Func1(10,"false");
            c2.Func1(10,"false");
            c2.Func2();  //copies value of i to x from above created c2 object
            c3.Func2();  //copies value of i to x from above created c3 object

            Console.WriteLine("\n"+ c2.i + " " + c2.s);
            Console.WriteLine("\n" + c3.i + " " + c3.s);
        }
    }
}
