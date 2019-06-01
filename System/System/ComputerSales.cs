using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    class ComputerSales:GetDetails
    {
            
        public override void Details()
        {
            Console.WriteLine("building system.....");
            Console.WriteLine("Enter the Spareparts needed");
            Console.WriteLine("What size of monitor do you want ?");
            Console.WriteLine("1.15inch 2.16inch");
            monitor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the processor type?");
            Console.WriteLine("1.I5 2.I7 3.I10");
            speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount of Ram needed ");
            Console.WriteLine("1.4GB 2.8GB");
            ram = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need a Drive or not?");
            Console.WriteLine("1.Yes 2. NO");
            drive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Type of Mouse?");
            Console.WriteLine("1.Wired Logitech 2.Wireless HCL");
            mouse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the type of Keyboard do you need?");
            Console.WriteLine("1.101 Keys 2.103 keys");
            keyBoard = Convert.ToInt32(Console.ReadLine());
            ports = 1;
            SpareParts p = new SpareParts();
            p.PriceFixing();


        }
    }
    
}
