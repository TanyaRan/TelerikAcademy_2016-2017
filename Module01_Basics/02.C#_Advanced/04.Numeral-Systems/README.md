# Homework: Numeral Systems

# 01. Decimal to binary

## Description
Write a program that converts a decimal number **N** to its binary representation.

## Input
- On the only line you will receive a decimal number - **N**
  - There will not be leading zeros

## Output
- Print the binary representation of **N** on a single line
  - There should not be leading zeros

## Constraints
- 1 <= **N** <= 10<sup>18</sup>
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 19    | 10011  |

# 02. Binary to decimal

## Description
Write a program that converts a binary number **N** to its decimal representation.

## Input
- On the only line you will receive a binary number - **N**
  - There will not be leading zeros

## Output
- Print the decimal representation of **N** on a single line
  - There should not be leading zeros

## Constraints
- 1 <= **N** <= 10<sup>18</sup> = 110111100000101101101011001110100111011001000000000000000000<sub>(2)</sub>
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 10011 | 19     |

# 03. Decimal to hexadecimal

## Description
Write a program that converts a decimal number **N** to its hexadecimal representation.

## Input
- On the only line you will receive a decimal number - **N**
  - There will not be leading zeros

## Output
- Print the hexadecimal representation of **N** on a single line
  - There should not be leading zeros
  - Use uppercase letters

## Constraints
- 1 <= **N** <= 10<sup>18</sup>
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 19    | 13     |

# 04. Hexadecimal to decimal

## Description
Write a program that converts a hexadecimal number **N** to its decimal representation.

## Input
- On the only line you will receive a hexadecimal number - **N**
  - There will not be leading zeros
  - Letters will be uppercase

## Output
- Print the decimal representation of **N** on a single line
  - There should not be leading zeros

## Constraints
- 1 <= **N** <= 10<sup>18</sup> = DE0B6B3A7640000<sub>(16)</sub>
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 13    | 19     |

# 05. Hexadecimal to binary

## Description
Write a program to convert hexadecimal numbers to binary numbers (directly).

## Input
- On the only line you will receive a decimal number - **N**
  - There will not be leading zeros
  - Letters will be uppercase

## Output
- Print the its binary representation on a single line
  - There should not be leading zeros

## Constraints
- 1 <= **N** <= 10<sup>18</sup> = DE0B6B3A7640000<sub>(16)</sub>
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 13    | 10011  |

# 06. Binary to hexadecimal

## Description
Write a program to convert binary numbers to hexadecimal numbers (directly).

## Input
- On the only line you will receive a decimal number - **N**
  - There will not be leading zeros

## Output
- Print the its binary representation on a single line
  - There should not be leading zeros
  - Use uppercase letters

## Constraints
- 1 <= **N** <= 10<sup>18</sup> = 110111100000101101101011001110100111011001000000000000000000<sub>(2)</sub>
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 10011 | 13     |

# 07. One system to any other

## Description
Write a program to convert the number **N** from any numeral system of given base **s** to any other numeral system of base **d**.

## Input
- On the first line you will receive the number **s**
- On the second line you will receive a number in base **s** - **N**
  - There will not be leading zeros
- On the third line you will receive the number **d**

## Output
- Print **N** in base **d**
  - There should not be leading zeros
  - Use uppercase letters

## Constraints
- 2 <= **s**, **d** <= 16
- 1 <= **N** <= 10<sup>18</sup>
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| 13<br>16<br>9 | 21 |

# 08. Binary short

## Description
Write a program that shows the binary representation of given 16-bit signed integer number **N** (the C# type `short`).

## Input
- On the only line you will receive a decimal number - **N**

## Output
- Print the its binary representation on a single line
  - There should be **exactly** 16 digits of output

## Constraints
- -2<sup>15</sup> <= **N** < 2<sup>15</sup>
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output           |
|:-----:|:----------------:|
| 11    | 0000000000001011 |
| -11   | 1111111111110101 |

# 09. Binary floating-point

## Description
Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type `float`).

## Input
- On the only line you will receive a decimal number - **N**

## Output
- Print the its binary representation on a single line
  - There should not be leading zeros

## Constraints
- 1 <= **N** <= 10<sup>19</sup>
- Time limit: **0.1s**
- Memory limit: **16MB**

_Example:_

| number | sign | exponent |         mantissa        |
|:------:|:----:|:--------:|:-----------------------:|
| -27,25 | 1    | 10000011 | 10110100000000000000000 |
