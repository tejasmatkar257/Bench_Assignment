using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate double ManagerSal(double _sal);
    public delegate double Food(double _Food);
    public delegate double Petrol(double _Petrol);
    public delegate double Others(double _Others);
    public delegate double Gross(double _Gross);
    public delegate double Pf(double Pf);
    public delegate double Netsal(double _Netsal);

    public class Manager
    {
        public double _Petrol;
        public double _Food;
        public double _Others;
        public double _sal;
        public double _Gross;
        public double _Netsal;
        public double Pf;
        public double TDS;

        public double ManagerSalary(double _sal)
        {
            return _sal;
        }
        public double FoodDetails(double Sal)
        {
            _Food = Sal * 0.13;
            return _Food;

        }
        public double PetrolDetails(double Sal)
        {
            _Petrol = Sal * 0.08;
            return _Petrol;
        }
        public double OtherDetails(double Sal)
        {
            _Others = Sal * 0.03;
            return _Others;

        }
        public double GrossSalaryDetails(double Sal)
        {
            _Gross = Sal + _Food + _Petrol + _Others;
            return _Gross;

        }
        public double PfDetails(double sal)
        {
            Pf = (_Gross * 0.10);
            return Pf;
        }
        public double CalculateSalaryDetails(double Sal)
        {
            Pf = (_Gross * 0.10);
            TDS = (_Gross * 0.18);
            _Netsal = _Gross - (Pf + TDS);
            return _Netsal;
        }
    }
    class program
    {

        public static void Main(string[] args)
        {
            Manager m = new Manager();
            ManagerSal ms = new ManagerSal(m.ManagerSalary);
            double Sal = ms(60000);
            Console.WriteLine("Manager salary :{0}", Sal);
            Food f = new Food(m.FoodDetails);
            double FoodCost = f(Sal);
            Console.WriteLine("Food Allowance :{0}", FoodCost);
            Petrol p = new Petrol(m.PetrolDetails);
            double PetrolCost = p(Sal);
            Console.WriteLine("Petrol Allowance :{0}", PetrolCost);
            Others o = new Others(m.OtherDetails);
            double OthersCost = o(Sal);
            Console.WriteLine("Other Allowance :{0}", OthersCost);
            Gross g = new Gross(m.GrossSalaryDetails);
            double GrossSalary = g(Sal);
            Console.WriteLine("Grosssalary :{0}", GrossSalary);
            Pf P = new Pf(m.PfDetails);
            double Pf = P(Sal);
            Console.WriteLine("Pf :{0}", Pf);

            Netsal n = new Netsal(m.CalculateSalaryDetails);
            double NetSalary = n(Sal);
            Console.WriteLine("Netsalary :{0}", NetSalary);
        }
    }
}