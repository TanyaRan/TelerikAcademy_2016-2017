# Homework: Multidimensional Arrays

# 01. Fill the matrix

## Description
Write a program that fills and prints a matrix of size `(n, n)` as shown below.

## Input
- On the first line you will receive the number **N**
- On the second line you will receive a character (`a`, `b`, `c`, `d`\*) which determines how to fill the matrix

## Output
- Print the matrix
  - Numbers on a row must be separated by a single spacebar
  - Each row must be on a new line

## Constraints
- 1 <= **N** <= 128
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input  | Output |
|:------:|:------:|
| 4<br>a | <table><tbody><tr><td>1</td><td>5</td><td>9</td><td>13</td></tr><tr><td>2</td><td>6</td><td>10</td><td>14</td></tr><tr><td>3</td><td>7</td><td>11</td><td>15</td></tr><tr><td>4</td><td>8</td><td>12</td><td>16</td></tr></tbody></table> |
| 4<br>b | <table><tbody><tr><td>1</td><td>8</td><td>9</td><td>16</td></tr><tr><td>2</td><td>7</td><td>10</td><td>15</td></tr><tr><td>3</td><td>6</td><td>11</td><td>14</td></tr><tr><td>4</td><td>5</td><td>12</td><td>13</td></tr></tbody></table> |
| 4<br>c | <table><tbody><tr><td>7</td><td>11</td><td>14</td><td>16</td></tr><tr><td>4</td><td>8</td><td>12</td><td>15</td></tr><tr><td>2</td><td>5</td><td>9</td><td>13</td></tr><tr><td>1</td><td>3</td><td>6</td><td>10</td></tr></tbody></table> |
| 4<br>d | <table><tbody><tr><td>1</td><td>12</td><td>11</td><td>10</td></tr><tr><td>2</td><td>13</td><td>16</td><td>9</td></tr><tr><td>3</td><td>14</td><td>15</td><td>8</td></tr><tr><td>4</td><td>5</td><td>6</td><td>7</td></tr></tbody></table> |

---

# 02. Maximal sum

## Description
Write a program that reads a rectangular matrix of size `N x M` and finds in it the square `3 x 3` that has maximal sum of its elements.
Print that sum.

## Input
- On the first line you will receive the numbers **N** and **M** separated by a single space
- On the next **N** lines there will be **M** numbers separated with spaces - the elements of the matrix

## Output
- Print the maximal sum of `3 x 3` square

## Constraints
- 3 <= **N**, **M** <= 1024
- Numbers in the matrix will be in the interval `[ -1000, 1000 ]`
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:------:|
| 3 3<br>**4 3 5<br>2 6 4<br>8 2 7** | 41 | 
| 5 5<br>**1 1 3 3 5<br>-6 -7 2 -3 -1<br>3 0 -4 5 9<br>7 -7 0 1 0<br>-7 -6 -4 -4 9** | 19 |

---

# 03. Sequence in matrix

## Description
We are given a matrix of strings of size `N x M`. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix and prints its length.

## Input
- On the first line you will receive the numbers **N** and **M** separated by a single space
- On the next **N** lines there will be **M** strings separated with spaces - the strings in the matrix

## Output
- Print the length of the longest sequence of equal equal strings in the matrix

## Constraints
- 3 <= **N**, **M** <= 128
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:------:|
| 6 6<br>92 11 23 42 59 48<br>09 92 23 72 56 14<br>17 63 92 46 85 **95**<br>34 12 52 69 23 **95**<br>26 88 78 71 29 **95**<br>26 34 16 63 39 **95** | 4 |

---

# 04. Binary search

## Description
Write a program, that reads from the console an array of `N` integers and an integer `K`, sorts the array and using the method `Array.BinSearch()` finds the largest number in the array which is &#8804; `K`. 

---

# 05. Sort by string length

## Description
You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

---

# 06. Matrix class

## Description
Write a class `Matrix`, to hold a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and `ToString()`.

---

# 07. Largest area in matrix

## Description
Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

## Input
- On the first line you will receive the numbers **N** and **M** separated by a single space
- On the next **N** lines there will be **M** numbers separated with spaces - the elements of the matrix

## Output
- Print the size of the largest area of equal neighbour elements

## Constraints
- 3 <= **N**, **M** <= 1024
- Time limit: **0.35s**
- Memory limit: **24MB**

## Sample tests

| Input | Output |
|:------|:------:|
| 5 6<br>1 **3** 2 2 2 4<br>**3 3 3** 2 4 4<br>4 **3** 1 2 **3 3**<br>4 **3** 1 **3 3** 1<br>4 **3 3 3** 1 1 | 13 |

_Hint: you can use the algorithm [Depth-first search](http://en.wikipedia.org/wiki/Depth-first_search) or [Breadth-first search](http://en.wikipedia.org/wiki/Breadth-first_search)._

---