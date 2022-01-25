// See https://aka.ms/new-console-template for more information
int a, b, ans;

Console.WriteLine("\nExample of If Statement");
a = 5;
b = 6;
ans = a + b;
Console.WriteLine($"a={a},b={b},ans={a + b}");
if (ans > 10)
    Console.WriteLine("The ans is greater than 10.");


Console.WriteLine("\nExample of if else statement");
a = 5;
b = 3;
ans = a + b;
Console.WriteLine($"a={a},b={b},ans={a + b}");
if (ans > 10)
    Console.WriteLine("The ans is greater than 10.");
else
    Console.WriteLine("The ans is less than 10.");

Console.WriteLine("\nLOOPS");
Console.WriteLine("\nExample of While Loop");
int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Counter using while loop is {counter}");
    counter++;
}


Console.WriteLine("\nExample of DO While Loop");
counter = 0;
do
{
    Console.WriteLine($"Counter using do while loop is {counter}");
    counter++;
} while (counter < 10);

Console.WriteLine("\nExample of For Loop");
for (int i = 0; i < 10; i++)
{

    Console.WriteLine($"Counter  using for loop is {i}");
}

Console.WriteLine("\n Making Matrix Using Nested Loops");
for (int row = 1; row < 4; row++)
{
    for (char column = 'a'; column < 'd'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}

Console.WriteLine("\nProgram to find sum of integer 1 to 20 which are divisible by 3");
int sum = 0;
for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0)
        sum += i;
}
Console.WriteLine($"The Sum is {sum}");
