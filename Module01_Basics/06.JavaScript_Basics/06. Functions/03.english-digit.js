function solve(args) {
  var input = +args,
    digits = [
      "zero",
      "one",
      "two",
      "three",
      "four",
      "five",
      "six",
      "seven",
      "eight",
      "nine"];

  console.log(digits[input % 10]);;
}
