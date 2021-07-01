using System;

namespace Multiple_inheritance_ex01
{

    class CurrentAcc : TotalBalance
    {
        public void show1()
        {
            Console.WriteLine("Current Account Balance = 50,000");
        }
    }
    
    class SavingAcc : TotalBalance
    {
        public void show2()
        {
            Console.WriteLine("Saving Account Balance = 100,000");
        }
    }
    
    class TotalBalance
    {
        public void show3()
        {
            Console.WriteLine("Total Balance = 150,000");
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            CurrentAcc balance = new CurrentAcc();
            balance.show3();
            balance.show1();
            
            Console.ReadLine();
        }
    }
}
