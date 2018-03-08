function solve(args) {
  const input = String(args),
        len = input.length,
        hexKey = '0123456789ABCDEF';
  let sum = 0;

  for (let i = 0; i < len; i += 1) {
    let digit = hexKey.indexOf(input[i]);

    sum = digit + sum * 16;
  }

  console.log(sum);
}

// solve('FAE'); -> 4014