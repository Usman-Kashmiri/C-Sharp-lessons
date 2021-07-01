using System;

namespace Multilevel_inheritance_ex01
{

    class Grandfather
    {
        public void show1()
        {
            Console.WriteLine("Hair color - Black");
        }
    }
    
    class Father : Grandfather
    {
        public void show2()
        {
            Console.WriteLine("Eyes color - Brown");
        }
    }
    
    class Child : Father
    {
        public void show3()
        {
            Console.WriteLine("Higher IQ level");
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Child childsprop = new Child();
            childsprop.show1();
            childsprop.show2();
            childsprop.show3();
            
            Console.ReadLine();
        }
    }
}
