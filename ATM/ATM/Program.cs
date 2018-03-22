using System;

namespace ATM
{
    public class Program
    {
        static decimal balance = 1000;

        static void Main(string[] args)
        {
            // Persist the main menu
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        /// <summary>
        /// Main Menu, display and IO
        /// </summary>
        /// <returns>Returns nothing</returns>
        private static bool MainMenu()
        {
            string answer;
            

            Console.WriteLine("Bank ATM");
            Console.WriteLine("Chose an option");
            Console.WriteLine("1.) View Balance");
            Console.WriteLine("2.) Make a Withdrawl");
            Console.WriteLine("3.) Make a Deposit");
            Console.WriteLine("4.) Exit");

            answer = Console.ReadLine();
            if (answer == "1")
            {
                ViewBalance(balance);
                return true;
            }
            if (answer == "2")
            {
                Console.Clear();
                Console.WriteLine("Enter amount to withdraw: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                balance = Withdrawl(amount, balance);
                return true;
            }
            if (answer == "3")
            {
                Console.Clear();
                Console.WriteLine("Enter amount to deposit: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                balance = Deposit(amount, balance);
                return true;
            }
            if (answer == "4")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// View the balance
        /// </summary>
        /// <param name="balance"></param>
        /// <returns>Returns the same value as came in.  Maintained for compatiblilty</returns>
        public static decimal ViewBalance(decimal balance)
        {
            Console.Clear();
            Console.WriteLine("Your account balance is: {0}", balance);
            return balance;
        }

        /// <summary>
        /// Withdrawl
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="balance"></param>
        /// <returns>Returns the amount of balance minus amount</returns>
        public static decimal Withdrawl(decimal amount, decimal balance)
        {
            
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Your new balance is {0}", balance);
                return balance;
            }
            else
            {
                Console.WriteLine("You don't have enough money for that.  Your balance is {0}", balance);
                return balance;
            }
        }

        /// <summary>
        /// Deposit
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="balance"></param>
        /// <returns>Returns the amount of balance plus amount</returns>
        public static decimal Deposit(decimal amount, decimal balance)
        {
            if (amount < 0)
            {
                try
                {
                    Console.WriteLine("You can not deposit a negative amount.");
                    return balance;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                    throw;
                }
            }
            else
            {
                balance += amount;
                Console.WriteLine("Your new balance is {0}", balance);
                return balance;
            }
        }        
    }
}
