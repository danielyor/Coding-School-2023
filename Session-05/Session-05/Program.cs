using Exercise01;
using Exercise02;
using Exercise03;
using Exercise04;
using Exercise05;

Console.WriteLine("Exercises for Session 05.");

// 1. Write a C# program that reverses a given string (ex. your name).
Console.WriteLine("1. Input a string to be reversed:");
string str1 = Console.ReadLine();

StrReverser strRev = new();

Console.WriteLine($"Reverse String is: {strRev.Reverse(str1)}");

// 2. Write a C# program that asks the user for an integer and gives them the possibility to choose between computing the sum and computing the product of 1,..., n
// TODO: input validation
Console.WriteLine("2. Input a number to perform a computation:");
string str2 = Console.ReadLine();
int n;

while (!int.TryParse(str2, out n))
{
    Console.WriteLine("Possible formatting error. Retry inputting a number:");
    str2 = Console.ReadLine();
}

Console.WriteLine("Compute sum or product of 1, ..., n? Select [1] for sum, [2] for product");
str2 = Console.ReadLine();

int.TryParse(str2, out int selection);

SumOrProduct sumOrProd = new();

if (selection == 1)
{
    Console.WriteLine($"Sum is: {sumOrProd.Sum(n)}");
}
else if (selection == 2)
{
    Console.WriteLine($"Product is: {sumOrProd.Product(n)}");
}

// 3. Write a C# program that asks the user for an integer (n) and finds all the prime numbers from 1 to n
// TODO: Return prime list to main, prettify printing
Console.WriteLine("3. Input a number to find all prime numbers from 1 to n:");
string str3 = Console.ReadLine();
int n3;

while (!int.TryParse(str3, out n3))
{
    Console.WriteLine("Possible formatting error. Retry inputting a number:");
    str3 = Console.ReadLine();
}

PrimeFinder primes = new();
primes.FindPrimes(n3);

// 4. Write a C# program to multiply all values from Array1 with all values from Array2 and display the results in a new Array.
// TODO: Return array to main, implement printing method inside class
Console.WriteLine("4. Array multiplication. Result:");
int[] arr1 = { 2, 4, 9, 12 };
int[] arr2 = { 1, 3, 7, 10 };

ArrayMultiplier arrMul = new();
arrMul.MultiplyArrays(arr1, arr2);

// 5. Write a C# program to sort the given array of integers from the lowest to the highest number.
// TODO: Return array to main, implement printing method inside class
Console.WriteLine("5. Sort a given array in ascending order. Result:");
int[] arrUnsorted = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

ArraySorter arrSort = new();
arrSort.BubbleSort(arrUnsorted);



Console.ReadKey(); 