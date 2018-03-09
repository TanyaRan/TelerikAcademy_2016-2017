# Homework: Strings

# 01. Reverse string

## Description
Write a JavaScript function that reverses a string.

## Input
- The input will consist of an array containing one string

## Output
- The output should be consisted of one line - the reversed string

## Constraints
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

### Sample Test 1

#### Input
```js
[ 'sample' ]
```

#### Output
```
elpmas
```

### Sample Test 2

#### Input
```js
[ 'qwertytrewq' ]
```

#### Output
```
qwertytrewq
```
---

# 02. Correct brackets

## Description
Write a JavaScript function to check if in a given expression the brackets are put correctly.

## Input
- The input will consist of an array containing a string

## Output
- The output should be consisted of one line
  - `Correct` or `Incorrect`

## Constraints
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

### Sample Test 1

#### Input
```js
[ '((a+b)/5-d)' ]
```

#### Output
```
Correct
```

### Sample Test 2

#### Input
```js
[ ')(a+b))' ]
```

#### Output
```
Incorrect
```
---

# 03. Sub-string in text

## Description
Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

## Input
- The input will consist of an array containing one string

## Output
- The output should be consisted of one line - the number of matches

## Constraints
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

#### Input
```js
[
	'in',
	'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]
```

#### Output
```
9
```

#### Explanation
We are liv**in**g **in** an yellow submar**in**e. We don't have anyth**in**g else. **in**side the submar**in**e is very tight. So we are dr**in**k**in**g all the day. We will move out of it **in** 5 days.

---

# 04. Parse tags

## Description
You are given a text. Write a function that changes the text in all regions:

```
<upcase>text</upcase> to uppercase.
<lowcase>text</lowcase> to lowercase
<orgcase>text</orgcase> does not change casing
```

_Note: Regions can be nested._

## Input
- The input will consist of an array containing one string

## Output
- The output should be consisted of one line

## Constraints
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

#### Input
```js
[ 'We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.' ]
```

#### Output
```
We are liViNg in a YELLOW SUBMARINE. We doN't have anything else.
```
---

# 05. nbsp

## Description
Write a function that replaces non breaking white-spaces in a text with `&nbsp`.

## Input
- The input will consist of an array containing one string

## Output
- The output should be consisted of one line

## Constraints
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

### Sample Test 1

#### Input
```js
[ 'hello world' ]
```

#### Output
```
hello&nbsp;world
```

### Sample Test 2

#### Input
```js
[ 'This text contains 4 spaces!!' ]
```

#### Output
```
This&nbsp;text&nbsp;contains&nbsp;4&nbsp;spaces!!
```
---

# 06. Extract text from HTML

## Description
Write a function that extracts the content of a html page given as text.
The function should return anything that is in a tag, without the tags.

## Input
- The input will consist of an array of strings

## Output
- The output should be consisted of one line - text inside tags

## Constraints
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

#### Input
```js
[
	'<html>',
	'  <head>',
	'    <title>Sample site</title>',
	'  </head>',
	'  <body>',
	'    <div>text',
	'      <div>more text</div>',
	'      and more...',
	'    </div>',
	'    in body',
	'  </body>',
	'</html>'
]
```

#### Output
```
Sample sitetextmore textand more...in body
```
---

# 07. Parse URL

## Description
Write a script that parses an URL address given in the format: `[protocol]://[server]/[resource]`
and extracts from it the `[protocol]`, `[server]` and `[resource]` elements.

## Input
- The input will consist of an array containing one string

## Output
- The output should be consisted of three line

## Constraints
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

### Input
```js
[ 'http://telerikacademy.com/Courses/Courses/Details/239' ]
```

#### Output
```
protocol: http
server: telerikacademy.com
resource: /Courses/Courses/Details/239
```
---

# 08. Replace tags

## Description
Write a JavaScript function that replaces in a HTML document given as string all the tags `<a href="…">…</a>` with corresponding tags `[TEXT](URL)`.

## Input
- The input will consist of an array containing one string

## Output
- The output should be consisted of one line

## Constraints
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

#### Input
```js
[ '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>' ]
```

#### Output
```
<p>Please visit [our site](http://academy.telerik.com) to choose a training course. Also visit [our forum](www.devbg.org) to discuss the courses.</p>
```
---

# 09. Extract e-mails

## Description
Write a function for extracting all email addresses from given text.
All sub-strings that match the format `<identifier>@<host>…<domain>` should be recognized as emails.
Return the emails as array of strings.

---

# 10. Find palindromes

## Description
Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

---

# 11. String format

## Description
Write a function that formats a string using placeholders.
The function should work with up to 30 placeholders and all types.

_Examples:_

```js
var str = stringFormat('Hello {0}!', 'Peter'); 
// str = 'Hello Peter!';

var frmt = '{0}, {1}, {0} text {2}';
var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
// str = '1, Pesho, 1 text Gosho'
```
---

# 12. Generate list

## Description
e a function that creates a HTML `<ul>` using a template for every HTML `<li>`.
source of the list should be an array of elements.
ace all placeholders marked with –{…}– with the value of the corresponding property of the object.

_Example:_ 
_HTML:_ 

```html
<div data-type="template" id="list-item">
    <strong>-{name}-</strong> <span>-{age}-</span>
</div>
```

_JavaScript:_ 

```js
var people = [{name: 'Peter', age: 14},…];
var tmpl = document.getElementById('list-item').innerHtml;
var peopleList = generateList(people, template);
// peopleList = '<ul><li><strong>Peter</strong> <span>14</span></li><li>…</li>…</ul>'
```