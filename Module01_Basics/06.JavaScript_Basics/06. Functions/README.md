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
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

| Input | Output        |
|:------|:--------------|
| Peter | Hello, Peter! |

---

# 02. Get largest number

## Description
Write a method `GetMax()` with two parameters that returns the larger of two integers.
Write a program that reads `3` integers from the console and prints the largest of them using the method `GetMax()`.

## Input
- On the first line you will receive `3` integers separated by spaces

## Output
- Print the largest of them

## Constraints
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

| Input   | Output |
|:--------|:-------|
| 8 3 6   | 8      |
| 7 19 19 | 19     |

---

# 03. English digit

## Description
Write a method that returns the last digit of given integer as an English word.
Write a program that reads a number and prints the result of the method.

## Input
- On the first line you will receive a number

## Output
- Print the last digit of the number as an English word

## Constraints
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

| Input  | Output |
|:-------|:-------|
| 42     | two    |

---

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
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| 8<br>28 6 21 6 -7856 73 73 -56<br>73 | 2 |

---

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
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| 6<br>-26 **-25** -28 **31** 2 27 | 2 |

---

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
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| 6<br>-26 **-25** -28 **31** 2 27 | 1 |

---

# 07. Sorting array

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
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| 6<br>3 4 1 5 2 6 | 1 2 3 4 5 6 |
| 10<br>36 10 1 34 28 38 31 27 30 20 | 1 10 20 27 28 30 31 34 36 38 |