using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements___Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {    // Raihan Carder
            int option = 0;
            bool menu = false, validOption;

            while (menu == false)
            {
                validOption = false;
                Console.Title = "Menu";
                Console.WriteLine("Welcome to the Menu");
                Console.WriteLine();
                while (!validOption)
                {
                    Console.WriteLine("Which program would you like to explore?");
                    Console.WriteLine("1. Bank of Blorg, 2. Parking Ticket, 3. Hurricanes, 4. Quit");
                    Console.Write("Please type the number corresponding with your option: ");
                    if (int.TryParse(Console.ReadLine(), out option))
                    {
                        Console.Clear();
                        if (option == 1)
                        {    
                            validOption = true;
                            SimpleBankingMachine();
                        }
                        else if (option == 2)
                        {
                            validOption = true;
                            ParkingGarage();
                        }
                        else if (option == 3)
                        {
                            validOption = true;
                            Hurricane();
                        }
                        else if (option ==4)
                        {
                            validOption = true;
                            menu = true;
                        }
                        else
                        {
                            Console.WriteLine("ERROR, please select a value within the range.");
                        }
                    }
                    else
                    {
                        Console.Clear() ;
                        Console.WriteLine("ERROR, please select a valid  value within the range.");
                    }
                }
            }

            Console.ReadLine();


        }

        public static void SimpleBankingMachine()
        {
            Random generator = new Random();
            string bankService, userName;
            double bankAccount = generator.Next(150, 1001), depositAmount, withdrawal, billPayment;
            bool validSelection = false;
         
    
            Console.Title = "Bank of Blorg";
            Console.WriteLine("Welcome to the Bank of Blorb");
            Console.Write("Type in Your Username to view your Account: ");
            userName = Console.ReadLine().Trim();
            Console.WriteLine($"Welcome {userName}! Your balance is ${bankAccount}.");
            Console.WriteLine("Please type in where you'd like Service.");
            Console.WriteLine("Your options Include; Deposit, Withdrawal, Bill Payment, or Check Account Balance.");
            Console.Write("Your Answer: ");
            while (validSelection == false)
            {
                bankService = Console.ReadLine().ToUpper().Trim();

                if (bankService == "DEPOSIT")
                {
                    validSelection = true;
                    Console.WriteLine("You have Selected the DEPOSIT service.");
                    Console.Write("How much are you going to deposit?" );
                    if (Double.TryParse(Console.ReadLine(), out depositAmount) && depositAmount > 0)
                    {
                        Console.WriteLine("Your deposit amount is valid.");
                        bankAccount = depositAmount + bankAccount - 0.75;
                        Console.WriteLine($"Your new bank amount is: ${bankAccount}.");
                        Console.WriteLine("Sorry, but you're allowed one service per session. To Quit click enter.");

                    }
                    else
                    {
                        Console.WriteLine("Sorry that is a invalid deposit.");
                        bankAccount -= 0.75;
                        Console.WriteLine($"Your new balance is ${bankAccount}.");
                        Console.WriteLine("We only allow one service per session. To quit Click enter");

                        
                    }

                }
                else if (bankService == "WITHDRAWAL")
                {
                    validSelection = true;
                    Console.WriteLine("You have chosen the WithDrawal option");
                    Console.Write("How much would you like to Withdrawal? ");
                    if (Double.TryParse(Console.ReadLine(), out withdrawal) && withdrawal > 0 && withdrawal<bankAccount-0.75)
                    {
                        Console.WriteLine("Your Withdrawal amount is valid.");
                        bankAccount = bankAccount - withdrawal - 0.75;
                        Console.WriteLine($"Your new bank amount is: ${bankAccount}.");
                        Console.WriteLine("Sorry, but you're allowed one service per session. To Quit click enter.");

                    }
                    else
                    {
                        Console.WriteLine("Sorry that is a invalid Withdrawal.");
                        bankAccount -= 0.75;
                        Console.WriteLine($"Your new balance is ${bankAccount}.");
                        Console.WriteLine("We only allow one service per session. To quit Click enter");


                    }

                }
                else if (bankService == "BILL PAYMENT")
                {
                    validSelection = true;
                    Console.WriteLine("You have chosen the Bill Payment option");
                    Console.Write("How much would you like to pay off? ");
                    if (Double.TryParse(Console.ReadLine(), out billPayment) && billPayment > 0 && billPayment < bankAccount - 0.75)
                    {
                        Console.WriteLine("Your Withdrawal amount is valid.");
                        bankAccount = bankAccount - billPayment - 0.75;
                        Console.WriteLine($"Your new bank amount is: ${bankAccount}.");
                        Console.WriteLine("Sorry, but you're allowed one service per session. To Quit click enter.");

                    }
                    else
                    {
                        Console.WriteLine("Sorry that is a invalid Bill payment.");
                        bankAccount -= 0.75;
                        Console.WriteLine($"Your new balance is ${bankAccount}.");
                        Console.WriteLine("We only allow one service per session. To quit Click enter");


                    }
                }
                else if (bankService == "CHECK ACCOUNT BALANCE")
                {
                    validSelection = true;
                    bankAccount -= 0.75;
                    Console.WriteLine($"Your new account balance is {bankAccount}");
                    Console.WriteLine("Sorry but we only allow one service per session. To Quit click enter.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please type in one of the options Above to be forwarded to a Service.");
                    bankAccount -= 0.75;
                    Console.WriteLine($"Your new account balance is ${bankAccount}.");
                    Console.Write("Service wanted: ");                
                }
            }
            validSelection = false;
            Console.ReadLine ();
            Console.Clear();
        }

        public static void ParkingGarage()
        {
            int parkingMinutes, parkingHours, bill = 0;
            bool validTime = false; 


            Console.Title = "Parking Garage";
            while (validTime == false)
            {
                Console.Write("Enter how long you parked for in minutes: ");
                if (int.TryParse(Console.ReadLine(), out parkingMinutes) && parkingMinutes > 0)
                {
                    validTime = true;
                    Console.WriteLine("Valid input obtained, rounded to the next hour.");
                    parkingHours = (int)Math.Ceiling((double)parkingMinutes / 60);
                    Console.WriteLine($"You have parked for {parkingHours} hour(s).");

                    if (parkingHours > 1 && parkingHours < 9)
                    {
                        bill = (parkingHours-1) * 2 + 4;
                    }
                    else if (parkingHours == 1)
                    {
                        bill = 4;
                    }
                    else if (parkingHours >= 9)
                    {
                        bill = 20;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                        
                    }

                    Console.WriteLine($"Your bill totals to: ${bill}.");

                }
                else
                {
                    Console.WriteLine("Invalid time, make sure it is in positive integers only.");              
                }
            }
            validTime = false;
            Console.ReadLine();
            Console.Clear();
        }
        public static void Hurricane()
        {
            int hurricane;
            bool valid = false;

           
                Console.Title = "Hurricanes";
                Console.WriteLine("Hurricane Wind Speed Reader") ;
                Console.WriteLine();
                while (!valid)
                {
                    Console.Write("Which category hurricane would you like to see the wind speeds for (1-5): ");
                if (int.TryParse(Console.ReadLine(), out hurricane))
                {
                    switch (hurricane)
                    {
                        case 1:
                            Console.WriteLine("Category 1 wind speeds are: 74-95 mph or 64-82 kt or 119-153km/hr");
                            valid = true;
                            break;

                        case 2:
                            Console.WriteLine("Category 2 wind speeds are: 96-110 mph or 83-95 kt or 154-177 km/hr");
                            valid = true;

                            break;
                        case 3:
                            Console.WriteLine("Category 3 wind speeds are: 111-130 mph or 96-113 kt or 210-249 km/hr");
                            valid = true;
                            break;
                        case 4:
                            Console.WriteLine("Category 4 wind speeds are: 131-155 or 114-135 kt or 210-249 km/hr");
                            valid = true;
                            break;
                        case 5:
                            Console.WriteLine("Category 5 wind speeds are: greater than 155 mph or 135 kt or 249km/hr");
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("There's no hurricane over category 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error, Please enter a valid category hurricane");
                }
            }
            valid = true;
            Console.ReadLine();
            Console.Clear();
        }

    }
}
