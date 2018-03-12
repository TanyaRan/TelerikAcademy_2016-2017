# Homework: Using Classes and Objects

# 01. Leap year

## Description
Write a program that reads a year from the console and checks whether it is a leap one.

_Hint:_ Use `System.DateTime`.

## Input
- On the only line you will receive a number - the year

## Output
- Print "Leap" or "Common" on a single line depending on the year

## Constraints
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| 2016  | Leap   |
| 1996  | Leap   |
| 1900  | Common |
| 2000  | Leap   |
|  681  | Common |
| 3400  | Common |

# 02. Random numbers

## Description
Write a program that generates and prints to the console `10` random values in the range [`100, 200`].

# 03. # Day of week

## Description
Write a program that prints to the console which day of the week is today.
Use `System.DateTime`.

# 04. Triangle surface by side and altitude

## Description
Write program that calculates the surface of a triangle by given a side and an altitude to it.

## Input
- On the first line you will receive the length of a side of the triangle
- On the second line you will receive the altitude to that side

## Output
- Print the surface of the rectangle with two digits of precision

## Constraints
- Input data describes a valid triangle
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input     | Output |
|:----------|:-------|
| 23.2<br>5 | 58.00  |

# 05. Triangle surface by three sides

## Description
Write program that calculates the surface of a triangle by given its three sides.

## Input
- On the first line you will receive the length of the first side of the triangle
- On the second line you will receive the length of the second side of the triangle
- On the third line you will receive the length of the third side of the triangle

## Output
- Print the surface of the rectangle with two digits of precision

## Constraints
- Input data describes a valid triangle
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input          | Output |
|:---------------|:-------|
| 11<br>12<br>13 | 61.48  |

# 06. Triangle surface by two sides and an angle

## Description
Write program that calculates the surface of a triangle by given two sides and an angle between them.

## Input
- On the first line you will receive the length of the first side of the triangle
- On the second line you will receive the length of the second side of the triangle
- On the third line you will receive the angle between the given sides
  - Angle is given in degrees

## Output
- Print the surface of the rectangle with two digits of precision

## Constraints
- Input data describes a valid triangle
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input         | Output |
|:--------------|:------:|
| 10<br>7<br>25 | 14.79  |

# 07. Workdays

## Description
Write a method that calculates the number of workdays between today and a given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

# 08. Sum integers

## Description
You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
Write a program that reads a string of positive integers separated by spaces and prints their sum.

## Input
- On the only line you will receive a string consisted of positive integers

## Output
- Print the sum of the integers

## Constraints
- Each number will be in the interval `[ 1, 1000 ]`
- There will not be more than 1000 numbers
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input          | Output |
|:---------------|:-------|
| 43 68 9 23 318 | 461    |

# 09. Arithmetical expressions

## Description
Write a program that calculates the value of given arithmetical expression.

The expression can contain the following elements only:
- Real numbers, e.g. `5`, `18.33`, `3.14159`, `12.6`
- Arithmetic operators: `+`, `-`, `*`, `/` (standard priorities)
- Mathematical functions: `ln(x)`, `sqrt(x)`, `pow(x,y)`
- Brackets (for changing the default priorities): `(`, `)`

## Input
- On the only line you will receive an expression

## Output
- Print the result of the expression

## Constraints
- The size of the expression will not be more than 10000 symbols
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input                                              | Output |
|:---------------------------------------------------|:-------|
| (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)            | ~10.6  |
| pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3) | ~21.22 |

_Hint: Use the classical [Shunting-yard algorithm](http://en.wikipedia.org/wiki/Shunting-yard_algorithm) and [Reverse Polish notation](http://en.wikipedia.org/wiki/Reverse_Polish_notation)._