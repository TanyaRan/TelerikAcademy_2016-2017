function solve(args) {
    var i,
        len = +args[0],
        numbers = args[1].split(' '),
        count;

    console.log(LargerThanNeighboursCount(numbers, len));

    function LargerThanNeighboursCount(numbers, length) {
        count = 0;
        for (i = 1; i < length - 1; i += 1) {
            if (+numbers[i] > +numbers[i - 1] && +numbers[i] > +numbers[i + 1]) {
                count++;
            }
        }

        return count;
    }
}
