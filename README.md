# Learning C#

Documenting important stuffs about C# so I can have something to fallback on whenever I need help... ✍

# Table of Contents 📝
1. [Creating Projects](#creating-projects)
2. [Printing to the console](#printing-to-the-console)
3. [Variables](#variables)
4. [Constants](#constants)
5. [Type Casting](#type-casting)
6. [Arithmetic Operators](#arithmetic-operators)
7. [If/else Statements](#ifelse-statements)
8. [Switch Statements](#switch-statements)
9. [Logical Operators](#logical-operators)
10. [While Loops](#while-loops)
11. [For Loops](#for-loops)
12. [Nested Loops](#nested-loops)
13. [Arrays](#arrays)
14. [Foreach Loops](#foreach-loops)
15. [Methods](#methods)
16. [Method Overloading](#method-overloading)
17. [The Params Keyword](#the-params-keyword)
18. [Exception Handling](#exception-handling)
19. [Conditional Operator](#conditional-operator)
20. [String Interpolation](#string-interpolation)
21. [OOP TOPICS](#oop-topics)
22. [Class](#class)
23. [Objects](#objects)
24. [Constructors](#constructors)
25. [Static Keyword](#static-keyword)
26. [Constructor Overloading](#constructor-overloading)
27. [Class Inheritance](#class-inheritance)
28. [Abstract Class](#abstract-class)
29. [Array of Object](#array-of-object)
30. [Objects as Arguments](#objects-as-arguments)
31. [Class Method Overriding](#class-method-overriding)

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

## The Params Keyword

The params keyword can allow a method parameter take an array of value. It can be used to keep the code DRY instead of using `method overloading`. Here is the params keyword in action: 👇

```c#
 static void Main(string[] args)
    {
        double sum = SumPrice(100, 50, 60, 24, 99, 2);
        Console.WriteLine(sum);

    }
static int SumPrice(params int[] prices)
    {
        int total = 0;
        foreach (int price in prices)
        {
            total += price;
        }
        return total;
    }
```

## Exception Handling

Handling errors that might happen during code execution. A simple exception handling is written as follows: 👇

```c#
try 
    {
        Console.WriteLine("Enter number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int total = num1 + num2;
        Console.WriteLine(total);
    }
catch (FormatException err)
    {
        Console.WriteLine("You can only enter integers!", err);
    }
```

When running the above code, if you enter a string instead of an integer, the console will print the error message written instead of just stopping the program abruptly.

## Conditional Operator

Used to conditionally assign a value to a variable. It's a shorter way of writting an `if/else` statement. Written as follows: 👇

```c#
int age = 15;
string notice;

notice = (age >= 18) ? "You're an adult!" : "You're a KID!";
Console.WriteLine(notice);
```

If the `age` variable value is greater than or equals 18, it will print `You're an adult!` else `You're a KID`.

## String Interpolation

String interpolation is a cleaner way of conjoining one or more variables together. A simple string interpolation is as follows: 👇

```c#
string name = "Dave";
Console.WriteLine($"Hello, {name}");
```

# OOP TOPICS

Here is where OOP (Object Oriented Programming) topics documentation startes.

## Class

A class is a bundle of code that are related to each other, usually used to as a blueprint to create an object in OOP.

Creating and using a basic C# class is as follows: 👇

```c#
class Cycle
    {
        public static void greet()
        {
            Console.WriteLine("Starting code...");
        }

        public static void running()
        {
            Console.WriteLine("The code is now running...");
        }

        public static void end()
        {
            Console.WriteLine("Stopping code session...");
        }
    }
```

Then it can be used in our `Main` code function like so: 👇

```c#
Cycle.greet();
Cycle.running();
Cycle.end();
```

## Objects

Objects is an instance of a class that can have methods & fields (characteristics & actions). To demonstrate, here is an `Human` class: 👇

```c#
class Human
    {
        public string? name;
        public int age;
        public void walk()
        {
            Console.WriteLine($"{name} is walking 🚶‍♂️");
        }

        public void sit()
        {
            Console.WriteLine($"{name} is sitting 🪑");
        }

        public void birthDate()
        {
            Console.WriteLine($"{name} is {age}yrs old 🎂");
        }
    }
```

Then, we can place the instance of this `Human` class in a variable for use: 👇

```c#
Human human1 = new Human();
human1.name = "Dave";
human1.age = 23;
human1.walk();
human1.sit();
human1.birthDate();
```

## Constructors

A special method used to pass in arguments to fields when creating an object. Sample: 👇

In our class of `Human`:

```c#
 class Human
    {
        // You can remove the `public` keyword as we are not going to access these vars outside of there class
        string? name;
        int age;

        // Here is a constructor
        // Must be the same name as our class name
        public Human(string name, int age)
        {
            // To access the outer variables, use the `this` keyword
            this.name = name;
            this.age = age;
        }
        // Constructor ends here!
        public void walk()
        {
            Console.WriteLine($"{name} is walking 🚶‍♂️");
        }

        public void sit()
        {
            Console.WriteLine($"{name} is sitting 🪑");
        }

        public void birthDate()
        {
            Console.WriteLine($"{name} is {age}yrs old 🎂");
        }
    }
```

Then pass in the values when assigning the `Human` instance to a variable like so: 👇

```c#
Human human1 = new Human("Dave", 23);
```

## Static Keyword

The `static` keyword is used to declare a static member belonging to a class as a whole, and not to one specific object of a class. For instance, let's create a class of `Person`: 👇

```c#
class Person
    {
        string name;

        public Person(string name)
        {
            this.name = name;
        }
    }
```
Now, if there is a scenario where we want to keep track of how many object is created with this class, we can do: 👇

```c#
class Person
    {
        string name;
        public static int numOfObject;

        public Person(string name)
        {
            this.name = name;
            numOfObject++;
        }
    }
```

Refer to it in our code like: 👇

```c#
Person person1 = new Person("Dave");
Person person2 = new Person("Wexford");
Person person3 = new Person("Adewale");
// If it's static, it belongs to the class itself and not a specific object
Console.WriteLine(Person.numOfObject);
```
This is going to print `3` to the console, as we have created 3 object from the class. Had it been we haven't prefixed the `numOfObject` variable with the `static` keyword, this will only print `1` three times to the console.

## Constructor Overloading

Just like `method overloading`, constructor overloading is when we have multiple constructor with the same name but different parameters. Check `method overloading` to see code samples.

## Class Inheritance

Class inheritance is when a child class inherits fields & methods from a parent class. Sample code: 👇

```c#
class Animal
    {
        public string? type;
    }

class Pet : Animal
    {
        public void printType()
        {
            Console.WriteLine($"Pet type is: {type}");
        }
    }
```

We created a class of `Animal` with a public `type` variable. This got inherited by the class of `Pet` below it, this new class has now gained access to the variable of `type` even though it's not declared in it.

We can use it in our `Main` method like so: 👇

```c#
Pet pet = new Pet();

pet.type = "Cat";
pet.printType();
```

We assigned a type to the variable and called our method of `printType` so we can see it get printed to the console.

## Abstract Class

Abstract class is an incomplete implementation or a class with missing components. The `abstract` keyword will make sure people don't instantiate an object of this abstract class as it's incomplete. Sample 👉: `abstract class Animal(){}`.

## Array of Object

An array of object is just like a normal array, but containing a class object value. Example: 👇

```c#
// Main method
static void Main(string[] args)
{
    // Initialize an array of object
    Animal[] den = new Animal[3];

    // Object instance
    Animal animal1 = new Animal("Dog");
    Animal animal2 = new Animal("Cat");
    Animal animal3 = new Animal("Iguana");

    // Assign the array an object value
    den[0] = animal1;
    den[1] = animal2;
    den[2] = animal3;

    // Loop and print each object value to the console
    foreach (Animal animal in den)
    {
        Console.WriteLine(animal.type);
    }
}
// A class of Animal
class Animal
{
    public string? type;

    public Animal(string type)
    {
        this.type = type;
    }
}
```

## Objects as Arguments

Passing a class object as an argument to a method. Visual: 👇

```c#
 static void Main(string[] args)
{
    Car car = new Car("Toyota", "red");
    // Calling the method and passing in the instantiated car object alongside the color string
    Color(car, "yellow");
    // This will print the car make `Toyota` and the car color `yellow`
    Console.WriteLine($"Car make is: {car.make} & Car color is {car.color}");
}

// A method receiving the `Car` object as argument and another argument of color passed in
public static void Color(Car car, string color)
{
    // Setting the object `color` field as the string of color
    car.color = color;
}
    
// A class of Car with public make and color
class Car
{
    public string make;
    public string color;

    public Car(string make, string color)
    {
        this.make = make;
        this.color = color;
    }
}
```

## Class Method Overriding

Class method overriding is when an `abstract` class method which have been inherited by another class gets customized to fit the specific class calling it. Here's how it's done: 👇

```c#
// Base or Abstract class
abstract class Vehicle
{
    // Add the `virtual` keyword so the method can be overriden
    public virtual void wheels()
    {
        Console.WriteLine("Vehicle has 4 wheels");
    }
}

class Unicycle : Vehicle
{
    // Add the `override` keyword to customize the base class method
    public override void wheels()
    {
        Console.WriteLine("Unicycle has 1 giant wheel");
    }
}

class Bike : Vehicle
{
    public override void wheels()
    {
        Console.WriteLine("Bike has 2 wheels");
    }
}
```

Now, we can call the two class like so: 👇

```c#
Unicycle unicycle = new Unicycle();
unicycle.wheels();

Bike bike = new Bike();
bike.wheels();
```

## ToString Method

