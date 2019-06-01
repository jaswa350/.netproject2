using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    class SpareParts:GetDetails
    {
        int a;
        public override void Details()
        {
            Console.WriteLine("Enter the Spareparts needed");
            Console.WriteLine("1.Monitor : 15 inch and 16 inch");
            Console.WriteLine("2.Speed : I5, I7, I10");
            Console.WriteLine("3.RAM : 4GB, 8GB");
            Console.WriteLine("4.DRIVE : optional");
            Console.WriteLine("5.Mouse : Wired Logitech and Wireless HCL");
            Console.WriteLine("6.Keyboard : 101 keys, 103 keys ");
            Console.WriteLine("7.PORTS: PS2 Mouse port, PS3 keyboard, printer port, wifi port.");
            Console.WriteLine("8.Exit");
            do
            {
                Console.WriteLine("enter your choice");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                 
                    case 1:

                        Console.WriteLine("What size of monitor do you want ?");
                        Console.WriteLine("1.15inch 2.16inch");
                        monitor = Convert.ToInt32(Console.ReadLine());
                       
                        break;

                    case 2:

                        Console.WriteLine("Enter the processor type?");
                        Console.WriteLine("1.I5 2.I7 3.I10");
                        speed= Convert.ToInt32(Console.ReadLine());
                       
                        break;

                    case 3:

                        Console.WriteLine("Enter the amount of Ram needed ");
                        Console.WriteLine("1.4GB 2.8GB");
                        ram= Convert.ToInt32(Console.ReadLine());
                       
                        break;

                    case 4:

                        Console.WriteLine("Do you need a Drive or not?");
                        Console.WriteLine("1.Yes 2. NO");
                        drive = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 5:

                        Console.WriteLine("Enter the Type of Mouse?");
                        Console.WriteLine("1.Wired Logitech 2.Wireless HCL");
                        mouse = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:

                        Console.WriteLine("Enter the type of Keyboard do you need?");
                        Console.WriteLine("1.101 Keys 2.103 keys");
                        keyBoard = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:

                        Console.WriteLine("enter 1 to select  PS2 Mouse port, PS3 keyboard, printer port, wifi port ");
                        ports= Convert.ToInt32(Console.ReadLine());
                        break;


                    default:
                        break;
                }

            } while (a!=8);

        }



        public void PriceFixing()
        {
            if (monitor == 1)
            {
                Console.WriteLine("Enter the price of 15 inch monitor");
                monitor_p = Convert.ToInt32(Console.ReadLine());
            }
            else if (monitor == 2)
            {
                Console.WriteLine("Enter the price of 16 inch monitor");
                monitor_p = Convert.ToInt32(Console.ReadLine());
            }
            if (speed == 1)
            {
                Console.WriteLine("Enter the price of I5 processor");
                speed_p = Convert.ToInt32(Console.ReadLine());
            }
            else if (speed == 2)
            {
                Console.WriteLine("Enter the price of I7 processor");
                speed_p = Convert.ToInt32(Console.ReadLine());
            }
            else if (speed == 3)
            {
                Console.WriteLine("Enter the price of I10 processor");
                speed_p = Convert.ToInt32(Console.ReadLine());
            }
            if (ram == 1)
            {
                Console.WriteLine("Enter the price of 4GB ram ");
                ram_p = Convert.ToInt32(Console.ReadLine());
            }

            else if (ram == 2)
            {
                Console.WriteLine("Enter the price of 8gb ram");
                monitor_p = Convert.ToInt32(Console.ReadLine());
            }
            if (drive == 1)
            {
                Console.WriteLine("enter the price for the drive");
                drive_p = Convert.ToInt32(Console.ReadLine());
            }
            if (mouse == 1)
            {
                Console.WriteLine("enter the price for wired logitech mouse");
                mouse_p = Convert.ToInt32(Console.ReadLine());
            }
            else if (mouse == 2)
            {
                Console.WriteLine("enter the price for wireless hcl");
                mouse_p = Convert.ToInt32(Console.ReadLine());

            }
            if (keyBoard == 1)
            {
                Console.WriteLine("enter the price for 101 keys keyboard");
                keyBoard_p = Convert.ToInt32(Console.ReadLine());

            }
            else if (keyBoard == 2)
            {
                Console.WriteLine("enter the price for 103 keys keyboard");
                keyBoard_p = Convert.ToInt32(Console.ReadLine());
            }
            if (ports == 1)
            {

                Console.WriteLine("enter the price for ports");
                ports_p = Convert.ToInt32(Console.ReadLine());

            }
           

        }
        
    }
}
