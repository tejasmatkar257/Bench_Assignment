using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Reflection1
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true)]
    class SoftwareAttribute : Attribute
    {
        //public string SoftwareString { get; set; }
        private string ProjectName;
        private string Description;
        private string ClientName;
        private string StartDate;
        private string EndDate;
        public string projectname
        {
            get { return ProjectName; }
            set { ProjectName = value; }
        }
        public string description
        {
            get { return Description; }
            set { Description = value; }
        }
        public string clientName
        {
            get { return ClientName; }
            set { ClientName = value; }
        }
        public string startdate
        {
            get { return StartDate; }
            set { StartDate = value; }
        }
        public string enddate
        {
            get { return EndDate; }
            set
            {
                EndDate = value;
            }
        }

        public SoftwareAttribute(string ProjectName, string Description, string ClientName, string StartDate, string EndDate)
        {
            this.ProjectName = ProjectName;
            this.Description = Description;
            this.ClientName = ClientName;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }
    }

    [SoftwareAttribute("C#", "To Create Applications", "Natasha", "08-09-2022", "08-09-2023")]
    public class HDFC
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
                Console.WriteLine("***\n");
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

    [SoftwareAttribute("C#", "To Create Applications", "Natasha", "08-09-2022", "08-09-2023")]
    public class IciciBank
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
                Console.WriteLine("WELCOME TO ICIC BANK ATM SERVICE\n");
                Console.WriteLine("1. Current Balance\n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Cancel \n");
                Console.WriteLine("***\n");
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
            Console.ReadLine();
        }
    }
    //[SoftwareAttribute("C#", "To Create Applications", "Natasha", "08-09-2022", "08-09-2023")]
    class Test
    {
        public static void Main(string[] args)
        {
            IciciBank icic = new IciciBank();
            IciciBank.Main();
            Type type = typeof(IciciBank);
            IciciBank.Main();
            HDFC hdfc = new HDFC();
            HDFC.Main();
            Type type1 = typeof(HDFC);
            foreach (Object attributes in type.GetCustomAttributes(false))
            {
                SoftwareAttribute dbi = (SoftwareAttribute)attributes;
                if (null != dbi)
                {
                    Console.WriteLine("Project Name: {0}", dbi.projectname);
                    Console.WriteLine("Description: {0}", dbi.description);
                    Console.WriteLine("StartDate: {0}", dbi.startdate);
                    Console.WriteLine("EndDate: {0}", dbi.enddate);
                }
            }
            Console.ReadLine();
        }

    }
}