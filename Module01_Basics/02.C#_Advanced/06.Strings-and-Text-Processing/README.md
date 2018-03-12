# Homework: Strings and Text Processing

# 01. Strings in C&#35;

## Description
Describe the strings in C#.
What is typical for the string data type?
Describe the most important methods of the String class.

# 02. Reverse string

## Description
- Write a program that reads a string, reverses it and prints the result on the console.

## Input
- On the only line you will receive a string

## Output
- Print the string in reverse on a single line

## Constraints
- 1 <= **size of string** <= 10000
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input  | Output |
|:------:|:------:|
| sample | elpmas |
| somestring | gnirtsemos |

# 03. Correct brackets

## Description
Write a program to check if in a given expression the `(` and `)` brackets are put correctly.

## Input
- On the only line you will receive an expression

## Output
- Print `Correct` if the brackets are correct
  - `Incorrect` otherwise

## Constraints
- 1 <= **length of expression** <= 10000
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input       | Output    |
|:-----------:|:---------:|
| ((a+b)/5-d) | Correct   |
| )(a+b))     | Incorrect |

# 04. Sub-string in text

## Description
Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

## Input
- On the first line you will receive a string - the pattern
- On the second line you will receive a string - the text

## Output
- Print a number on a single line
  - The number of occurrences

## Constraints
- The length of the two strings will be <= 4096
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| in<br>We are liv**in**g **in** an yellow submar**in**e. We don't have anyth**in**g else. **in**side the submar**in**e is very tight. So we are dr**in**k**in**g all the day. We will move out of it **in** 5 days. | 9 |

# 05. Parse tags

## Description
You are given a text. Write a program that changes the text in all regions surrounded by the tags `<upcase>` and `</upcase>` to upper-case.

## Input
- On the only line you will receive a string - the text

## Output
- Print the changed string on one line

## Constraints
- The tags will not be nested.
- String length will be <= 10000
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| We are living in a `<upcase>`**yellow submarine**`</upcase>`. We don't have `<upcase>`**anything**`</upcase>` else. | We are living in a **YELLOW SUBMARINE**. We don't have **ANYTHING** else. |

# 06. String length

## Description
Write a program that reads from the console a string of maximum `20` characters. If the length of the string is less than `20`, the rest of the characters should be filled with `*`.

## Input
- On the only line you will receive a string

## Output
- Output a string with length `20`

## Constraints
- The length of the given string will be <= 20
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:-----:|:------:|
| hello | hello\*\*\*\*\*\*\*\*\*\*\*\*\*\*\* |
| -=StringOfLength20=- | -=StringOfLength20=- |

# 07. Encode/decode

## Description
Write a program that encodes and decodes a string using given encryption key (cipher).
- The key consists of a sequence of characters. 
- The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

# 08. Extract sentences

## Description
Write a program that extracts from a given text all sentences containing given **word**.

## Input
- On the first line you will receive a string - the word
- On the second line you will receive a string - the text

## Output
- Print only the sentences containing the word on a single line

## Constraints
- Sentences are separated by `.` and the words – by **non-letter symbols**
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| **in**<br>We are living **in** a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it **in** 5 days. | We are living **in** a yellow submarine. We will move out of it **in** 5 days. |

# 09. Forbidden words

## Description
We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.

## Sample tests

| Input | Output |
|:-----:|:------:|
| Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.<br>**PHP** **CLR** **Microsoft** | \*\*\*\*\*\*\*\*\* announced its next generation \*\*\* compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in \*\*\*. |

# 10. Unicode characters

## Description
Write a program that converts a string to a sequence of C# Unicode character literals.

## Input
- On the only input line you will receive a string

## Output
- Print the string in C# Unicode character literals on a single line

## Constraints
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| Hi!   | \u0048\u0069\u0021 |

# 11. Format number

## Description
Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.

# 12. Parse URL

## Description
Write a program that parses an URL address given in the format: `[protocol]://[server]/[resource]` and extracts from it the `[protocol]`, `[server]` and `[resource]` elements.

## Input
- On the only line you will receive an address

## Output
- Print the protocol, server and resource as shown below

## Constraints
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| http://telerikacademy.com/Courses/Courses/Details/212 | [protocol] = http<br>[server] = telerikacademy.com<br>[resource] = /Courses/Courses/Details/212 |
| https://github.com/gentoo/gentoo.git | [protocol] = https<br>[server] = github.com<br>[resource] = /gentoo/gentoo.git |

# 13. Reverse sentence

## Description
Write a program that reverses the words in a given sentence.

## Sample tests

| Input                                  | Output                                 |
|:---------------------------------------|:---------------------------------------|
| C# is not C++, not PHP and not Delphi! | Delphi not and PHP, not C++ not is C#! |

# 14. Word dictionary

## Description
A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.

## Sample tests

| Input                                  | Output                                 |
|:---------------------------------------|:---------------------------------------|
| .NET      | platform for applications from Microsoft |
| CLR       | managed execution environment for .NET   |
| namespace | hierarchical organization of classes     |

# 15. Replace tags

## Description
Write a program that replaces in a HTML document given as string all the tags `<a href="URL">TEXT</a>` with corresponding markdown notation `[TEXT](URL)`.

## Input
- On the only input line you will receive a string

## Output
- Print the string with replaced tags

## Constraints
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| `<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>` | `<p>Please visit [our site](http://academy.telerik.com) to choose a training course. Also visit [our forum](www.devbg.org) to discuss the courses.</p>` |

# 16. Date difference

## Description
*	Write a program that reads two dates in the format: `day.month.year` and calculates the number of days between them.

_Example:_

	Enter the first date: 27.02.2006
	Enter the second date: 3.03.2006
	Distance: 4 days

# 17. Date in Bulgarian

## Description
Write a program that reads a date and time given in the format: `day.month.year hour:minute:second` and prints the date and time after `6` hours and `30` minutes (in the same format) along with the day of week in Bulgarian.

# 18. Extract e-mails

## Description
Write a program for extracting all email addresses from given text.
All sub-strings that match the format `<identifier>@<host>…<domain>` should be recognized as emails.

# 19. Dates from text in Canada

## Description
Write a program that extracts from a given text all dates that match the format `DD.MM.YYYY`.
Display them in the standard date format for Canada.

# 20. Palindromes

## Description
Write a program that extracts from a given text all palindromes, e.g. `ABBA`, `lamal`, `exe`.

# 21. Letters count

## Description
Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.

# 22. Words count

## Description
Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

# 23. Series of letters

## Description
Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

## Input
- On the only input line you will receive a string

## Output
- Print the string without consecutive identical letters

## Constraints
- Time limit: **0.1s**
- Memory limit: **16MB**

## Sample tests

| Input | Output |
|:------|:-------|
| aaaaabbbbbcdddeeeedssaa | abcdedsa |

# 24. Order words

## Description
Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

# 25. Extract text from HTML

## Description
Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

_Example input:_

	<html>
	  <head><title>News</title></head>
	  <body><p><a href="http://academy.telerik.com">Telerik
		Academy</a>aims to provide free real-world practical
		training for young people who want to turn into
		skilful .NET software engineers.</p></body>
	</html>

_Output:_ 

Title: News

Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.
