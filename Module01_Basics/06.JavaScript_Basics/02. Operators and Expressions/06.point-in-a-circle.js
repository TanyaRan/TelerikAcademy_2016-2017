function solve(args) {
  const x = +args[0],
      y = +args[1];

  const distance = Math.sqrt(x*x + y*y),
      inside = (distance < 4)?true:false;

  if (inside) {
    console.log("yes " + distance.toFixed(2));
  }
  else {
    console.log("no " + distance.toFixed(2));
  }
}


// solve(['3', '4']);
// solve(['-1', '1']);