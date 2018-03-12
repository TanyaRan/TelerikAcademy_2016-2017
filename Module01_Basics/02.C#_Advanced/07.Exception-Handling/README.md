# Homework: Exception Handling

# 01. Square root

## Description
Write a program that reads a number and calculates and prints its square root.
  - If the number is invalid or negative, print `Invalid number`.
  - In all cases finally print `Good bye`.
Use `try-catch-finally` block.

## Input
- On the only line you will receive a real number

## Output
- Print the square root of the number or `Invalid number` on the first line
  - Use `3` digits of precision
- Print `Good bye` on the second line

## Constraints
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input  | Output |
|:-------|:-------|
| number | Invalid number<br>Good bye |
| 4      | 2.000<br>Good bye |
| -3.14  | Invalid number<br>Good bye |
| 17     | 4.123<br>Good bye |

# 02. Enter numbers

## Description
Write a method `ReadNumber(int start, int end)` that enters an integer number in a given range `( start, end )`.
  - If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters `10` numbers:	`a1, a2, ..., a10`, such that `1 < a1 < ... < a10 < 100`

## Input
- You will receive 10 lines of input, each consisted of an integer number
  - `a1`
  - `a2`
  - `...`
  - `a10`

## Output
- Print `1 < a1 < ... < a10 < 100`
  - Or `Exception` if the above inequality is not true

## Constraints
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input  | Output |
|:------:|:------:|
| 5<br>7<br>15<br>29<br>46<br>47<br>60<br>70<br>89<br>98 | 1 < 5 < 7 < 15 < 29 < 46 < 47 < 60 < 70 < 89 < 98 < 100 |
| 87<br>10<br>29<br>28<br>43<br>58<br>95<br>41<br>2<br>46 | Exception |
| 5<br>11<br>20<br>27<br>49<br>41<br>52<br>81<br>89<br>99 | Exception |

# 03. Read file contents

## Description
Write a program that enters file name along with its full file path (e.g. `C:\WINDOWS\win.ini`), reads its contents and prints it on the console.
Find in MSDN how to use `System.IO.File.ReadAllText(...)`.
Be sure to catch all possible exceptions and print user-friendly error messages.

# 04. Download file

## Description
Write a program that downloads a file from Internet (e.g. [Ninja image](https://telerikacademy.com/Content/Images/news-img01.png)) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.
