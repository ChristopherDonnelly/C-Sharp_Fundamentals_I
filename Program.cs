using System;

namespace Fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            loop255();
            loop100();
            loop100FizzBuzz();
            loop100NonModulus();
        }

        public static void loop255(){
            for(int i = 1; i <=255; i++)
            {
                Console.WriteLine("Loop 255 value: "+i);
            }
            
        }

        public static void loop100(){
            for(int i = 1; i <=100; i++)
            {
                if((i % 3 == 0 || i % 5 == 0) && (i % 15 != 0)) Console.WriteLine("Loop 100 value: "+i);
            }
            
        }

        public static void loop100FizzBuzz(){
            for(int i = 1; i <=100; i++)
            {
                if(i % 15 == 0) Console.WriteLine("Loop 100 value: "+i+" - FizzBuzz");
                else if(i % 3 == 0) Console.WriteLine("Loop 100 value: "+i+" - Fizz");
                else if(i % 5 == 0) Console.WriteLine("Loop 100 value: "+i+" - Buzz");
                
            }
            
        }

        public static void loop100NonModulus(){
            for(int i = 1; i <=100; i++)
            {
                Console.WriteLine($"#{i} = {i/3}");
                //if((i % 3 == 0 || i % 5 == 0) && (i % 15 != 0)) Console.WriteLine("Loop 100 value: "+i);
            }
            
        }
    }
}
