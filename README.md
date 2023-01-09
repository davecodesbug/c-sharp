# Learning C#

Documenting important stuffs about C# so I can have something to fallback on whenever I need help... ✍

## Creating Projects

To create a new C# project via the CLI: 👉 `dotnet new console -o projectName`

## Printing to the console

Console.WriteLine or Console.Write for printing without break-inline

## Variables

Below are the data types we have in C# => 👇

* bool
* byte
* sbyte
* char
* decimal
* double	
* float	
* int
* uint	
* nint	
* nuint
* long
* ulong	
* short
* ushort
* object
* string
* dynamic

## Constants

Constants are immutable values that can't be altered or changed overtime Prefix variable with the keyword `const` to make it a constant.

## Type Casting

Type casting in C# is when a variable of type "A" is converted to type "B". For instance, let's say we have a variable of type `string` and we want to convert it to type `int`.

We can do something like: 👇

```c#
string num = "101";
int convNum = Convert.ToInt16(num);
```

## Arithmetic Operators

Arithmetic operators are used to compute mathematics calculations.

Arithmetic operators in C#: 👇

* Minus
* Plus
* Multiplications
* Divisions
* Remainders

## If/else Statements

A basic form of decision making based on a specified value. A basic `If/else` statement is written as follows: 👇

```c#
int age = 18;

if (age >= 18)
    {
    Console.WriteLine("You're an adult!");
    }
    else
    {
    Console.WriteLine("You're a kid!");
    }
```

## Switch Statements

Switch statement is an efficient and shorter to write alternative to nested `if/else` statements.

Let's write a simple switch statement to check the months in a year: 👇

```c#
Console.WriteLine("What month is it?");
string months = Console.ReadLine()!;

    switch (months)
        {
            case "January":
            Console.WriteLine("We're in " + months);
            break;
            case "February":
            Console.WriteLine("We're in " + months);
            break;
            case "March":
            Console.WriteLine("We're in " + months);
            break;
            case "April":
            Console.WriteLine("We're in " + months);
            break;
            case "May":
            Console.WriteLine("We're in " + months);
            break;
            case "June":
            Console.WriteLine("We're in " + months);
            break;
            case "July":
            Console.WriteLine("We're in " + months);
            break;
            case "August":
            Console.WriteLine("We're in " + months);
            break;
            case "September":
            Console.WriteLine("We're in " + months);
            break;
            case "October":
            Console.WriteLine("We're in " + months);
            break;
            case "November":
            Console.WriteLine("We're in " + months);
            break;
            case "December":
            Console.WriteLine("We're in " + months);
            break;
            default:
            Console.WriteLine(months + " Is not a month");
            break;

        }
```

## Logical Operators

Logical operators can be used to check whether one or more elements is `truthy` or `falsy`.

Logical operators in C#: 👇

* AND
* OR

## While Loops

A while loop is a block of code that will run based on if a passed in value is of `truthy` or `falsy` type. Example: 👇

```c#
while (true)
    {
        Console.WriteLine("Running while loops");
    }
```

The above code will continue to run infinitely until you stop it manually because of the passed in `truthy` type.

## For Loops

A for loop is just like a while loop, just that it's going to run for a finite amount of time.

Code sample: 👇

```c#
for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
    }
```

The above code will write to the console 10 times, starting from 0-9.

## Nested Loops

Nested loops are basically loops nested inside each other, this method is mostly used in sorting algorithms.

Below is a simple symbol sorting algorithm with nested loops: 👇

```c#
 Console.WriteLine("How many rows?: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many cols?: ");
int cols = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What symbol?: ");
char symbol = Convert.ToChar(Console.ReadLine()!);

for (int i = 0; i < rows; i++)
    {
    for (int j = 0; j < cols; j++)
        {
            Console.Write(symbol);
        }
    Console.WriteLine();
    }
```

This sorting algorithm will print the passed in symbol based on how many columns and rows is specified by the user.

## Arrays

Arrays are variable that can store multiple value of the same type only.

```c#
string[] sports = {"Football", "Tennis", "Badminton"};

for (int i = 0; i < sports.Length; i++)
    {
        Console.WriteLine(sports[i]);
    }
```

Above is a simple array of sports that is being looped over with a for loop.

## Foreach Loops

Foreach loops is a much more simpler way of iterating over an array, but it's less flexible than a for loop.

```c#
string[] sports = {"Football", "Tennis", "Badminton"};

foreach (string sport in sports)
    {
        Console.WriteLine(sport);
    }
```

This is going to print each value in our array to the console, same as for loop.

## Methods

A method/function performs a section of code whenever it's invoked. It makes a block of code reusable and keeps our code DRY.

Here is a simple method in charge of printing to the console: 👇

```c#
 static void Main(string[] args)
    {
        print();
    }
static void print(string language)
    {
        Console.WriteLine("Hello World from a Method!");
    }
```

The method is being invoked in our main method and it can be called many times to print the same string multiple times.

Here is another method with parameters passed in: 👇

```c#
 static void Main(string[] args)
    {
        string language = "C#";
        print(language);
    }
static void print(string language)
    {
        Console.WriteLine("Hello World from a Method in " + language + "!");
    }
```

Here is another method performing a simple maths with a `return` keyword: 👇

```c#
static void Main(string[] args)
    {
        Console.WriteLine("Enter number 1: ");
        int x = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter number 2: ");
        int y = Convert.ToInt16(Console.ReadLine());

        var result = print(x, y);
        Console.WriteLine(result);
    }
static int print(int x, int y)
    {
        return x + y;
    }
```

## Method Overloading

Method overloading in C# is when a method share the same name but have different parameters. Here is an example: 👇

```c#
 static void Main(string[] args)
    {
        Console.WriteLine("Enter number 1: ");
        int x = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter number 2: ");
        int y = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter number 3: ");
        int z = Convert.ToInt16(Console.ReadLine());

        var result = print(x, y, z);
        Console.WriteLine(result);
    }
static int print(int x, int y)
    {
        return x + y;
    }
static int print(int x, int y, int z)
    {
        return x + y + z;
    }
```

As you can see here, we have two method performing basic maths with the same name. On a norm, this would have caused an error in our program, but not causing error because of the different parameters passed in.