# Learning C#

Documenting important stuffs about C# so I can have something to fallback on whenever I need help... ✍

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