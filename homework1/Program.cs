using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;

            Console.WriteLine("Please, Enter Your Name:");
            String OwnerName = Console.ReadLine();
            Console.WriteLine(" Hello  " +OwnerName + " Todays Date is: ");
           Console.Write( date.ToString("d/M/yyyy"));
            Console.ReadLine();
        }
    }
}
