using System;
namespace typesofmethods
{
    class methods
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");                 //Write
            string name = Console.ReadLine();                   //ReadLine
            Console.WriteLine("Hello " + name);                 //WriteLine
            Console.ReadKey();                                  //ReadKey
        }
    }
}