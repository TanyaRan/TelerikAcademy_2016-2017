function solve(args) {
  const number = +args[0],
      isOne = ((number & 8) !== 0)?true:false; // 8 -> 1000

  if (isOne) {
    console.log(1);
  }
  else {
    console.log(0);
  }
}

// solve('12'); -> 1100
// solve('32'); -> 100000