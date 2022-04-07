// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Text;

namespace App
{

    public class Program
    {
        public static bool compare<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) < 0;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("\nName :-Chaitanya Govind Nagdev");
            Console.WriteLine($"\nTime :- {DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt")}\n");

            Console.WriteLine("\n--------------------- GENERAL SORTING EXAMPLE ----------------------\n");

            List<int> intList = new List<int>(10);
            intList.Add(10);
            intList.Add(35);
            intList.Add(1000);
            intList.Add(76);
            intList.Add(-35);
            InsertionSorter.Sort<int>(intList, compare);
            Console.WriteLine("\nAFTER SORTING INT LIST - ");
            foreach (int i in intList)
            {
                Console.WriteLine(i);
            }

            List<string> stringList = new List<string>(10);
            stringList.Add("Vishvaraj");
            stringList.Add("Smit");
            stringList.Add("Yash");
            stringList.Add("Akash");
            stringList.Add("David");

            InsertionSorter.Sort<string>(stringList, compare);
            Console.WriteLine("\nAFTER SORTING STRING LIST - ");
            foreach (string s in stringList)
            {
                Console.WriteLine(s);
            }

            List<Employee> empList = new List<Employee>(30);
            empList.Add(new Employee(5, 60000, "Smit", Designations.CFO));
            empList.Add(new Employee(8, 140000, "Margav", Designations.CEO));
            empList.Add(new Employee(1, 80000, "Dhiren", Designations.SDE));
            empList.Add(new Employee(3, 50000, "Abhi", Designations.BA));
            empList.Add(new Employee(7, 100000, "Karan", Designations.PM));

            InsertionSorter.Sort<Employee>(empList, Employee.CompareDesignations);
            Console.WriteLine("\n\nAFTER COMPARING DESIGNATIONS - ");
            foreach (Employee e1 in empList)
            {
                Console.WriteLine($"{e1.name} - {e1.designation}");
            }

            InsertionSorter.Sort<Employee>(empList, Employee.CompareSalary);
            Console.WriteLine("\n\nAFTER COMPARING SALARIES - ");
            foreach (Employee e1 in empList)
            {
                Console.WriteLine($"{e1.name} - {e1.salary}");
            }

            InsertionSorter.Sort<Employee>(empList, Employee.CompareNames);
            Console.WriteLine("\n\nAFTER COMPARING NAMES - ");
            foreach (Employee e1 in empList)
            {
                Console.WriteLine(e1.name);
            }
        }
    }

    class InsertionSorter
    {
        static public void Sort<T>(IList<T> arr, Func<T, T, bool> compare)
        {
            for (int i = 1; i < arr.Count; i++)
            {
                int currentElement = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (compare(arr[currentElement], arr[j]))
                    {
                        T temp = arr[currentElement];
                        arr[currentElement] = arr[j];
                        arr[j] = temp;
                        currentElement = j;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }

    public enum Designations
    {
        CEO = 5,
        CFO = 4,
        SDE = 2,
        BA = 1,
        PM = 3
    }

    class Employee
    {
        int empid;
        public float salary;
        public string name;
        public Designations designation;

        public Employee(int EmpId, float Salary, string Name, Designations design)
        {
            this.empid = EmpId;
            this.salary = Salary;
            this.name = Name;
            this.designation = design;
        }

        internal static bool CompareSalary(Employee e1, Employee e2)
        {
            return e1.salary < e2.salary;
        }

        internal static bool CompareNames(Employee e1, Employee e2)
        {
            return e1.name.CompareTo(e2.name) < 0;
        }

        internal static bool CompareDesignations(Employee e1, Employee e2)
        {
            return e1.designation < e2.designation;
        }
    }

}