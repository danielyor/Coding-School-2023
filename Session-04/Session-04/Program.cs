// 1) Write a C# program to print Hello and your name in the same line.
string name = "Daniel";
Console.WriteLine("1) Hello " + name + "!");

// 2) Write a C# program to print the sum of two numbers and the division of those two numbers.
float a = 13;
float b = 5;
Console.WriteLine("2) Your numbers are: " + a + " and " + b);
Console.WriteLine("Their sum is: " + (a + b));
Console.WriteLine("Their division is: " + (a / b));

// 3) Write a C# program to print the result of specified math operations:
Console.WriteLine("3) Results:");
Console.WriteLine( -1+(5*6) );
Console.WriteLine( 38+(5%7) );
Console.WriteLine( 14+((-3*6)/7f) );
Console.WriteLine( 2+13/6f*6+Math.Sqrt(7) );
Console.WriteLine( (Math.Pow(6, 4)+Math.Pow(5, 7))/(float)(9%4) );

// 4) Write a C# program that assigns an age and a gender and displays something like: "You are female and look younger than 20."
int age = 25;
string gender = "male";
Console.WriteLine("4) You are " + gender + " and look younger than " + age + ".");

// 5) Write a C# program that takes an integer representing seconds and converts it to: Minutes, Hours, Days, Years
int seconds = 9001;
float minutes = (float) seconds / 60;
float hours = minutes / 60;
float days = hours / 24;
double years = days / 364;
Console.WriteLine("5) Basic operations:");
Console.WriteLine(seconds + " seconds are " + minutes + " minutes, " + hours + " hours, " + days + " days, or " + years + " years.");

// 6) Rewrite Program #5 using .Net Libraries.
TimeSpan time = TimeSpan.FromSeconds(9001);
Console.WriteLine("6) TimeSpan struct operations:");
Console.WriteLine(time.TotalSeconds + " seconds are " + time.TotalMinutes + " minutes, " + time.TotalHours + " hours, " + time.TotalDays + " days, or " + time.TotalDays/365 + " years.");

// 7) Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
float celsius = 30;
float fahrenheit = (celsius * 9/5) + 32;
float kelvin = celsius + 273.15f;
Console.WriteLine("7) Temperature conversions:");
Console.WriteLine("Celsius: " + celsius);
Console.WriteLine("Fahrenheit: " + fahrenheit);
Console.WriteLine("Kelvin: " + kelvin);


Console.ReadKey();
