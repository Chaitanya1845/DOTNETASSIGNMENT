using System;
namespace Delegates
{
    class BankCustomer
    {
        public int aNumber;
        public string aName;
        public double bankBalance;
        public BankCustomer(int acno, string aName, double bb)
        {
            this.aNumber = acno;
            this.aName = aName;
            this.bankBalance = bb;
        }
    }
    public delegate void balanceChecker(double n);
    class Program
    {
        //method for delegate
        public static void checkBalance(double bal)
        {
            if (bal < 0)
            {
                Console.Write("You are overdrawn");
            }
            else if (bal < 10)
            {
                Console.Write("Your account balance is very low !");
            }
            else if (bal < 100)
            {
                Console.Write("Watch your spending carefully.");
            }
            else
            {
                Console.Write("You have over $100 in your account.");
            }
        }
        static void Main()
        {
            //instanciate delegate
            balanceChecker checker = checkBalance;
            BankCustomer b1 = new BankCustomer(100, "AXB", -3);
            Console.Write($"\nHello ,{b1.aName} : ");
            checker(b1.bankBalance);
            Console.WriteLine($" (Account balance = ${b1.bankBalance})");

            BankCustomer b2 = new BankCustomer(101, "XAY", 5.5);
            Console.Write($"\nHello ,{b2.aName} : ");
            checker(b2.bankBalance);
            Console.WriteLine($" (Account balance = ${b2.bankBalance})");

            BankCustomer b3 = new BankCustomer(102, "PAQ", 75.7);
            Console.Write($"\nHello ,{b3.aName} : ");
            checker(b3.bankBalance);
            Console.WriteLine($" (Account balance = ${b3.bankBalance})");

            BankCustomer b4 = new BankCustomer(103, "BRVZ", 700);
            Console.Write($"\nHello ,{b4.aName} : ");
            checker(b4.bankBalance);
            Console.WriteLine($" (Account balance = ${b4.bankBalance})");
        }
    }
}
