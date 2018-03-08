function solve(args) {
  const width = +args[0],
      height = +args[1];

  let area = width*height,
      perimeter = 2*(width + height);

  console.log(area.toFixed(2) + ' ' + perimeter.toFixed(2));
}

// solve(['3','5']);