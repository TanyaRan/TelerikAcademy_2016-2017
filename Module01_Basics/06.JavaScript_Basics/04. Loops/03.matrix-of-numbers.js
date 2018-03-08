function solve(args) {
  const rows = +args[0];
  let strMatrix = [];

  for (let row = 0; row < rows; row += 1) {

    strMatrix[row] = '';
    let fill = row + 1;

    for (var col = 0; col < rows; col += 1) {
      strMatrix[row] += String(fill) + ' ';
      fill += 1;
    }

    strMatrix[row] = String(strMatrix[row]).trim();
    console.log(strMatrix[row]);
  }
}

// solve('4');