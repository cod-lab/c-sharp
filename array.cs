using System;
namespace Array
{
    class Array
    {
        static void Main(string[] args)
        {
            int sum=0;
            int[] x=new int[5]{1,2,3,4,5};
            Console.WriteLine(x.Length);
            for(int i=0;i<x.Length;i++)
            {
                Console.Write(x[i] + "\t");
                sum+=x[i];                              //sum=sum+x[i]
            }
            Console.Write("\n" + sum);
            Console.ReadKey();
        }
    }
}