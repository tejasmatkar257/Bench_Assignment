using System;
using System.Collections.Generic;
using System.Collections;

namespace GenericApp
{
    public class Employeee<T>
    {
        // define an Array of Generic type with length 4
        T[] obj = new T[4];
        int count = 0;
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        // adding items mechanism into generic type
        public void Add(T item)
        {
            //checking length
            if (count + 1 < 5)
            {
                obj[count] = item;

            }
            count++;
            Console.WriteLine("No of employees" + count);
        }

        //indexer for foreach statement iteration
        public T this[int index]
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }
    }
    class Employeee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
        static void Main(string[] args)
        {

            Employeee sOne = new Employeee()
            {
                EmpId = 101,
                EmpName = "Vijji",
                Gender = "Female",
                Salary = 450.55
            };

            Employeee sTwo = new Employeee()
            {
                EmpId = 102,
                EmpName = "Priyanka",
                Gender = "Male",
                Salary = 341
            };

            Employeee sThree = new Employeee()
            {
                EmpId = 103,
                EmpName = "Sharu",
                Gender = "Female",
                Salary = 750.32
            };

            Employeee sFour = new Employeee()
            {
                EmpId = 104,
                EmpName = "Sakshi",
                Gender = "Male",
                Salary = 612
            };


            List<Employeee> EmployeeList = new List<Employeee>();
            EmployeeList.Add(sOne);
            EmployeeList.Add(sTwo);
            EmployeeList.Add(sThree);
            EmployeeList.Add(sFour);


            Employeee s = EmployeeList[0];
            Employeee s1 = EmployeeList[1];
            Employeee s2 = EmployeeList[2];
            Employeee s3 = EmployeeList[3];



            Console.WriteLine("EmpId is {0}, EmpName is {1}, Emp Gender is {2}, EmpSalary is {3}", s.EmpId, s.EmpName, s.Gender, s.Salary);
            Console.WriteLine("EmpId is {0}, EmpName is {1}, Emp Gender is {2}, EmpSalary is {3}", s1.EmpId, s1.EmpName, s1.Gender, s1.Salary);
            Console.WriteLine("EmpId is {0}, EmpName is {1}, Emp Gender is {2}, EmpSalary is {3}", s2.EmpId, s2.EmpName, s2.Gender, s2.Salary);
            Console.WriteLine("EmpId is {0}, EmpName is {1}, Emp Gender is {2}, EmpSalary is {3}", s3.EmpId, s3.EmpName, s3.Gender, s3.Salary);

            Console.WriteLine(s.EmpName);
            Console.WriteLine(s1.EmpName);
            Console.WriteLine(s2.EmpName);
            Console.WriteLine(s3.EmpName);
            Console.WriteLine(EmployeeList.Count);
            int index = EmployeeList.FindIndex(x => x.EmpName != "Black Window");

            Console.WriteLine(index);


            Console.ReadKey();
        }
    }
}