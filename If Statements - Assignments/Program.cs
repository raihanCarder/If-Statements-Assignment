using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements___Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {    // Raihan Carder

            Console.Title = "Menu";
            SimpleBankingMachine();
            Console.Clear();
            Console.WriteLine("Welcome to the Menu");
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
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Sorry that is a invalid deposit.");
                        bankAccount -= 0.75;
                        Console.WriteLine($"Your new balance is ${bankAccount}.");
                        Console.WriteLine("We only allow one service per session. To quit Click enter");
                        Console.ReadLine();
                        
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
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Sorry that is a invalid Withdrawal.");
                        bankAccount -= 0.75;
                        Console.WriteLine($"Your new balance is ${bankAccount}.");
                        Console.WriteLine("We only allow one service per session. To quit Click enter");
                        Console.ReadLine();

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
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Sorry that is a invalid Bill payment.");
                        bankAccount -= 0.75;
                        Console.WriteLine($"Your new balance is ${bankAccount}.");
                        Console.WriteLine("We only allow one service per session. To quit Click enter");
                        Console.ReadLine();

                    }
                }
                else if (bankService == "CHECK ACCOUNT BALANCE")
                {
                    validSelection = true;
                    bankAccount -= 0.75;
                    Console.WriteLine($"Your new account balance is {bankAccount}");
                    Console.WriteLine("Sorry but we only allow one service per session. To Quit click enter.");
                    Console.ReadLine(); 
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
        }

        public static void ParkingGarage()
        {

        }
    }
}
