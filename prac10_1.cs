using System;
namespace Encapsulation
{
    class C1
    {
        private string name;
        
        public string Name
        {
            get{return name;}
            set{name=value;}
        }
        public int Age
        {
            get;
            //{return age;}
            set;
            //{age=value;}
        }
    }
    class C2
    {
        static void Main(string[] args)
        {
            C1 obj1=new C1();
            obj1.Name="My name is Arihant & my age is ";
            obj1.Age=20;

            Console.WriteLine(obj1.Name + obj1.Age + "\nThis is get set property of C# programming");
            Console.ReadKey();
        }
    }
}
