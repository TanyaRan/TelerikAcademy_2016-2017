function solve(args) {
    var i,
        n = +args[0],
        numbers = args[1].split(' '),
        x = +args[2],
        count = 0,
        len = numbers.length;

    for (i = 0; i < len; i += 1) {
        if (+numbers[i] === x) {
            count++;
        }
    }

    console.log(count);
}
