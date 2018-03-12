function solve(args) {
  var len = +args[0],
      arr = [],
      index;

  for (index = 0; index < len; index += 1) {

    arr[index] = index * 5;
    console.log(arr[index]);
  }
}
