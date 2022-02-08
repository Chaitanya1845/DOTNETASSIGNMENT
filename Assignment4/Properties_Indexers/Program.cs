
using System;
using System.Globalization;


namespace Lab4Examples
{
    class Examples
    {

        static void Main()
        {

            Console.WriteLine("\nProperties\n");
            var person = new Person("Chaitanya", "Nagdev");
            Console.WriteLine($"name:{person.Name}  Time:{DateTime.Now.ToString("HH:mm:ss tt")}");

            var item = new SaleItem("Shoes", 19.95m);
            Console.WriteLine($"{item.Name}: sells for {item.Price}");

            var item2 = new SaleItem2 { Name = "Purse", Price = 20.95m };
            Console.WriteLine($"{item2.Name}: sells for {item2.Price}");

            Console.WriteLine("\nIndexers\n");

            Console.WriteLine("Example 1\n");
            var tempRecord = new TempRecord();


            tempRecord[3] = 58.3F;
            tempRecord[4] = 60.1F;


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Element #{i} = {tempRecord[i]}");
            }
            Console.WriteLine("\nExample2\n");

            var week = new DayCollection();
            Console.WriteLine($"Index of Friday is {week["Fri"]}");

            try
            {
                Console.WriteLine(week["Made-up day"]);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Not supported input: {e.Message}");
            }
        }

    }

    public class Person
    {
        private string firstName;
        private string lastName;
        public Person(string first, string last)
        {
            firstName = first;
            lastName = last;
        }

        public string Name => $"{firstName} {lastName}";

    }
    public class SaleItem
    {
        string _name;
        decimal _cost;

        public SaleItem(string name, decimal cost)
        {
            _name = name;
            _cost = cost;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public decimal Price
        {
            get => _cost;
            set => _cost = value;
        }
    }
    public class SaleItem2
    {
        public string Name
        { get; set; }

        public decimal Price
        { get; set; }
    }

    //INDEXERS 
    public class TempRecord
    {
        float[] temps = new float[5]
        {
        56.2F, 56.7F, 56.5F, 56.9F, 58.8F
        };


        public int Length => temps.Length;

        public float this[int index]
        {
            get => temps[index];
            set => temps[index] = value;
        }
    }
    class DayCollection
    {
        string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };

        public int this[string day] => FindDayIndex(day);

        private int FindDayIndex(string day)
        {
            for (int j = 0; j < days.Length; j++)
            {
                if (days[j] == day)
                {
                    return j;
                }
            }

            throw new ArgumentOutOfRangeException(
                nameof(day),
                $"Day {day} is not supported.\nDay input must be in the form \"Sun\", \"Mon\", etc");
        }
    }

}