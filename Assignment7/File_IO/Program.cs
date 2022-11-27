using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace File_IO
{

    class Employee
    {
        public int EMPID;
        public string Name;
        public double Salary, GrossSalary, PF, TDS, NetSalary;
        public void employee()
        {
            Console.WriteLine("emter empid");
            EMPID = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            Name = Console.ReadLine();

        }
    }

    class Manager : Employee
    {

        public double PetrolAllowance;
        public double FoodAllowance;
        public double OtherAllowance;
        public void manager()
        {
            Console.WriteLine("enter salary ");
            Salary = double.Parse(Console.ReadLine());
            PetrolAllowance = (8 * Salary) / 100;
            Console.WriteLine("PetrolAllowance allowances:" + PetrolAllowance);
            FoodAllowance = (13 * Salary) / 100;
            Console.WriteLine("food allowances: " + FoodAllowance);
            OtherAllowance = (3 * Salary) / 100;
            Console.WriteLine("other allowances: " + OtherAllowance);
            GrossSalary = Salary + PetrolAllowance + FoodAllowance + OtherAllowance;
            Console.WriteLine("GrossSalry of Manager: " + GrossSalary);
            PF = (10 * Salary) / 100;
            Console.WriteLine("PF of manager: " + PF);
            TDS = (18 * Salary) / 100;
            Console.WriteLine("TDS of manager: " + TDS);
        }
        public void CalculateSalary()
        {
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine("NetSalary: " + NetSalary);
        }


    }
    //[Serializable]
    class MarketingExecutive : Manager
    {
        double KilometerTravel;
        double TourAllowances;
        double TelephoneAllowances;
        public void marketingExecutive()
        {
            Console.WriteLine("enter salary of MarketingExecutive");
            Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("enter kilo meters");
            KilometerTravel = double.Parse(Console.ReadLine());
            TourAllowances = 5 * KilometerTravel;
            Console.WriteLine("TourAllowances allowances: " + TourAllowances);
            TelephoneAllowances = 1000;
            Console.WriteLine("Telephone allowances: " + TelephoneAllowances);
            GrossSalary = Salary + TourAllowances + TelephoneAllowances;
            Console.WriteLine("GrossSalary of marketing executive: " + GrossSalary);
            PF = (10 * Salary) / 100;
            Console.WriteLine("PF of Marketing executive: " + PF);
            TDS = (18 * Salary) / 100;
            Console.WriteLine("TDS of Marketing executive: " + TDS);
            void CalculateSalary()
            {
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("NetSalary: " + NetSalary);
            }
        }

    }
    //[Serializable]
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();
            Manager M = new Manager();
            MarketingExecutive M1 = new MarketingExecutive();
            employee.employee();
            M.manager();
            M.CalculateSalary();
            M1.marketingExecutive();
            M1.CalculateSalary();
            

        }
    }
}