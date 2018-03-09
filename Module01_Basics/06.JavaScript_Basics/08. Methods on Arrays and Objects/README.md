# Homework: Methods on Arrays and Objects

# 01. Make person

## Description
- Write a function for creating persons.
  - Each person must have **firstname**, **lastname**, **age** and **gender** (`true` is female, `false` is male)
- Generate an array with ten person with different names, ages and genders

---

# 02. People of age

## Description
- Write a function that checks if an array of person contains only people of age (with age 18 or greater)
  - Use **only array methods** and no regular loops (`for`, `while`)

---

# 03. Underage people 

## Description
- Write a function that prints all underaged persons of an array of person
  - Use **Array#filter** and **Array#forEach**
  - Use **only array methods** and no regular loops (`for`, `while`)

---

# 04. Average age of females

## Description
- Write a function that calculates the average age of all females, extracted from an array of persons
  - Use **Array#filter**
  - Use **only array methods** and no regular loops (`for`, `while`)

---

# 05. Youngest person

## Description
- Write a function that finds the youngest male person in a given array of people and prints his full name
  - Use **only array methods** and no regular loops (`for`, `while`)
  - Use **Array#find**

---

# 06. Group people

## Description
- Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
  - Use **Array#reduce**
  - Use **only array methods** and no regular loops (`for`, `while`)

_Example:_

```js
result = {
    'a': [{
        firstname: 'Asen',
        /* ... */
    }, {
        firstname: 'Anakonda',
        /* ... */
    }],
    'j': [{
        firstname: 'John',
        /* ... */
    }]
};
```
