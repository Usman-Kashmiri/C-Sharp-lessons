using System;

class program
{

  static void Main (string[] args)
  {

    Console.WriteLine ("Please Enter Unit Consumed: ");

    float unit = float.Parse(Console.ReadLine());

    float bill;

    int TVLfee = 35;


    if (unit < 300)
    {
	    bill = (unit * 12);
    }
    else if (unit >= 300)
    {
    	bill = (unit * 18);
    }
    else if (unit >= 500)
    {
	    bill = (unit * 24);
    } else bill = unit * 28;

    float EDuty = (bill / 100) * 1.5f;

    float GST = (bill / 100) * 17;

    bill = bill + EDuty + GST + TVLfee;
    
    
    Console.WriteLine ($"Your Electricity Duty is Rs. {EDuty}");
    Console.WriteLine ($"TV Licence Fee is Rs. {TVLfee}");
    Console.WriteLine ($"Your General Sales Tax is Rs. {GST}");
    Console.WriteLine ($"Your Electricity bill is Rs. {bill}");
    
    Console.Read();
  }
}
