using System;

namespace HDFCBank
{
    class Program
    {
        public static void Main()
        {
            int amount = 10034, deposit, withdraw;
            int choice, pin = 0;
            Console.WriteLine("Enter Your 4 Digit Pin ");
            pin = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("WELCOME TO HDFC BANK ATM SERVICE\n");
                Console.WriteLine("1. Current Balance\n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Cancel \n");
                Console.WriteLine("*****\n");
                Console.WriteLine("ENTER YOUR CHOICE : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n YOUR CURRENT BALANCE IS Rs : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER THE WITHDRAW AMOUNT : ");
                        withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN ABOVE 100");
                        }
                        else if (withdraw > 1000)
                        {

                            Console.WriteLine("Insufficient Money");
                            Console.WriteLine("Transaction cannot be continued below specified limit of Rs.- 1000");

                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n PLEASE COLLECT YOUR CASH");
                            Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                        deposit = Convert.ToInt32(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY");
                        Console.WriteLine("YOUR TOTAL BALANCE IS Rs : {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("Thank You");
                        break;
                }
            }
        }
    }
}