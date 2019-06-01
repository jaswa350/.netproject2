using System;

namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            SpareParts SP = new SpareParts();
            ComputerSales CS = new ComputerSales();
            Console.WriteLine("Do you need ");
            Console.WriteLine("1.Computer 2.Spare parts ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                
                CS.Details();
            }
            else
            {
                
                SP.Details();
            }

            SP.PriceFixing();

            Console.ReadKey();
        }
    }
}