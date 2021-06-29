using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Shape
    {
        protected int height;
        protected int width;

        public void setHeight(int h)
        {
            height = h;
        }

        public void setWidth(int w)
        {
            width = w;
        }
    }

    class Rectangle : Shape
    {
        public int setArea()
        {
            return (height * width);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            
            Console.WriteLine("The values of X is \n");
            int x = int.Parse(Console.ReadLine());

            rectangle.setHeight(x);
            rectangle.setWidth(4);

            Console.WriteLine("Total area is " + rectangle.setArea());
            Console.ReadKey();
        }
    }
}
