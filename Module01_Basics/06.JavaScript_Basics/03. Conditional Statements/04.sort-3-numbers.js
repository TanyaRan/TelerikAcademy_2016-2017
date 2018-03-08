function solve(args) {
  const a = +args[0],
      b = +args[1],
      c = +args[2];
  let max,
      middle,
      min;

  if (a > b) {
    if (b > c) {
      max = a;
      middle = b;
      min = c;
    }
    else if(a > c) {
      max = a;
      middle = c;
      min = b;
    }
    else {
      max = c;
      middle = a;
      min = b;
    }
  }
  else {
    if (a > c) {
      max = b;
      middle = a;
      min = c;
    }
    else if (b > c) {
      max = b;
      middle = c;
      min = a;
    }
    else {
      max = c;
      middle = b;
      min = a;
    }
  }

  console.log(max + ' ' + middle + ' ' + min);
}

// solve(['12', '3', '25']);
// solve(['-3', '17', '-1']);