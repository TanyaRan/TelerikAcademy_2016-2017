function solve(args) {
  const a = +args[0],
      b = +args[1],
      c = +args[2];
  let max = a;

  if (b > a) {
    if (c > b) {
      max = c;
    }
    else {
      max = b;
    }
  }
  else {
    if (c > a) {
      max = c;
    }
  }

  console.log(max);
}

// solve(['3', '87', '-3']);