# Learning C#

Documenting important stuffs about C# so I can have something to fallback on whenever I need help... ✍

## Printing to the console

Console.WriteLine or Console.Write for printing without break-inline

## Variables

Below are the data types we have in C# => 👇

* bool
* byt
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