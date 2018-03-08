function solve(args) {
  const a = +args[0],
      b = +args[1],
      h = +args[2];
  let area;

  if (a <= 0 || b <= 0 || h <= 0) {
    console.log(0);
  }
  else {
    area = (a + b) * h / 2;
    console.log(area.toFixed(7));
  }
}

solve(['3', '4', '2']);
solve(['1', '-1', '3']);
