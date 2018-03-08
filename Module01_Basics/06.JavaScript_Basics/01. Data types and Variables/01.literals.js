let value = 5;
let biggestNum = Number.MAX_VALUE;
// --------------------------------------

let valueDouble = 8.75;
let roundedInt = (valueDouble + 0.5) | 0; // 9 - rounding
// --------------------------------------

let str = '1234';
let i = str | 0 + 1; // convert to integer
// --------------------------------------

let div = 5 / 0; // Infinity
let divMinus = -5 / 0; // -Infinity
let unknown = div / divMinus; // NaN - not a number
// --------------------------------------

let s = 'Welcome to JavaScript';
let name = 'Koko' + ' ' + 'Kokov';
let greeting = `${s}, ${name}`;
// --------------------------------------

let a;
console.log(a); // undefined
a = null;
console.log(a); // null
// --------------------------------------

let b = true;
console.log(b); // true