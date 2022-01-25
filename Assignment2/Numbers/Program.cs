// See https://aka.ms/new-console-template for more information


/*Code 
Explore Integer Math
*/

Console.WriteLine("Explore Integer Math");
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);
c = a - b;
Console.WriteLine(c);
c = a * b;
Console.WriteLine(c);
c = a / b;
Console.WriteLine(c);

/*Explore order of operation*/

Console.WriteLine("\nExplore order of operation");
a = 5;
b = 4;
c = 2;
int d = a + b * c;
Console.WriteLine(d);

d = (a + b) * c;
Console.WriteLine(d);

d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d);

d = (a + b) / c;
Console.WriteLine(d);

/*Explore Integer Precision and limits */
Console.WriteLine("\nExplore Integer Precision and limits");
a = 7;
b = 4;
c = 3;
d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

/*Range of int data type*/
int maxInt = int.MaxValue;
int minInt = int.MinValue;
Console.WriteLine($"The range of integers is {minInt} to {maxInt}");

/*Explame of Overflow*/
int what = maxInt + 3;
Console.WriteLine($"An example of overflow: {what}");


/*Working  with Double Type*/
Console.WriteLine("\nExample of double Data Type");
double x = 19;
double y = 23;
double z = 8;
double w = (x + y) / z;
Console.WriteLine($"w={w}");

double maxDouble = double.MaxValue;
double minDouble = double.MinValue;
Console.WriteLine($"The range of double is {minDouble} to {maxDouble}");

/*Working with Decimal Type*/
Console.WriteLine("\nWorking with Decimal DataType");
decimal minDecimal = decimal.MinValue;
decimal maxDecimal = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {minDecimal} to {maxDecimal}");

Console.WriteLine("\nComparing precision of data type DECIMAL AND DOUBLE");
x = 1.0;
y = 3.0;
Console.WriteLine($"Ans of 1/3 for double data type{x / y}");
decimal i = 1.0M;
decimal j = 3.0M;
Console.WriteLine($"Ans of 1/3 for decimal data type{i / j}");


Console.WriteLine("\nProgram For Calculating Area of Circle");
double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine($"Area of Circle With Radius= {radius} is {area}\n");