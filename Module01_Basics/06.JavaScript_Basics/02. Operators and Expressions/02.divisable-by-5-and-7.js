function solve(args) {
  const number = +args[0];

  if (number % 35 !== 0) {
    console.log("false " + number);
  }
  else {
    console.log("true " + number);
  }
}

// solve('5');
// solve('70');
