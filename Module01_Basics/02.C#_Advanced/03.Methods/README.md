# Homework: Methods

# 01. Say Hello

## Description
Write a method that asks the user for his name and prints `Hello, <name>!`.
Write a program to test this method.

## Input
- On the first line you will receive a name

## Output
- Print `Hello, <name>!`

## Constraints
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output        |
|:------|:--------------|
| Peter | Hello, Peter! |

# 02. Get largest number

## Description
Write a method `GetMax()` with two parameters that returns the larger of two integers.
Write a program that reads `3` integers from the console and prints the largest of them using the method `GetMax()`.

## Input
- On the first line you will receive `3` integers separated by spaces

## Output
- Print the largest of them

## Constraints
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input   | Output |
|:--------|:-------|
| 8 3 6   | 8      |
| 7 19 19 | 19     |

# 03. English digit

## Description
Write a method that returns the last digit of given integer as an English word.
Write a program that reads a number and prints the result of the method.

## Input
- On the first line you will receive a number

## Output
- Print the last digit of the number as an English word

## Constraints
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input  | Output |
|:-------|:-------|
| 42     | two    |

# 04. Appearance count

## Description
Write a method that counts how many times given number appears in a given array.
Write a test program to check if the method is working correctly.

## Input
- On the first line you will receive a number **N** - the size of the array
- On the second line you will receive **N** numbers separated by spaces - the numbers in the array
- On the third line you will receive a number **X**

## Output
- Print how many times the number **X** appears in the array

## Constraints
- 1 <= **N** <= 1024
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| 8<br>28 6 21 6 -7856 73 73 -56<br>73 | 2 |

# 05. Larger than neighbours

## Description
Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
Write program that reads an array of numbers and prints how many of them are larger than their neighbours.

## Input
- On the first line you will receive the number **N** - the size of the array
- On the second line you will receive **N** numbers separated by spaces - the array

## Output
- Print how many numbers in the array are larger than their neighbours

## Constraints
- 1 <= **N** <= 1024
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| 6<br>-26 **-25** -28 **31** 2 27 | 2 |

# 06. First larger than neighbours

## Description
Write a method that returns the index of the first element in array that is larger than its neighbours, or `-1`, if there is no such element.

## Input
- On the first line you will receive the number **N** - the size of the array
- On the second line you will receive **N** numbers sepated by spaces - the array

## Output
- Print the index of the first element that is larger than its neighbours or `-1` if none are

## Constraints
- 1 <= **N** <= 1024
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| 6<br>-26 **-25** -28 **31** 2 27 | 1 |

# 07. Reverse number

## Description
Write a method that reverses the digits of a given decimal number.

## Input
- On the first line you will receive a number

## Output
- Print the given number with reversed digits

## Constraints
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input  | Output |
|:-------|:-------|
| 256    | 652    |
| 123.45 | 54.321 |

# 08. Number as array

## Description
Write a method that adds two positive integer numbers represented as arrays of digits (each array element `arr[i]` contains a digit; the last digit is kept in `arr[0]`).
Write a program that reads two arrays representing positive integers and outputs their sum.

## Input
- On the first line you will receive two numbers separated by spaces - the size of each array
- On the second line you will receive the first array
- On the third line you will receive the second array

## Output
- Print the sum as an array of digits (as described)
  - Digits should be separated by spaces

## Constraints
- Each of the numbers that will be added could have up to `10 000` digits.
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| 3 4<br>8 3 3<br>6 2 4 2 | 4 6 7 2 |
| 5 5<br>0 3 9 3 2<br>5 9 5 1 7 | 5 2 5 5 9 |

# 09. Sorting array

## Description
Write a method that returns the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
Write a program that sorts a given array.

## Input
- On the first line you will receive the number **N** - the size of the array
- On the second line you will receive **N** numbers separated by spaces - the array

## Output
- Print the sorted array
  - Elements must be separated by spaces

## Constraints
- 1 <= **N** <= 1024
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| 6<br>3 4 1 5 2 6 | 1 2 3 4 5 6 |
| 10<br>36 10 1 34 28 38 31 27 30 20 | 1 10 20 27 28 30 31 34 36 38 |

# 10. N Factorial

## Description
Write a method that multiplies a number represented as an array of digits by a given integer number.
Write a program to calculate `N!`.

## Input
- On the first line you will receive the number **N**

## Output
- Print `N!`

## Constraints
- 0 <= **N** <= 100
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input  | Output |
|:-------|:-------|
| 5      | 120    |

# 11. Adding polynomials

## Description
Write a method that adds two polynomials.
Represent them as arrays of their coefficients.
Write a program that reads two polynomials and prints their sum.

## Input
- On the first line you will receive the number **N**
- On the second line you will receive the first polynomial as coefficients separated by spaces
- On the third line you will receive the second polynomial as coefficients separated by spaces

## Output
- Print the sum of the polynomials

## Constraints
- 1 <= **N** <= 1024
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 3<br>5 0 1<br>7 4 -3 | 12 4 -2 |

# 12. Subtracting polynomials

## Description
Extend the previous program to support also subtraction and multiplication of polynomials.

# 13. Solve tasks

## Description
Write a program that can solve these tasks:
- Reverses the digits of a number
- Calculates the average of a sequence of integers
- Solves a linear equation `a * x + b = 0`

Create appropriate methods.
- Provide a simple text-based menu for the user to choose which task to solve.
- Validate the input data:
  - The decimal number should be non-negative
  - The sequence should not be empty
  - `a` should not be equal to `0`

# 14. Integer calculations

## Description
Write methods to calculate `minimum`, `maximum`, `average`, `sum` and `product` of given set of integer numbers.
Use variable number of arguments.
Write a program that reads `5` elements and prints their `minimum`, `maximum`, `average`, `sum` and `product`.

## Input
- On the first line you will receive `5` numbers separated by spaces

## Output
- Print their `minimum`, `maximum`, `average`, `sum` and `product`
  - Each on a new line
  - The `average` value should be printed with **two** digits of precision

## Constraints
- Each of the five numbers will be in the interval `[ -1000, 1000 ]`
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input  | Output |
|:------:|:------:|
| 3 7 9 18 0 | 0<br>18<br>7.40<br>37<br>0 |

# 15. Number calculations

## Description
Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
Use generic method (read in Internet about generic methods in C#).
