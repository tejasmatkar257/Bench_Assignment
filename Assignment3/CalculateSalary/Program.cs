using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class Inheritence
    {

        class Employee
        {
            protected int EmpNo { get; set; }
            protected string EmpName { get; set; }
            protected double Salary { get; set; }
            protected double HRA { get; set; }
            protected double TA { get; set; }
            protected double DA { get; set; }
            public double PF { get; set; }
            protected double TDS { get; set; }
            protected double NetSalary { get; set; }
            protected double GrossSalary { get; set; }


            public Employee(int EmpNum, string EmpName, double Sal)
            {
                EmpNo = EmpNo;
                EmpName = EmpName;
                Salary = Sal;
                if (Salary < 5000)
                {
                    HRA = Salary * 10 / 100;
                    TA = Salary * 5 / 100;
                    DA = Salary * 15 / 100;
                    GrossSalary = Salary + HRA + TA + DA;
                }
                else if (Salary < 10000)
                {
                    HRA = Salary * 15 / 100;
                    TA = Salary * 10 / 100;
                    DA = Salary * 20 / 100;
                    GrossSalary = Salary + HRA + TA + DA;
                }
                else if (Salary < 15000)
                {
                    HRA = Salary * 20 / 100;
                    TA = Salary * 15 / 100;
                    DA = Salary * 25 / 100;
                    GrossSalary = Salary + HRA + TA + DA;
                }
                else if (Salary < 20000)
                {
                    HRA = Salary * 25 / 100;
                    TA = Salary * 20 / 100;
                    DA = Salary * 30 / 100;
                    GrossSalary = Salary + HRA + TA + DA;
                }
                else
                {
                    HRA = Salary + 30 / 100;
                    TA = Salary + 25 / 100;
                    DA = Salary + 35 / 100;
                    GrossSalary = Salary + HRA + TA + DA;
                }
            }
            public virtual void CalculateSalary()
            {
                PF = GrossSalary * (0.1);
                TDS = GrossSalary * (0.18);
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("NetSalary of Employee:{0}", NetSalary);
                Console.WriteLine("PF of Employee:{0}", PF);
            }

            public virtual void Gsal()
            {
                Console.WriteLine("GrossSalary of Employee:{0}", GrossSalary);
            }

        }



        class Manager : Employee
        {
            private double PetrolAllowance { get; set; }
            private double FoodAllowance { get; set; }
            private double OtherAllowance { get; set; }
            public Manager(int EmpNum, string EmpNm, double Sal) : base(EmpNum, EmpNm, Sal)
            {
                PetrolAllowance = Salary * 8 / 100;
                FoodAllowance = Salary * 13 / 100;
                OtherAllowance = Salary * 3 / 100;
            }
            public override void Gsal()
            {
                GrossSalary = (GrossSalary + PetrolAllowance + FoodAllowance + OtherAllowance);
                Console.WriteLine("GrossSalary of Manager :{0}", GrossSalary);
            }

            public override void CalculateSalary()
            {
                PF = GrossSalary * (0.1);
                TDS = GrossSalary * (0.18);
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("NetSalary of Manager :{0}", NetSalary);
                Console.WriteLine("PF of Manager:{0}", PF);
            }
        }
        class MarketingExecutive : Employee
        {
            private double kilometertravel { get; set; }
            private double TourAllowance { get; set; }
            private double TelephoneAllowance { get; set; }

            public MarketingExecutive(int EmpNum, string EmpNm, double Sal, double klt) : base(EmpNum, EmpNm, Sal)
            {
                kilometertravel = klt;
                TourAllowance = kilometertravel * 5;
                TelephoneAllowance = 1000;
            }
            public override void Gsal()
            {
                GrossSalary = (GrossSalary + TourAllowance + TelephoneAllowance);
                Console.WriteLine("GrossSalary of MarketingExecutive:{0}", GrossSalary);
            }
            public override void CalculateSalary()
            {
                PF = GrossSalary * (0.1);
                TDS = GrossSalary * (0.18);
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("NetSalary of MarketingExecutive:{0}", NetSalary);
                Console.WriteLine("PF of MarketingExecutive:{0}", PF);

            }

        }
        public interface IPrintableinterface
        {
            void IPrintableMethod();

        }
        class Program : IPrintableinterface
        {
            public void IPrintableMethod()
            {
                Employee Emp1 = new Employee(1, "chitti", 25000);
                Manager M1 = new Manager(2, "Priya", 30000);
                MarketingExecutive MarkE1 = new MarketingExecutive(3, " charan ", 40000, 10);
                Console.WriteLine("empNum:1", Emp1);
                Console.WriteLine("EmpName:Vijji", Emp1);
                Console.WriteLine("salary:25000", Emp1);
                Console.WriteLine("empNum:2", M1);
                Console.WriteLine("EmpName:Priya", M1);
                Console.WriteLine("salary:30000", M1);
                Console.WriteLine("empNum:3", MarkE1);
                Console.WriteLine("EmpName:charan", MarkE1);
                Console.WriteLine("salary:40000", MarkE1);

            }
            public static void Main(string[] args)
            {
                Program P = new Program();
                P.IPrintableMethod();
                Employee Emp1 = new Employee(1, "Vijji", 25000);
                Manager M1 = new Manager(2, "Priya", 30000);
                MarketingExecutive MarkE1 = new MarketingExecutive(3, " charan ", 40000, 10);
                Emp1.Gsal();
                M1.Gsal();
                MarkE1.Gsal();
                M1.CalculateSalary();
                Emp1.CalculateSalary();
                MarkE1.CalculateSalary();



            }


        }
    }

}