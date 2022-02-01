using System;

namespace Assignment3
{
    [Flags]
    public enum Days

    {

        None = 0b_0000_0000, // 0

        Monday = 0b_0000_0001, // 1

        Tuesday = 0b_0000_0010, // 2

        Wednesday = 0b_0000_0100, // 4

        Thursday = 0b_0000_1000, // 8

        Friday = 0b_0001_0000, // 16

        Saturday = 0b_0010_0000, // 32

        Sunday = 0b_0100_0000, // 64
        Weekend = Saturday | Sunday
    }
    class DoTheMath
    {

        static void Main()
        {

            problem1();
            problem2();
            problem3();
        }
        public static void problem1()
        {
            Console.WriteLine("\nQuestion 1\n");
            int numerator, denominator;
            Console.Write("Please enter the numerator?");
            numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the denominator?");
            denominator = Convert.ToInt32(Console.ReadLine());


            int intResult = numerator / denominator;
            int remainder = numerator % denominator;
            Console.WriteLine($"Integer division result = {intResult} with remainder {remainder}");

            double floatResult = (double)numerator / denominator;
            Console.WriteLine($"Floating point division result = {floatResult}");
            Console.WriteLine($"The result as mixed fraction is {intResult} {remainder}/{denominator}");

        }
        public static void problem2()
        {
            Console.WriteLine("\nQuestion 2\n");
            stringLength();
            sentanceType();
            fullName();
        }

        public static void problem3()
        {

            Console.WriteLine("\nQuestion 3\n");
            Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;

            Console.WriteLine(meetingDays);
            Days workingFromHomeDays = Days.Thursday | Days.Friday;

            Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");
            bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;

            Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");
            var a = (Days)37;
            Console.WriteLine(a);
        }
        public static void stringLength()
        {
            Console.Write("Enter string?");
            string? str = Console.ReadLine();
            if (str != null)
            {
                int length = str.Length;
                Console.WriteLine($"Length of string {str} is {length} ");
            }

        }
        public static void sentanceType()
        {
            Console.Write("Enter string?");
            string? str = Console.ReadLine();
            if (str != null)
            {
                if (str.EndsWith("."))
                {
                    Console.WriteLine("String is declarative sentence");
                }
                else if (str.EndsWith("?"))
                {

                    Console.WriteLine("String is interrogatory sentence");
                }
                else if (str.EndsWith("!"))
                {

                    Console.WriteLine("String is exclamation sentence");
                }
                else
                {

                    Console.WriteLine("String is not a sentence");
                }
            }
        }
        public static void fullName()
        {
            Console.Write("Enter Full Name?");
            string? name = Console.ReadLine();
            if (name != null)
            {
                if (name.Contains(" "))
                {
                    string[] str = name.Split(' ');
                    Console.WriteLine($"{str[1]}, {str[0]}");
                }
                else
                {
                    Console.WriteLine($"{name}");
                }
            }

        }
    }

}