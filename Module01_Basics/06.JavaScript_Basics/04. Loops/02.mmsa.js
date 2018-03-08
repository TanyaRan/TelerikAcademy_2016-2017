function solve(args) {
  let arr = args,
      min = Number.MAX_VALUE,
      max = Number.MIN_VALUE,
      sum = 0,
      avg,
      current,
      i,
      len = arr.length;

  for (i = 0; i < len; i+=1) {
    current = parseInt(arr[i]);

    if (max < current) {
        max = current;
    }

    if (min > current) {
        min = current;
    }

    sum += current;
  }

  avg = sum / len;

  console.log('min=' + min.toFixed(2));
  console.log('max=' + max.toFixed(2));
  console.log('sum=' + sum.toFixed(2));
  console.log('avg=' + avg.toFixed(2));
}

// solve(['1', '2', '3', '4', '-2']);
