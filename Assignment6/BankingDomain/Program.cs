using System;

namespace BankingDomain
{
    class Program
    {
        public static int Atm_Pin { get; private set; }

        public delegate void Bank(int x);

        public class Account
        {
            public int AccountNumber { get; set; }
            public string CustomerName { get; set; }
            public decimal bank_balance = 13000;


            public event Bank UnderBalance;
            public event Bank ZeroBalance;

            public void Insufficient(int i)
            {
                UnderBalance(i);
            }

            public void DepositAmount(int d)
            {
                ZeroBalance(d);
            }
            public void withdraw(int i)
            {
                if (i < bank_balance && bank_balance != 0)
                {
                    Console.WriteLine("please take your money");
                    Console.WriteLine("Transaction Successfull");
                    Console.WriteLine("Available Balance is:" + (bank_balance - i));
                }
                else if (i > bank_balance && bank_balance != 0)
                {
                    Console.WriteLine("Insufficient Amount");
                    Console.WriteLine("Your Current Balance is:" + bank_balance + "only");
                }
                else
                {
                    Console.WriteLine("Zero Balance:" + bank_balance);
                }
            }
            public void deposit(int i)
            {
                Console.WriteLine("Balance after depositing:" + (bank_balance + i));
            }
        }

        static void Main(string[] args)
        {
            Account acc = new Account();
            Console.WriteLine("Hello Customer!");
            Console.WriteLine("Enter Your Pin Number ");
            Atm_Pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("***Welcome to ATM Service***\n");
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Deposit");
            //Console.WriteLine("3. Quit");
            Console.WriteLine("-----------------");
            Console.WriteLine("select your option: 1 or 2 ");
            string withdraw = Console.ReadLine();
            //string deposit = Console.ReadLine();
            if (withdraw == "1")
            {
                Console.WriteLine("Enter your amount to be Withdraw");
                int withdrawbalance = Convert.ToInt32(Console.ReadLine());
                acc.UnderBalance += new Bank(acc.withdraw);
                acc.Insufficient(withdrawbalance);
            }
            else
            {
                Console.WriteLine("Enter your amount to be Deposit:");
                int depositbalance = Convert.ToInt32(Console.ReadLine());
                acc.ZeroBalance += new Bank(acc.deposit);
                acc.deposit(depositbalance);
            }
            //else
            //{
            //    Console.WriteLine("Thank You Using ATM");
            //}
            Console.ReadKey();
        }
    }
}