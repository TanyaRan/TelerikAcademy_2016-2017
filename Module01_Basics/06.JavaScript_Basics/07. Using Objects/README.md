# Homework: Using Objects

# 01. Planar coordinates

## Description
Write functions for working with shapes in standard Planar coordinate system.
  - **Points** are represented by coordinates
  - **Lines** are represented by two points, marking their beginning and ending
You will be given three line segments. Calculate their length.
Check if the line segments can form a triangle.

## Input
- The input will consist of an array containing **twelve values**
  - Line 1, Point 1 X
  - Line 1, Point 1 Y
  - Line 1, Point 2 X
  - Line 1, Point 2 Y
  - Line 2, Point 1 X
  - ...

## Output
- The output should be consisted of four lines
  - Three lines showing the length of each line segment
    - Use **2 digits of precision**
  - Fourth line should be one of:
    - `Triangle can be formed`
	- `Triangle can't be formed`

## Constraints
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

### Sample Test 1

#### Input
```js
[
  '5', '6', '7', '8',
  '1', '2', '3', '4',
  '9', '10', '11', '12'
]
```

#### Output
```
2.83
2.83
2.83
Triangle can be built
```

### Sample Test 2

#### Input
```js
[
  '7', '7', '2', '2',
  '5', '6', '2', '2',
  '95', '-14.5', '0', '-0.123'
]
```

#### Output
```
7.07
5.00
96.08
Triangle can not be built
```
---

# 02. Remove elements

## Description
Write a function that removes all elements with a given value.
Attach it to the array type.
Read about **prototype** and how to attach methods.

```js
var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
arr.remove(1); // arr = [2,4,3,4,111,3,2,'1'];
```

You will be given an array of strings. Remove all occurrences of the first element in the array in itself.

## Input
- The input will consist of an array of strings

## Output
- The output should be the array with some elements removed
  - Each string should be on a separate line

## Constraints
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

### Sample Test 1

#### Input
```js
[ '1', '2', '3', '2', '1', '2', '3', '2' ]
```

#### Output
```
2
3
2
2
3
2
```

### Sample Test 2

#### Input
```js
[
  '_h/_',
  '^54F#',
  'V',
  '^54F#',
  'Z285',
  'kv?tc`',
  '^54F#',
  '_h/_',
  'Z285',
  '_h/_',
  'kv?tc`',
  'Z285',
  '^54F#',
  'Z285',
  'Z285',
  '_h/_',
  '^54F#',
  'kv?tc`',
  'kv?tc`',
  'Z285'
]
```

#### Output
```
^54F#
V
^54F#
Z285
kv?tc`
^54F#
Z285
kv?tc`
Z285
^54F#
Z285
Z285
^54F#
kv?tc`
kv?tc`
Z285
```
---

# 03. Deep copy

## Description
Write a function that makes a deep copy of an object.
The function should work for both primitive and reference types.

---

# 04. Has property

## Description
Write a function that checks if a given object contains a given property.

```js
var obj  = …;
var hasProp = hasProperty(obj, 'length');
```
---

# 05. Youngest person

## Description
Write a function that finds the youngest person in a given array of people and prints his/hers full name.
Each person has properties `firstname`, `lastname` and `age`.

_Example:_

```js
var people = [
    { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname: 'John', lastname: 'Doe', age: 42 }
];
```

## Input
- The input will consist of an array containing **3 \* N values**
  - **N** is the number of people
  - Values represent `firstname`, `lastname`, `age`, ...

## Output
- The output should be consisted of one line
  - The full name of the youngest person

## Constraints
- Time limit: **0.2s**
- Memory limit: **16MB**

## Sample tests

### Sample Test 1

#### Input
```js
[
  'Gosho', 'Petrov', '32',
  'Bay', 'Ivan', '81',
  'John', 'Doe', '42'
]
```

#### Output
```
Gosho Petrov
```

### Sample Test 2

#### Input
```js
[
  'Penka', 'Hristova', '61',
  'System', 'Failiure', '88',
  'Bat', 'Man', '16',
  'Malko', 'Kote', '72'
]
```

#### Output
```
Bat Man
```
---

# 06. Group people

## Description
Write a function that groups an array of people by age.
The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
Use function overloading (i.e. just one function)

_Example:_

```js
var people = [
  { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
  { firstname: 'Bay', lastname: 'Ivan', age: 81 },
  { firstname: 'John', lastname: 'Doe', age: 42 },
  { firstname: 'Pesho', lastname: 'Pesho', age: 22 },
  { firstname: 'Asdf', lastname: 'Xyz', age: 81 },
  { firstname: 'Gosho', lastname: 'Gosho', age: 22 }
];

var groupedByAge = group(people);
```

- `groupedByAge` must be:

```js
{
  '22': [
    { firstname: 'Pesho', lastname: 'Pesho', age: 22 },
    { firstname: 'Gosho', lastname: 'Gosho', age: 22 }
  ],
  '32': [
    { firstname: 'Gosho', lastname: 'Petrov', age: 32 }
  ],
  '42': [
    { firstname: 'John', lastname: 'Doe', age: 42 }
  ],
  '81': [
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname: 'Asdf', lastname: 'Xyz', age: 81 }
  ]
}
```
