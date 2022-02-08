
using System;
using System.Reflection;


public class EmployeeTest
{
    static void Main()
    {

        Employee E1 = new Employee("Raj", "Jhadav", 55000);
        Employee E2 = new Employee("Mihir", "Agarwal", 62000);

        Console.WriteLine("\nBefore Raise");
        Console.WriteLine(E1);
        Console.WriteLine(E2);
        E1.getRaise(10);
        E2.getRaise(10);
        Console.WriteLine("\nAfter Raise");
        Console.WriteLine(E1);
        Console.WriteLine(E2);

        Console.WriteLine("\n------------Permanent Employees--------");

        PermanentEmployee PE1 = new PermanentEmployee("Smit", "Shah", 40000, 15000, 1000, 2000, "01-2-2022", "01-2-2023");
        PermanentEmployee PE2 = new PermanentEmployee("Bhavin", "Sheth", 50000, 13000, 1500, 1000, "01-5-2022", "01-1-2023");

        Console.WriteLine("\nBefore Raise");
        Console.WriteLine(PE1);
        Console.WriteLine(PE2);
        PE1.getRaise(10);
        PE2.getRaise(10);
        Console.WriteLine("\nAfter Raise");
        Console.WriteLine(PE1);
        Console.WriteLine(PE2);


    }
}
public class Employee
{
    protected string firstName;
    protected string lastName;
    protected double mSalary;

    public Employee(string first, string last, double salary)
    {
        firstName = first;
        lastName = last;
        mSalary = salary;
    }

    public string FirstName
    {
        get => firstName;
        set => firstName = value;
    }

    public string LastName
    {
        get => LastName;
        set => LastName = value;
    }
    public double Salary
    {
        get => mSalary;
        set => mSalary = value < 0 ? 0.0 : value;
    }
    public virtual void getRaise(double percentage)
    {
        mSalary += (percentage / 100) * mSalary;
    }
    public override string ToString()
    {
        return "Employee: " + firstName + " " + lastName + " Montly Salary: " + mSalary;
    }
}
public class PermanentEmployee : Employee
{
    private string joiningDate;
    private string retirementDate;
    private double hra;
    private double da;
    private double pf;
    public PermanentEmployee(string first, string last, double salary, double HRA, double DA, double PF, string jDate, string rDate) : base(first, last, salary)
    {
        hra = HRA;
        da = DA;
        pf = PF;
        this.joiningDate = jDate;
        this.retirementDate = rDate;
    }
    public double Hra
    {
        get => hra;
    }
    public double Da
    {
        get => da;
    }
    public double Pf
    {
        get => pf;
    }
    public string JoiningDate
    {
        get => joiningDate;
        set => joiningDate = value;
    }
    public string RetirementDate
    {
        get => retirementDate;
        set => retirementDate = value;
    }
    public override void getRaise(double percentage)
    {
        mSalary = mSalary + ((mSalary * percentage) / 100) + hra + da;
    }
    public override string ToString()
    {
        return "Permanent Employee: " + firstName + " " + lastName + " Monthly Salary: " + mSalary + " Joining Date: " + joiningDate + " Retirement Date: " + retirementDate;
    }
}






