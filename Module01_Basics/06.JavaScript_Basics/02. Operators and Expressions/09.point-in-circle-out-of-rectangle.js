function solve(args) {
  const x = +args[0],
      y = +args[1];

  if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 2.25) {
    if ((x < -1) || (x > 5) || (y < -1) || (y > 1)){
      console.log("inside circle outside rectangle");
    }
    else {
      console.log("inside circle inside rectangle");
    }
  }
  else {
    if ((x < -1) || (x > 5) || (y < -1) || (y > 1)){
      console.log("outside circle outside rectangle");
    }
    else {
      console.log("outside circle inside rectangle");
    }
  }
}

// solve(['2.5','2']); // outside outside
// solve(['0','1']); // inside inside
// solve(['2.5','1']); // inside inside
// solve(['1','2']); // inside outside
