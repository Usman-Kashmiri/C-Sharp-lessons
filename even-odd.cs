using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter Any Number");
            int n = int.Parse(Console.ReadLine());

            if ((n / 2) * 2 == n)
            {
                Console.Write("The Given Number is Even");
                Console.ReadLine();
            }
            else
            {
                Console.Write("The Given Number is Odd");
                Console.ReadLine();
            }
        }
    }
}
