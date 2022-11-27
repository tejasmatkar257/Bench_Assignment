using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary2
{
    public class Litware
    {


        public class Employee
        {
            public int EmpNo;
            public string EmpName;
            public double Salary;
            public double HRA;
            public double TA;
            public double DA;
            public double PF;
            public double TDS;
            public double NetSalary;
            public double GrossSalary;




            public void setDataEmployee(int EmpNo, string EmpName, double Salary)
            {
                this.EmpNo = EmpNo;
                this.EmpName = EmpName;
                this.Salary = Salary;

            }
            public int getAutomatically()
            {

                Console.WriteLine("Please enter the Salary:");
                if (Salary >= 5000)
                {
                    if (Salary < 10000)
                    {
                        HRA = (Salary * 15) / 100;
                        TA = (Salary * 10) / 100;
                        DA = (Salary * 20) / 100;
                        Console.WriteLine("HRA:{0}", HRA);
                        Console.WriteLine("TA:{0}", TA);
                        Console.WriteLine("DA:{0}", DA);
                    }
                    else if (Salary < 15000)
                    {
                        HRA = (Salary * 20) / 100;
                        TA = (Salary * 15) / 100;
                        DA = (Salary * 25) / 100;
                        Console.WriteLine("HRA:{0}", HRA);
                        Console.WriteLine("TA:{0}", TA);
                        Console.WriteLine("DA:{0}", DA);
                    }
                    else if (Salary < 20000)
                    {
                        HRA = (Salary * 25) / 100;
                        TA = (Salary * 20) / 100;
                        DA = (Salary * 30) / 100;
                        Console.WriteLine("HRA:{0}", HRA);
                        Console.WriteLine("TA:{0}", TA);
                        Console.WriteLine("DA:{0}", DA);
                    }
                    else if (Salary >= 20000)
                    {
                        HRA = (Salary * 30) / 100;
                        TA = (Salary * 25) / 100;
                        DA = (Salary * 35) / 100;
                        Console.WriteLine("HRA:{0}", HRA);
                        Console.WriteLine("TA:{0}", TA);
                        Console.WriteLine("DA:{0}", DA);
                    }
                    else
                    {
                        HRA = 0;
                        TA = 0;
                        DA = 0;
                        Console.WriteLine("HRA:{0}", HRA);
                        Console.WriteLine("TA:{0}", TA);
                        Console.WriteLine("DA:{0}", DA);
                    }
                }
                else
                {
                    HRA = (Salary * 10) / 100;
                    TA = (Salary * 5) / 100;
                    DA = (Salary * 15) / 100;
                    Console.WriteLine("HRA:{0}", HRA);
                    Console.WriteLine("TA:{0}", TA);
                    Console.WriteLine("DA:{0}", DA);
                }
                return 0;





            }

            public double calculateGrossSalary()
            {
                GrossSalary = Salary + Salary * HRA / 100.0 + Salary * TA / 100.0 + Salary * DA / 100.0;
                Console.WriteLine("GrossSalary:{0}", GrossSalary);
                PF = GrossSalary * 0.1;
                Console.WriteLine("PF:{0}", PF);
                TDS = GrossSalary * 0.18;
                Console.WriteLine("TDS:{0}", TDS);
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine("NetSalary:{0}", NetSalary);
                return GrossSalary;


                // return GrossSalary - (GrossSalary * PF / 100.0 + GrossSalary * TDS / 100.0);
            }
        }


        public class Library
        {

            private List<Employee> employees = new List<Employee>();


            public void addEmployee(Employee emp)
            {
                this.employees.Add(emp);
            }


            public void displayEmployees()
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    Console.WriteLine("ID: {0}", employees[i].EmpNo);
                    Console.WriteLine("Name: {0}", employees[i].EmpName);
                    Console.WriteLine("Salary: {0}", employees[i].Salary);
                    Console.WriteLine("HRA: {0}", employees[i].HRA);
                    Console.WriteLine("TA: {0}", employees[i].TA);
                    Console.WriteLine("DA: {0}", employees[i].DA);
                    Console.WriteLine("PF: {0}", employees[i].PF);
                    Console.WriteLine("TDS: {0}", employees[i].TDS);
                    Console.WriteLine("Net Salary: {0}", employees[i].NetSalary);
                    Console.WriteLine("Gross Salary: {0}", employees[i].GrossSalary);

                    Console.WriteLine("-----------------");


                }
            }
        }




        public static void Main(string[] args)
        {
            try
            {
                Library library = new Library();
                //library.displayEmployees();




                int ch = -1;
                do
                {
                    Console.WriteLine("1. Enter the employee details");
                    Console.WriteLine("2. Display employee");
                    Console.WriteLine("3. Exit\n");
                    Console.Write("Your choice: ");
                    ch = int.Parse(Console.ReadLine());
                    if (ch == 1)
                    {
                        Console.Write("Enter Employee ID: ");
                        int EmpNo = int.Parse(Console.ReadLine());
                        Console.Write("Enter Employee Name: ");
                        string Name = Console.ReadLine();
                        Console.Write("Enter Employee Salary: ");
                        double Salary = double.Parse(Console.ReadLine());

                        Employee emp = new Employee();
                        emp.setDataEmployee(EmpNo, Name, Salary);
                        emp.getAutomatically();
                        emp.calculateGrossSalary();
                        library.addEmployee(emp);
                    }
                    else if (ch == 2)
                    {
                        library.displayEmployees();
                    }
                    else if (ch == 3)
                    {


                    }
                } while (ch != 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }








            Console.ReadKey();
        }
    }
}