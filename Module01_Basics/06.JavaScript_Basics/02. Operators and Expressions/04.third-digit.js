function solve(args) {
  let number = +args[0],
      thirdDigit = number/100%10 | 0;

  if (thirdDigit !== 7) {
    console.log("false " + thirdDigit.toFixed());
  }
  else {
    console.log("true");
  }
}

// solve('777877');
// solve('5');
// solve('701');