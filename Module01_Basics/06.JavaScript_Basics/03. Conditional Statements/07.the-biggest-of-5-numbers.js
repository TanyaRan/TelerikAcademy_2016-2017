function solve(args) {
  const a = +args[0],
      len = args.length;
  let max = a;

  for (let i = 1; i < len; i++) {
    let element = +args[i];

    if (element > max) {
      max = element;
    }
  }

  console.log(max);
}

// solve(['-5', '2', '12', '3', '7']);
