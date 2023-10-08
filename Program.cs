using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Car_Park_Ticket_Machine_Yaz
{
    internal class Program
    {
        private static string carRegistration = "";
        private static string coinsValue = "";
        private static string userChoice = "n";
        static void Main()
        {
            DateTime newDateTime = DateTime.Now;
            Registration();

            TimeSelect(userChoice);

            GetCoins(newDateTime);

            DateTime currentDateTime = DateTime.Now;
            string coinsValueWithDateTime = $"{currentDateTime}";

            PrintTicket(newDateTime, coinsValueWithDateTime, carRegistration);
        }

        static string TimeSelect(string userChoice)
        {
            if (userChoice.ToLower() == "y")
            {
                Console.Clear(); // Clears the screen
                Console.WriteLine("Please select duration:\t(Press number 1-7)\n\n1\tUp to 30 minutes £1\n2\t" +
                "Up to 1 hour\t £2\n3\tUp to 2 hours\t £3\n4\tUp to 3 hours\t £4\n5\tUp to 4 hours\t £5\n" +
                "6\tUp to 6 hours\t £6\n7\tUp to 12 hours\t £10\n\nAmount Tendered: £0\n");
            }
            else if (userChoice.ToLower() == "n")
            {
                Console.WriteLine("Please Re-Enter your registration.");
                Main();
            }
            return userChoice;
        }

        static void PrintTicket(DateTime newDateTime, string coinsValue, string carRegistration)
        {
            int sleep = 500; // Creates a variable to delay text for 0.8 seconds (800 milliseconds)
            Thread.Sleep(sleep); // Sleep for 0.8 seconds (800 milliseconds)
            Console.WriteLine("Thank you, Please Wait...");
            int sleep1 = 1100;
            Thread.Sleep(sleep1);
            Console.Clear();
            Console.WriteLine("Printing Ticket . . .\n\n");
            Thread.Sleep(sleep1);
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("                              \n  Y A Z ' S  C A R  P A R K   \n                              \n  Registration: " + carRegistration
                              + "             \n                              \n  Entry: " + DateTime.Now + "  \n         " +
                              "                     \n  Fee:   " + coinsValue + "  \n                              \n  Ex" +
                              "piry: " + newDateTime + " \n                              \n      Have a nice day!        \n                              \n");
            Console.BackgroundColor = ConsoleColor.Blue;
        }

        static void GetCoins(DateTime newDateTime)
        {
            while (true)
            {
                string userTime = Console.ReadLine();
                DateTime currentDateTime1 = DateTime.Now;
                if (userTime == "1")
                {
                    Console.WriteLine("\nPlease enter coins to the value of £1\n");
                    coinsValue = Console.ReadLine();
                    newDateTime = currentDateTime1.AddMinutes(30);
                    string userInputWithDateTime = $"{newDateTime}";
                    break;
                }
                else if (userTime == "2")
                {
                    Console.WriteLine("\nPlease enter coins to the value of £2\n");
                    coinsValue = Console.ReadLine();
                    newDateTime = currentDateTime1.AddHours(1);
                    string userInputWithDateTime = $"{newDateTime}";
                    break;
                }
                else if (userTime == "3")
                {
                    Console.WriteLine("\nPlease enter coins to the value of £3\n");
                    coinsValue = Console.ReadLine();
                    newDateTime = currentDateTime1.AddHours(2);
                    string userInputWithDateTime = $"{newDateTime}";
                    break;
                }
                else if (userTime == "4")
                {
                    Console.WriteLine("\nPlease enter coins to the value of £4\n");
                    coinsValue = Console.ReadLine();
                    newDateTime = currentDateTime1.AddHours(3);
                    string userInputWithDateTime = $"{newDateTime}";
                    break;
                }
                else if (userTime == "5")
                {
                    Console.WriteLine("\nPlease enter coins to the value of £5\n");
                    coinsValue = Console.ReadLine();
                    newDateTime = currentDateTime1.AddHours(4);
                    string userInputWithDateTime = $"{newDateTime}";
                    break;
                }
                else if (userTime == "6")
                {
                    Console.WriteLine("\nPlease enter coins to the value of £6\n");
                    coinsValue = Console.ReadLine();
                    newDateTime = currentDateTime1.AddHours(6);
                    string userInputWithDateTime = $"{newDateTime}";
                    break;
                }
                else if (userTime == "7")
                {
                    Console.WriteLine("\nPlease enter coins to the value of £10\n");
                    coinsValue = Console.ReadLine();
                    newDateTime = currentDateTime1.AddHours(12);
                    string userInputWithDateTime = $"{newDateTime}";
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input, Please try again");
                }
            }
        }

        static void Registration()
        {
            while (userChoice.ToLower() == "n")
            {
                Console.ForegroundColor = ConsoleColor.Black; Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("\n###########################################################\n\n  W E L" +
                " C O M E   T O   Y A Z ' S   C A R   P A R K  \n\n#######################################" +
                "####################\n\nPlease enter car registration:\n");
                carRegistration = Console.ReadLine();
                Console.WriteLine("\nRegistration entered: " + carRegistration + "\n\nIs this correct? (y/n)");
                userChoice = Console.ReadLine();
            }
        }
    }
}
