let x = 5;
console.log(typeof x); // number
console.log(x); // 5

x = new Number(5);
console.log(typeof x); // object
console.log(x); // Number {}

x = null;
console.log(typeof x); // object

x = undefined;
console.log(typeof x); // undefined

x = '123';
console.log(typeof x); // string

x = true;
console.log(typeof x); // boolean