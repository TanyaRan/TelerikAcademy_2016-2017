function solve(args) {
  const n = +args[0];
  let check = false,
      i,
      sqrtN;

  if (n < 2) {
    console.log("false");
  }
  else if (n === 2 || n === 3) {
    console.log("true");
  }
  else {
    sqrtN = Math.sqrt(n);
    for (i = 2; i <= sqrtN; i+=1) {
      if (n % i === 0) {
        console.log("false");
        check = true;
        break;
      }
    }

    if (check === false) {
      console.log("true");
    }
  }

}

// solve('29');
// solve('189');