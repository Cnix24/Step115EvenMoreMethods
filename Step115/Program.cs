using System;

namespace Step115
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            MethodClass method1 = new MethodClass();
            Console.WriteLine("Please enter a number: ");
            string xString = Console.ReadLine();

            Console.WriteLine("Enter a second number, or leave blank: ");
            string yString = Console.ReadLine();
            try
            {
                y = Convert.ToInt32(yString);
            }
            catch
            {
                y = 0;
            }
            
            x = Convert.ToInt32(xString);
           

            int answer = method1.MethodX(x, y);
            Console.WriteLine("Your two numbers combined equals: "+answer);

            Console.ReadLine();
        }
    }
}
