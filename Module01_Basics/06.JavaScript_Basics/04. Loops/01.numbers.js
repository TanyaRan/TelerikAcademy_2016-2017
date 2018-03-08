function solve(args) {
  let n = +args[0];

  let output = "";
  for(var i = 1; i <= n; i += 1) {
    output += i + " ";
  }

  output.trim();
  console.log(output);
}

solve(['12']);
