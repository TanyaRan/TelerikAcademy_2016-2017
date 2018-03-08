function solve(args) {
  var number = +args[0];

  if (number % 2 !== 0) {
    console.log("odd " + number );
  }
  else {
    console.log("even " + number);
  }
}

// solve('3');
// solve('50');