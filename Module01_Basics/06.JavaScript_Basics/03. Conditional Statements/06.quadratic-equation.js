function solve(args) {
  const a = +args[0],
      b = +args[1],
      c = +args[2];
  let d,
      x1,
      x2,
      temp;

  if (a !== 0) {
    d = b*b - 4*a*c;
    if (d < 0) {
      console.log("no real roots");
    }
    else if (d == 0) {
      x1 = -b/(2*a);
      console.log('x1=x2=' + x1.toFixed(2));
    }
    else {
      x1 = (-b - Math.sqrt(d))/(2*a);
      x2 = (-b + Math.sqrt(d))/(2*a);
      if (x1 > x2) {
        temp = x1;
        x1 = x2;
        x2 = temp;
      }
      console.log('x1=' + x1.toFixed(2) + '; x2=' + x2.toFixed(2));
    }
  }
  else {
    x1 = -c/b;
    console.log('x1=' + result.toFixed(2));
  }
}

// solve(['5', '2', '8']);
// solve(['-0.5', '4', '-8']);
// solve(['2', '5', '-3']);
