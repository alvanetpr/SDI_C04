using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseAlvaradoDiaz_CE04
{


    class Program
    {
        static void Main(string[] args)
        {


             string logd = "OFF";
            Console.WriteLine("Code Excercise 04: Logging\r\n\r\n");

            var cC = new Car();
            string usrInput;
            do
            {
                Console.Clear();
                Console.WriteLine("Loggin is: " + logd + "" );
                Console.WriteLine("1. Disable logging");
                Console.WriteLine("2. Enable logging");
                Console.WriteLine("3. Create a car");
                Console.WriteLine("4. Drive the car");
                Console.WriteLine("5. Destroy the car");
                Console.WriteLine("6. Exit");

                usrInput = Console.ReadLine().ToLower();
                

                if (usrInput == "exit" || usrInput == "6")
                {
                    Environment.Exit(0);
                }

                switch (usrInput)
                {
                    case "1":
                    case "disable logging":
                        {
                            logd = "OFF";
                            Console.WriteLine("\r\nDisable\r\n");
                        }break;
                    case "2":
                    case "enable logging":
                        {
                            logd = "ON";
                            Console.WriteLine("\r\nEnable\r\n");
                        }
                        break;
                    case "3":
                    case "create a car":
                        {
                            if (usrInput == "create a car" || usrInput == "3")
                            {


                                Console.WriteLine("Enter car Make: ");
                                cC.make = Console.ReadLine();
                                

                                Console.WriteLine("Enter car Model: ");
                                cC.model = Console.ReadLine();

                                Console.WriteLine("Enter car Color: ");
                                cC.color = Console.ReadLine();


                                Console.WriteLine("Enter car Milage: ");
                                cC.milage = float.Parse(Console.ReadLine());



                                Console.WriteLine("Enter car Year: ");
                                cC.year = Convert.ToInt32(Console.ReadLine());


                                Console.WriteLine("\r\nYou select: \r\n" + cC.make + "\r\n" + cC.model + "\r\n" + cC.color + "\r\n" + cC.milage + "\r\n" + cC.year + "\r\n");
                            }
                        }break;
                    case "4":
                    case "drive the car":
                        {
                            if (cC.make != null)
                            {
                                Console.WriteLine("How far your driving");
                                var fM = Convert.ToInt32(Console.ReadLine());
                                var nM = cC.milage + fM;
                                cC.milage = nM;
                                Console.WriteLine("\r\nYou select: \r\n" + cC.make + "\r\n" + cC.model + "\r\n" + cC.color + "\r\n" + nM + "\r\n" + cC.year + "\r\n");
                               
                                Console.WriteLine("New milage: " + nM + "\r\n");
                            }
                            else
                            {
                                Console.WriteLine("You dont have a current car, Create a car first");
                            }


                        }break;
                    case "5":
                    case "destroy the car":
                        {
                            cC.make = null;
                            Console.WriteLine("Car Destroyed");
                            Console.WriteLine(cC.make);
                        }break;

                        
                     
;
                }


            } while (true);
        }
    }
}
