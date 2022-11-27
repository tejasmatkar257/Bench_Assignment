using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcicBank
{

    public delegate void Notify1();
    internal class IciciBank
    {
        protected int Account_Number1;
        protected string Customer_Name1;
        protected int Balance1;
        protected int Amount1;
        public event Notify1 ZeroBalance;
        public event Notify1 UnderBalance;
        public void Diposit1()
        {
            Console.WriteLine("Welcome to ICIC Services");
            Console.WriteLine("enter account number");
            Account_Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customer name");
            Customer_Name1 = Console.ReadLine();
            Console.WriteLine("enter amount to disposit");
            Balance1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("balance amount is" + ":" + Balance1);
        }
        public virtual void WithDraw1()
        {

            Console.WriteLine("enter amount to withdrawl");
            Amount1 = Convert.ToInt32(Console.ReadLine());

            if (Balance1 == 0)
            {
                OnZeroBalance();
            }

            else if (Amount1 > (Balance1 - 11000))
            {
                Onunderbalance();
            }
            else
            {
                Balance1 = Balance1 - Amount1;
                Console.WriteLine("your balance is" + ":" + Balance1 + "---" + "ICICITRANSACTION SUCCESSFULL");

            }

        }
        protected virtual void OnZeroBalance()
        {
            ZeroBalance?.Invoke();
        }
        protected virtual void Onunderbalance()
        {
            UnderBalance?.Invoke();
        }

    }

    class ICICI
    {
        public static void Main()
        {
            IciciBank account = new IciciBank();
            account.ZeroBalance += z1_ZeroBalance;
            account.UnderBalance += z2_underbalace;
            account.Diposit1();
            account.WithDraw1();
            Console.ReadKey();
        }

        public static void z1_ZeroBalance()
        {
            Console.WriteLine("Transaction cannot be continued as balance is zero in Account ");
        }
        public static void z2_underbalace()
        {
            Console.WriteLine("Transaction cannot be continued as balance is insufficient");

        }
    }
}
